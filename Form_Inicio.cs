using ApInv.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApInv
{
    public partial class Form_Inicio : Form
    {
        public Form_Inicio()
        {
            InitializeComponent();
        }

        private void Button_Agregar_Click(object sender, EventArgs e)
        {
            //vincular o abrir formulario agregar
            Form fmagregar = new FormAgregar();
            fmagregar.Show();
                                

        }

        private void Form_Inicio_Load(object sender, EventArgs e)
        {

        }

        private void Button_Modificar_Click(object sender, EventArgs e)
        {
            //vincular o abrir formulario modificar
            Form fmmodificar = new FromModificar();
            fmmodificar.Show();
        }

        private void Button_Consulta_Click(object sender, EventArgs e)
        {
            //vincular o abrir formulario consulta
            Form fmconsulta = new FormConsulta();
            fmconsulta.Show();
        }

        //boton menu abrir y cerrar las opciones
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 75;
            }
            else
                MenuVertical.Width = 250;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnRestaurar.Visible = true;
            BtnMaximizar.Visible = false;
            
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
            
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
