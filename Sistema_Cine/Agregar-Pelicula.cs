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
    public partial class Agregar_Pelicula : Form
    {
        Conexion c = new Conexion();
        public Agregar_Pelicula()
        {
            InitializeComponent();
        }
        private Sistema_Cine mainForm = null;

        public Agregar_Pelicula(Form callingForm)
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
            MessageBox.Show(c.insertar_pelicula(Convert.ToInt32(idpelicula_Tbx.Text), nombrepeli_Tbx.Text, generopeli_Tbx.Text, duracionpeli_Tbx.Text, clasificacionpeli_Tbx.Text, idiomapeli_Tbx.Text));
               
            c.cargarPelicula(this.mainForm.Peliculas_Dgv);
            idpelicula_Tbx.Text = "";
            nombrepeli_Tbx.Text = "";
            generopeli_Tbx.Text = "";
            duracionpeli_Tbx.Text = "";
            clasificacionpeli_Tbx.Text = "";
            idiomapeli_Tbx.Text = "";
        }

        private void Modificar_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.modificarPelicula(Convert.ToInt32(idpelicula_Tbx.Text), nombrepeli_Tbx.Text, generopeli_Tbx.Text, duracionpeli_Tbx.Text, clasificacionpeli_Tbx.Text, idiomapeli_Tbx.Text));

            c.cargarPelicula(this.mainForm.Peliculas_Dgv);
            idpelicula_Tbx.Text = "";
            nombrepeli_Tbx.Text = "";
            generopeli_Tbx.Text = "";
            duracionpeli_Tbx.Text = "";
            clasificacionpeli_Tbx.Text = "";
            idiomapeli_Tbx.Text = "";
        }
    }
}
