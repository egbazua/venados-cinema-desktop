using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Cine
{
    public partial class Agregar_Sala : Form
    {
        Conexion c = new Conexion();
        public Agregar_Sala()
        {
            InitializeComponent();
        }
        private Sistema_Cine mainForm = null;
        public Agregar_Sala(Form callingForm)
        {
            mainForm = callingForm as Sistema_Cine;
            InitializeComponent();
        }
        private void Regresar_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Guardar_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.insertarSala(Convert.ToInt32(idsala_Tbx.Text), capacidadsala_Tbx.Text));
         
            c.cargarSala(this.mainForm.Salas_Dgv);
            idsala_Tbx.Text = "";
            capacidadsala_Tbx.Text = "";
        }

        private void Modificar_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.modificarSala(Convert.ToInt32(idsala_Tbx.Text), capacidadsala_Tbx.Text));

            c.cargarSala(this.mainForm.Salas_Dgv);
            idsala_Tbx.Text = "";
            capacidadsala_Tbx.Text = "";
        }
    }
}
