﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistencias.presentacion.AsistenteInstalacion
{
    public partial class EleccionServidor : Form
    {
        public EleccionServidor()
        {
            InitializeComponent();
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            Dispose();
            InstalarBD frm = new InstalarBD();
            frm.ShowDialog();
        }

        private void btnPuntoControl_Click(object sender, EventArgs e)
        {
            Dispose();
            ConexionRemota frm = new ConexionRemota();
            frm.ShowDialog();
        }
    }
}
