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
using System.Runtime.InteropServices;

namespace ApInv
{
    public partial class Form_Inicio : Form
    {
        public Form_Inicio()
        {
            InitializeComponent();
        }
        //funcion mover la ventana programa
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        //funcion abrir ventana o formulario dentro del panel contenedor
        private void AbrirFormPanelContenerdor(object FormAgregar)
        {

            if (this.PanelControl.Controls.Count > 0)
                this.PanelControl.Controls.RemoveAt(0);
            Form fh = FormAgregar as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelControl.Controls.Add(fh);
            this.PanelControl.Tag = fh;
            fh.Show();

        }


        //funcion abrir ventana o formulario dentro del panel contenedor
        private void AbrirFormPanelContenerdorModificar(object FormModificar)
        {

            if (this.PanelControl.Controls.Count > 0)
                this.PanelControl.Controls.RemoveAt(0);
            Form fh = FormModificar as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelControl.Controls.Add(fh);
            this.PanelControl.Tag = fh;
            fh.Show();

        }


        //vincular o abrir formulario agregar
        private void Button_Agregar_Click(object sender, EventArgs e)
        {

            AbrirFormPanelContenerdor(new FormAgregar());
                                

        }


        private void Button_Modificar_Click(object sender, EventArgs e)
        {

            AbrirFormPanelContenerdor(new FromModificar());


        }

        private void Form_Inicio_Load(object sender, EventArgs e)
        {

        }

        
        //vincular o abrir formulario consulta
        private void Button_Consulta_Click(object sender, EventArgs e)
        {
            
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

        //boton cerrar programa
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //boton maximizar programa
        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnRestaurar.Visible = true;
            BtnMaximizar.Visible = false;
            
        }
        //boton restaurar programa
        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
            
        }
        //boton minimizar programa
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //llamar funcion mover la ventana programa
        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            RealeseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }
    }
}
