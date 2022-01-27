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
    public partial class Agregar_Funcion : Form
    {
        Conexion c = new Conexion();
        public Agregar_Funcion()
        {
            InitializeComponent();
        }

        private Sistema_Cine mainForm = null;
        public Agregar_Funcion(Form callingForm)
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
            MessageBox.Show(c.insertarFuncion(Convert.ToInt32(idfuncion_Tbx.Text), tipofuncion_Tbx.Text, Convert.ToInt32(idpelicula_Tbx.Text), Convert.ToInt32(idsala_Tbx.Text), Convert.ToInt32(idhorario_Tbx.Text)));
          
            c.cargarFuncion(this.mainForm.Funciones_Dgv);
            idfuncion_Tbx.Text = "";
            tipofuncion_Tbx.Text = "";
            idpelicula_Tbx.Text = "";
            idsala_Tbx.Text = "";
            idhorario_Tbx.Text = "";
            
        }

        private void Modificar_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.modificarFuncion(Convert.ToInt32(idfuncion_Tbx.Text), tipofuncion_Tbx.Text, Convert.ToInt32(idpelicula_Tbx.Text), Convert.ToInt32(idsala_Tbx.Text), Convert.ToInt32(idhorario_Tbx.Text)));

            c.cargarFuncion(this.mainForm.Funciones_Dgv);
            idfuncion_Tbx.Text = "";
            tipofuncion_Tbx.Text = "";
            idpelicula_Tbx.Text = "";
            idsala_Tbx.Text = "";
            idhorario_Tbx.Text = "";
        }
    }
}
