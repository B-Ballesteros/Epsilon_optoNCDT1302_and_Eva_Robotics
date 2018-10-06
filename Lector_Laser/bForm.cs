using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lector_Laser
{
    public partial class bForm : Form
    {
        public bForm()
        {
            InitializeComponent();
            cargarEventos();
        }


        #region campos

        private bool lecturas = false;
        #endregion

        #region Metodos

        private void showInfo()
        {
            using (iForm i = new iForm())
            {
                i.ShowDialog();
            }
        }

        private void startLectures()
        {
            mForm m = new mForm();
            m.Show();
            this.Close();
        }

        #endregion

        #region eventos

        private void cargarEventos()
        {
            ilButton.Click += new EventHandler(ilbClic);
            ipButton.Click += new EventHandler(ipbClic);
            this.FormClosing += new FormClosingEventHandler(closing);
        }

        private void ilbClic(object sender, EventArgs e)
        {
            lecturas = true;
            startLectures();
        }

        private void ipbClic(object sender, EventArgs e)
        {
            showInfo();
        }

        private void closing(object sender, EventArgs e)
        {
            if (!lecturas)
            {
                Application.Exit();
            }
        }
        #endregion
    }
}
