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
    public partial class Agregar_Horario : Form
    {
        Conexion c = new Conexion();
        public Agregar_Horario()
        {
            InitializeComponent();
        }

        private Sistema_Cine mainForm = null;

        public Agregar_Horario(Form callingForm)
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
            MessageBox.Show(c.insertarHorario(Convert.ToInt32(idhorario_Tbx.Text), fechahorario_Tbx.Text, horahorario_Tbx.Text));
         
            c.cargarHorario(this.mainForm.Horarios_Dgv);
            idhorario_Tbx.Text = "";
            fechahorario_Tbx.Text = "";
            horahorario_Tbx.Text = "";
        }

        private void Modificar_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.modificarHorario(Convert.ToInt32(idhorario_Tbx.Text), fechahorario_Tbx.Text, horahorario_Tbx.Text));

            c.cargarHorario(this.mainForm.Horarios_Dgv);
            idhorario_Tbx.Text = "";
            fechahorario_Tbx.Text = "";
            horahorario_Tbx.Text = "";
        }
    }
}
