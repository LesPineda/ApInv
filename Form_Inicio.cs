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
    }
}
