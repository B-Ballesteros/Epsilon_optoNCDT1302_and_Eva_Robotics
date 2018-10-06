using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lector_Laser
{
    class CommandManager
    {
        #region campos

        private UInt32 sensor;
        private bool stop = false;
        private mForm f;
        #endregion

        #region propiedades

        public bool Stop
        {
            get
            {
                return stop;
            }
            set
            {
                stop = value;
            }
        }

        #endregion

        #region Constructores

        public CommandManager(mForm f)
        {
            if ((sensor = CommandLib.CreateSensorInstance(
                CommandLib.ME_SENSOR.SENSOR_ILD1302)) == 0)
            {
                MessageBox.Show("No se puede crear la instancia del objeto",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            this.f = f;
        }

        #endregion

        #region Métodos

        public CommandLib.ERR_CODE Open(string puerto)
        {
            return CommandLib.OpenSensorRS232(sensor, puerto);
        }

        public void getLecturas(object t)
        {
            int i = Convert.ToInt32(t);
            //int a = 0;
            int[] rawData = new int[100];
            double[] sData = new double[100];
            string q = "";
            while (!Stop)
            {
                CommandLib.TransferData(sensor, rawData, sData, rawData.Length, ref i);
                if (sData[0] > -10)
                {
                    q = sData[0].ToString("0.0000");
                }
                else
                {
                    q = "Fuera de Rango";
                }
                f.updateTextBox(q);
            }
            MessageBox.Show("Stopped");
        }

        public CommandLib.ERR_CODE Cerrar()
        {
            if (!Stop)
            {
                Stop = true;
            }
            return CommandLib.CloseSensor(sensor);
        }

        #endregion
    }
}
