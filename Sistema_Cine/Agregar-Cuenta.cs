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
    public partial class Agregar_Cuenta : Form
    {
        Conexion c = new Conexion();
        public Agregar_Cuenta()
        {
            InitializeComponent();
        }
        private Sistema_Cine mainForm = null;
        public Agregar_Cuenta(Form callingForm)
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
            MessageBox.Show(c.insertarCuenta(Convert.ToInt32(idcuenta_Tbx.Text), nombrecuenta_Tbx.Text, telefonocuenta_Tbx.Text, correocuenta_Tbx.Text, fechanacimiento_Tbx.Text, metodopago_Tbx.Text));
            //}
            //else
            //{
            // MessageBox.Show(c.modificarPelicula(Convert.ToInt32(idpelicula_Tbx.Text), nombrepeli_Tbx.Text, generopeli_Tbx.Text, duracionpeli_Tbx.Text, clasificacionpeli_Tbx.Text, idiomapeli_Tbx.Text));
            //}

            c.cargarCuenta(this.mainForm.Cuentas_Dgv);
            idcuenta_Tbx.Text = "";
            nombrecuenta_Tbx.Text = "";
            telefonocuenta_Tbx.Text = "";
            correocuenta_Tbx.Text = "";
            fechanacimiento_Tbx.Text = "";
            metodopago_Tbx.Text = "";
        }

        private void Modificar_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.modificarCuenta(Convert.ToInt32(idcuenta_Tbx.Text), nombrecuenta_Tbx.Text, telefonocuenta_Tbx.Text, correocuenta_Tbx.Text, fechanacimiento_Tbx.Text, metodopago_Tbx.Text));
      
            c.cargarCuenta(this.mainForm.Cuentas_Dgv);
            idcuenta_Tbx.Text = "";
            nombrecuenta_Tbx.Text = "";
            telefonocuenta_Tbx.Text = "";
            correocuenta_Tbx.Text = "";
            fechanacimiento_Tbx.Text = "";
            metodopago_Tbx.Text = "";
        }
    }
}
