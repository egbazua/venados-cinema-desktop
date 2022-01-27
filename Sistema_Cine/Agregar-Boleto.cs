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
    public partial class Agregar_Boleto : Form
    {
        Conexion c = new Conexion();
        public Agregar_Boleto()
        {
            InitializeComponent();
        }

        private Sistema_Cine mainForm = null;
        public Agregar_Boleto(Form callingForm)
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
            MessageBox.Show(c.insertarBoleto(Convert.ToInt32(idboleto_Tbx.Text), Convert.ToInt32(idcuenta_Tbx.Text), Convert.ToInt32(idfuncion_Tbx.Text), Convert.ToInt64(importe_Tbx.Text)));
            //}
            //else
            //{
            // MessageBox.Show(c.modificarPelicula(Convert.ToInt32(idpelicula_Tbx.Text), nombrepeli_Tbx.Text, generopeli_Tbx.Text, duracionpeli_Tbx.Text, clasificacionpeli_Tbx.Text, idiomapeli_Tbx.Text));
            //}

            c.cargarBoleto(this.mainForm.Boletos_Dgv);
            idboleto_Tbx.Text = "";
            idcuenta_Tbx.Text = "";
            idfuncion_Tbx.Text = "";
            importe_Tbx.Text = "";
        }

        private void Modificar_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.modificarBoleto(Convert.ToInt32(idboleto_Tbx.Text), Convert.ToInt32(idcuenta_Tbx.Text), Convert.ToInt32(idfuncion_Tbx.Text), Convert.ToInt64(importe_Tbx.Text)));

            c.cargarBoleto(this.mainForm.Boletos_Dgv);
            idboleto_Tbx.Text = "";
            idcuenta_Tbx.Text = "";
            idfuncion_Tbx.Text = "";
            importe_Tbx.Text = "";
        }
    }
}
