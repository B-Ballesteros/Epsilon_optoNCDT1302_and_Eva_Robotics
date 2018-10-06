using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text;
using System.Threading;

namespace Lector_Laser
{
    public partial class mForm : Form
    {

        #region constructores

        /// <summary>
        /// Constructor principal, inicializa la ventana y carga los 
        /// eventos necesarios para la ejecución del programa.
        /// </summary>
        public mForm()
        {
            InitializeComponent();
            cargarEventos();
        }
        #endregion

        #region campos
        CommandManager cmd;
        #endregion

        #region Metodos

        /// <summary>
        /// Este método se ejecuta al iniciar el programa, crea una lista
        /// desplegable con los puertos COM disponibles, en caso de no
        /// encontrar ninguno le ofrece la opcion al usuario de reiniciar
        /// la aplicación para realizar la búsqueda de nuevo.
        /// </summary>
        private void cargarPuertos()
        {
            /*string[] puertos = SerialPort.GetPortNames();
            if (puertos.Length > 0)
            {
                foreach (string s in puertos)
                {
                    mPDisponibles.DropDownItems.Add(s, null, ddItemsClic);
                }
            }
            else
            {
                mPDisponibles.DropDownItems.Add("No se detecto ningún puerto\n" +
                "Clic aqui para reiniciar", null, ddVoidClic);
            }*/
            using( ConexionDialog cd = new ConexionDialog())
            {
                DialogResult result = cd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //MessageBox.Show(cd.Puerto);
                    CommandLib.ERR_CODE open = cmd.Open(cd.Puerto);
                    if (open !=
                        CommandLib.ERR_CODE.ERR_NOERROR)
                    {
                        MessageBox.Show("No se puede accesar al sensor", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Conectado correctamente en el puerto " +
                            cd.Puerto, "Información", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
        }

        /*private void background(ref CommandManager cmd)
        {
            int k = 0;
            cmd.Stop = false;
            cmd.getLecturas(k);
        }*/


        /// <summary>
        /// Este método se ejecuta para acualizar el contenido de un textbox
        /// a tavez de ls diferentes hilos del programa. Es necesario ya que 
        /// la información obtenida se realiza en un espacio de procesamiento
        /// (hilo) y los componentes estan en otro.
        /// </summary>
        /// <param name="s"></param>
        public void updateTextBox(string s)
        {
            try
            {
                if (this.texto.InvokeRequired)
                {
                    this.texto.Invoke(new TextboxUpdate(updateTextBox),
                        new object[] { s });
                }
                else
                {
                    this.texto.Text = s;
                }
            }
            catch (Exception) { }
        }

        #endregion

        #region eventos

        /// <summary>
        /// Este void se encarga de enlazar todos los eventos que ocurren
        /// a los métodos correspondientes
        /// </summary>
        private void cargarEventos()
        {
            string message = "";
            if (ResourceManager.cargarDLL(out message))
            {
            }
            else
            {
                MessageBox.Show("le programa NO puede iniciar las librerías" +
                    " para obtener información del sensor", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cmd = new CommandManager(this);
            this.FormClosing += new FormClosingEventHandler(closing);
            mSalir.Click += new EventHandler(msClic);
            //cargarPuertos();
            s_prueba.Click += new EventHandler(sendText);
            detener.Click += new EventHandler(Stop);
            mPDisponibles.Click += new EventHandler(mPDClic);
            maInfo.Click += new EventHandler(maInfoClic);
        }

        /// <summary>
        /// Este evento se ejecuta cuando se cierra la ventana, verifica si el
        /// puerto serie esta abierto y de ser así lo cierra para evitar
        /// errores. Los parametros son parte del constructor por defecto
        /// proporcionado por la API.
        /// </summary>
        /// <param name="sender">Quien envía el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void closing(object sender, FormClosingEventArgs e)
        {
            CommandLib.ERR_CODE close = cmd.Cerrar();
            if (close !=
                CommandLib.ERR_CODE.ERR_NOERROR)
            {
                MessageBox.Show("Error al liberar el sensor", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Exit();
        }

        /// <summary>
        /// Este evento ocurre cuando se hace clic en la opcion "salir" del 
        /// menu, provoca la terminación de la ejecución del programa.
        /// </summary>
        /// <param name="sender">Quien envía el evento</param>
        /// <param name="e">Argumentos</param>
        private void msClic(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Este evento se ejecuta cuando se da clic en alguno de los 
        /// peurtos encontrados por el sistema, intenta comunicarse con el
        /// puerto seleccionado y de lograrlo envía un mensaje al usuario
        /// indicandole en que puerto esta conectado. En el caso contrario
        /// le envía un mensaje al usuario indicandole el error que ha ocurrido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ddItemsClic(object sender, EventArgs e)
        {
            CommandLib.ERR_CODE open = cmd.Open(sender.ToString());
            if (open !=
                CommandLib.ERR_CODE.ERR_NOERROR)
            {
                MessageBox.Show("No se puede accesar al sensor", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Conectado correctamente en el puerto " +
                    sender.ToString(), "Información", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
           
        }

        /// <summary>
        /// Este evento se ejecuta cuando no existen puertos COM disponibles
        /// es decir, no se detectan dispositivos con comunicación serial
        /// Le envía un mensaje al usuario para saber si desea reiniciar
        /// la aplicación para ejecutar de nuevo la búsqueda de puertos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ddVoidClic(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Desea reiniciar la aplicación para repetir la " +
                "búsqueda de puertos?", "Información",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        /// <summary>
        /// Inicia un nuevo hilo de procesamiento en segundo plano en el 
        /// cual se ejecuta la instrucción para llamar las lecturas del 
        /// sensor y despues mostrarlas en pantalla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendText(object sender, EventArgs e)
        {
            int k = 0;
            cmd.Stop = false;
            Thread hilo = new Thread(new ParameterizedThreadStart(cmd.getLecturas));
            hilo.Start(k);
        }

        /// <summary>
        /// Envía una señal para detener el envío de lecuturas desde el sensor
        /// a la interfaz.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stop(object sender, EventArgs e)
        {
            cmd.Stop = true;
        }

        private void mPDClic(object sender, EventArgs e)
        {
            cargarPuertos();
        }


        private void maInfoClic(object sender, EventArgs e)
        {
            using (iForm i = new iForm())
            {
                i.ShowDialog();
            }
        }

        #endregion

        #region delegados

        private delegate void TextboxUpdate(string s);

        #endregion
    }
}
