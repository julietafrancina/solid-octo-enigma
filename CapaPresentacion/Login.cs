﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;

namespace SistemaDeVentas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            Usuario ousuario = new CN_Usuario().listar().Where(u => u.dni == Convert.ToInt32(txtDNI.Text) && u.contraseña == txtClave.Text).FirstOrDefault();

            if(ousuario != null)
            {
                Inicio form = new Inicio();
                form.Show();
                this.Hide();

                form.FormClosing += Frm_closing;
            }
            else
            {
                MessageBox.Show("Usuario no encontrado","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }
        private void Frm_closing(object sender, FormClosingEventArgs e)
            {
            txtDNI.Text = "";
            txtClave.Text = "";
            this.Show();
            }
    }
}
