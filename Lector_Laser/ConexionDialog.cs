using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Lector_Laser
{
    public partial class ConexionDialog : Form
    {
        #region constructores

        public ConexionDialog()
        {
            InitializeComponent();
            cargarEventos();
        }

        #endregion

        #region campos
        private string puerto;
        #endregion

        #region propiedades
        public string Puerto
        {
            get
            {
                return puerto;
            }
        }
        #endregion

        #region métodos
        #endregion

        #region eventos

        private void cargarEventos()
        {
            string[] a = 
            {
                "COM6",
                "COM7",
                "COM8"
            };
            optoCB.DataSource = SerialPort.GetPortNames(); 
            optoCB.SelectedIndex = -1;
            evaCB.DataSource = SerialPort.GetPortNames();
            evaCB.SelectedIndex = -1;
            optoCB.SelectedValueChanged += new EventHandler(cbSIChanged);
            aButton.Click += new EventHandler(aBClic);
        }

        private void cbSIChanged(object sender, EventArgs e)
        {
            puerto = optoCB.SelectedItem.ToString();
        }

        private void aBClic(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(puerto))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
            //this.Close();
        }
        #endregion
    }
}
