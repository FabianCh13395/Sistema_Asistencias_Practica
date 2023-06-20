using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistencias.presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            panelBienvenida.Dock = DockStyle.Fill;
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            pnlPadre.Controls.Clear();
            Personal control =new Personal();
            control.Dock = DockStyle.Fill;
            pnlPadre.Controls.Add(control);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            pnlPadre.Controls.Clear();
            CtlUsuarios usuario=new CtlUsuarios();
            usuario.Dock = DockStyle.Fill;
            pnlPadre.Controls.Add(usuario);
        }
    }
}
