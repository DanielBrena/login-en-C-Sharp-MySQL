using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConsoleApplication15;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = false;
            this.groupBoxOperaciones.Visible = false;
            this.label3.Visible = false;
        }

        private void buttonAccederI_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            Usuario usuario = usuarioDAO.buscarUsuario(textBoxUsuarioI.Text, textBoxContrasenaI.Text);
            if (usuario != null)
            {
                this.groupBoxIniciaSesion.Visible = false;
                UsuarioDAO usuarioDAO2 = new UsuarioDAO();
                this.dataGridView1.DataSource = usuarioDAO2.selectUsuarios();
                this.dataGridView1.Visible = true;
                this.groupBoxOperaciones.Visible = true;
            }
            else
            {
                this.label3.Visible = true;
            }

        }

        private void buttonrRecargarO_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDAO2 = new UsuarioDAO();
            this.dataGridView1.DataSource = usuarioDAO2.selectUsuarios();
        }

        private void buttonAgregarO_Click(object sender, EventArgs e)
        {
            this.groupBoxAgregar.Visible = true;
            this.groupBoxOperaciones.Visible = false;
        }

        private void buttonCancelarA_Click(object sender, EventArgs e)
        {
            this.groupBoxAgregar.Visible = false;
            this.groupBoxOperaciones.Visible = true;
            this.limpiarCampos();
        }

        public void limpiarCampos()
        {
            this.textBoxNombreA.Text = "";
            this.textBoxUsuarioA.Text = "";
            this.textBoxContrasenaA.Text = "";
            this.numericUpDownEstatusA.Value = 0;
            this.numericUpDownPerfilA.Value = 1;
            this.label9.Visible = false;
        }

        private void buttonAgregarA_Click(object sender, EventArgs e)
        {
            if (this.textBoxNombreA.Text != "" && this.textBoxUsuarioA.Text != ""
                && this.textBoxContrasenaA.Text != "")
            {
                UsuarioDAO usuarioDAO = new UsuarioDAO();
                usuarioDAO.agregarUsuario(this.textBoxNombreA.Text,this.textBoxUsuarioA.Text,this.textBoxContrasenaA.Text, (int)this.numericUpDownEstatusA.Value,(int)this.numericUpDownPerfilA.Value);
                UsuarioDAO usuarioDAO2 = new UsuarioDAO();
                this.dataGridView1.DataSource = usuarioDAO2.selectUsuarios();
                this.limpiarCampos();
                this.groupBoxAgregar.Visible = false;
                this.groupBoxOperaciones.Visible = true;
            }
            else
            {
                this.label9.Visible = true;
            }
        }
    }
}
