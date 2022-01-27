using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Sistema_Cine
{
    public partial class Sistema_Cine : Form
    {
        Conexion c = new Conexion();
        int condicion;
        SqlConnection cn;
        public Sistema_Cine()
        {
            InitializeComponent();

            condicion = 0;
            Login Login_Form = new Login();

            Login_Form.ShowDialog();
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Information_Btn_Click(object sender, EventArgs e)
        {
            About About_Form = new About();
            About_Form.Show();
        }

        private void Datatime_Tmr_Tick(object sender, EventArgs e)
        {
            // Hora y fecha.
            Hora_Lbl.Text = DateTime.Now.ToString("hh:mm:ss");
            Fecha_Lbl.Text = DateTime.Now.ToLongDateString();
        }

        private void Peliculas_Btn_Click(object sender, EventArgs e)
        {
            // Hacemos visibles todas las funciones del módulo.
            Peliculas_Dgv.Visible = true;
            Salas_Dgv.Visible = false;
            Horarios_Dgv.Visible = false;
            Funciones_Dgv.Visible = false;
            Boletos_Dgv.Visible = false;
            Cuentas_Dgv.Visible = false;
            Bitacoras_Dgv.Visible = false;
            Buscar_Lbl.Visible = true;
            Buscar_Tbx.Visible = true;
            Nuevo_Pbx.Visible = true;
            Nuevo_Btn.Visible = true;
            Eliminar_Pbx.Visible = true;
            Eliminar_Btn.Visible = true;
            consulta_Btn.Visible = true;
            consulta_Pbx.Visible = true;
            vista_Btn.Visible = true;
            vista_Pbx.Visible = true;
            Welcome_Lbl.Visible = false;
            Phrase_Lbl.Visible = false;
            vista_Btn.Enabled = true;
            Nuevo_Btn.Enabled = true;
            Eliminar_Btn.Enabled = true;
            consultaavanzada_Btn.Visible = true;
            consultaavanzada_Pbx.Visible = true;
            consultaavanzada_Btn.Enabled = true;

            condicion = 1;
        }

        private void Salas_Btn_Click(object sender, EventArgs e)
        {
            // Hacemos visibles todas las funciones del módulo.
            Salas_Dgv.Visible = true;
            Peliculas_Dgv.Visible = false;
            Horarios_Dgv.Visible = false;
            Funciones_Dgv.Visible = false;
            Boletos_Dgv.Visible = false;
            Cuentas_Dgv.Visible = false;
            Bitacoras_Dgv.Visible = false;
            Buscar_Lbl.Visible = true;
            Buscar_Tbx.Visible = true;
            Nuevo_Pbx.Visible = true;
            Nuevo_Btn.Visible = true;
            Eliminar_Pbx.Visible = true;
            Eliminar_Btn.Visible = true;
            consulta_Btn.Visible = true;
            consulta_Pbx.Visible = true;
            vista_Btn.Visible = true;
            vista_Pbx.Visible = true;
            Welcome_Lbl.Visible = false;
            Phrase_Lbl.Visible = false;
            Nuevo_Btn.Enabled = true;
            Eliminar_Btn.Enabled = true;
            consultaavanzada_Btn.Visible = true;
            consultaavanzada_Pbx.Visible = true;
            consultaavanzada_Btn.Enabled = true;

            vista_Btn.Enabled = false;

            condicion = 2;

        }

        private void Horarios_Btn_Click(object sender, EventArgs e)
        {
            // Hacemos visibles todas las funciones del módulo.
            Horarios_Dgv.Visible = true;
            Peliculas_Dgv.Visible = false;
            Salas_Dgv.Visible = false;
            Funciones_Dgv.Visible = false;
            Boletos_Dgv.Visible = false;
            Cuentas_Dgv.Visible = false;
            Bitacoras_Dgv.Visible = false;
            Buscar_Lbl.Visible = true;
            Buscar_Tbx.Visible = true;
            Nuevo_Pbx.Visible = true;
            Nuevo_Btn.Visible = true;
            Eliminar_Pbx.Visible = true;
            Eliminar_Btn.Visible = true;
            consulta_Btn.Visible = true;
            consulta_Pbx.Visible = true;
            vista_Btn.Visible = true;
            vista_Pbx.Visible = true;
            Welcome_Lbl.Visible = false;
            Phrase_Lbl.Visible = false;
            vista_Btn.Enabled = false;
            Nuevo_Btn.Enabled = true;
            Eliminar_Btn.Enabled = true;
            consultaavanzada_Btn.Visible = true;
            consultaavanzada_Pbx.Visible = true;
            consultaavanzada_Btn.Enabled = true;

            condicion = 3;

        }

        private void Funciones_Btn_Click(object sender, EventArgs e)
        {
            // Hacemos visibles todas las funciones del módulo.
            Funciones_Dgv.Visible = true;
            Peliculas_Dgv.Visible = false;
            Salas_Dgv.Visible = false;
            Horarios_Dgv.Visible = false;
            Boletos_Dgv.Visible = false;
            Cuentas_Dgv.Visible = false;
            Bitacoras_Dgv.Visible = false;
            Buscar_Lbl.Visible = true;
            Buscar_Tbx.Visible = true;
            Nuevo_Pbx.Visible = true;
            Nuevo_Btn.Visible = true;
            Eliminar_Pbx.Visible = true;
            Eliminar_Btn.Visible = true;
            consulta_Btn.Visible = true;
            consulta_Pbx.Visible = true;
            vista_Btn.Visible = true;
            vista_Pbx.Visible = true;
            Welcome_Lbl.Visible = false;
            Phrase_Lbl.Visible = false;
            vista_Btn.Enabled = true;
            Nuevo_Btn.Enabled = true;
            Eliminar_Btn.Enabled = true;
            consultaavanzada_Btn.Visible = true;
            consultaavanzada_Pbx.Visible = true;
            consultaavanzada_Btn.Enabled = false;

            condicion = 4;

        }

        private void Boletos_Btn_Click(object sender, EventArgs e)
        {
            // Hacemos visibles todas las funciones del módulo.
            Boletos_Dgv.Visible = true;
            Peliculas_Dgv.Visible = false;
            Salas_Dgv.Visible = false;
            Horarios_Dgv.Visible = false;
            Funciones_Dgv.Visible = false;
            Cuentas_Dgv.Visible = false;
            Bitacoras_Dgv.Visible = false;
            Buscar_Lbl.Visible = true;
            Buscar_Tbx.Visible = true;
            Nuevo_Pbx.Visible = true;
            Nuevo_Btn.Visible = true;
            Eliminar_Pbx.Visible = true;
            Eliminar_Btn.Visible = true;
            consulta_Btn.Visible = true;
            consulta_Pbx.Visible = true;
            vista_Btn.Visible = true;
            vista_Pbx.Visible = true;
            Welcome_Lbl.Visible = false;
            Phrase_Lbl.Visible = false;
            vista_Btn.Enabled = true;
            Nuevo_Btn.Enabled = true;
            Eliminar_Btn.Enabled = true;
            consultaavanzada_Btn.Visible = true;
            consultaavanzada_Pbx.Visible = true;
            consultaavanzada_Btn.Enabled = false;

            condicion = 5;

        }

        private void Cuentas_Btn_Click(object sender, EventArgs e)
        {
            // Hacemos visibles todas las funciones del módulo.
            Cuentas_Dgv.Visible = true;
            Peliculas_Dgv.Visible = false;
            Salas_Dgv.Visible = false;
            Horarios_Dgv.Visible = false;
            Funciones_Dgv.Visible = false;
            Boletos_Dgv.Visible = false;
            Bitacoras_Dgv.Visible = false;
            Buscar_Lbl.Visible = true;
            Buscar_Tbx.Visible = true;
            Nuevo_Pbx.Visible = true;
            Nuevo_Btn.Visible = true;
            Eliminar_Pbx.Visible = true;
            Eliminar_Btn.Visible = true;
            consulta_Btn.Visible = true;
            consulta_Pbx.Visible = true;
            vista_Btn.Visible = true;
            vista_Pbx.Visible = true;
            Welcome_Lbl.Visible = false;
            Phrase_Lbl.Visible = false;
            vista_Btn.Enabled = true;
            Nuevo_Btn.Enabled = true;
            Eliminar_Btn.Enabled = true;
            consultaavanzada_Btn.Visible = true;
            consultaavanzada_Pbx.Visible = true;
            consultaavanzada_Btn.Enabled = true;

            condicion = 6;

        }

        private void Nuevo_Btn_Click(object sender, EventArgs e)
        {
            if(condicion == 1)
            {
                Agregar_Pelicula Agregar_Pelicula_Form = new Agregar_Pelicula(this);

                Agregar_Pelicula_Form.ShowDialog();

            }
            else
            {
                if(condicion == 2)
                {
                    Agregar_Sala Agregar_Sala_Form = new Agregar_Sala(this);

                    Agregar_Sala_Form.ShowDialog();
                }
                else
                {
                    if(condicion == 3)
                    {
                        Agregar_Horario Agregar_Horario_Form = new Agregar_Horario(this);

                        Agregar_Horario_Form.ShowDialog();
                    }
                    else
                    {
                        if(condicion == 4)
                        {
                            Agregar_Funcion Agregar_Funcion_Form = new Agregar_Funcion(this);

                            Agregar_Funcion_Form.ShowDialog();
                        }
                        else
                        {
                            if(condicion == 5)
                            {
                                Agregar_Boleto Agregar_Boleto_Form = new Agregar_Boleto(this);

                                Agregar_Boleto_Form.ShowDialog();
                            }
                            else
                            {
                                if(condicion == 6)
                                {
                                    Agregar_Cuenta Agregar_Cuenta_Form = new Agregar_Cuenta(this);

                                    Agregar_Cuenta_Form.ShowDialog();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Sistema_Cine_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            c.cargarPelicula(Peliculas_Dgv);
            c.cargarHorario(Horarios_Dgv);
            c.cargarSala(Salas_Dgv);
            c.cargarCuenta(Cuentas_Dgv);
            c.cargarBoleto(Boletos_Dgv);
            c.cargarFuncion(Funciones_Dgv);
            c.cargarBitacora(Bitacoras_Dgv);
        }

        private void Eliminar_Btn_Click(object sender, EventArgs e)
        {
            
            if (condicion == 1)
            {
                c.eliminarPelicula(Buscar_Tbx.Text);
                c.cargarPelicula(Peliculas_Dgv);
            }
            else
            {
                if (condicion == 2)
                {
                    c.eliminarSala(Buscar_Tbx.Text);
                    c.cargarSala(Salas_Dgv);
                }
                else
                {
                    if (condicion == 3)
                    {
                        c.eliminarHorario(Buscar_Tbx.Text);
                        c.cargarHorario(Horarios_Dgv);
                    }
                    else
                    {
                        if (condicion == 4)
                        {
                            c.eliminarFuncion(Buscar_Tbx.Text);
                            c.cargarFuncion(Funciones_Dgv);
                        }
                        else
                        {
                            if (condicion == 5)
                            {
                                c.eliminarBoleto(Buscar_Tbx.Text);
                                c.cargarBoleto(Boletos_Dgv);
                            }
                            else
                            {
                                if (condicion == 6)
                                {
                                    c.eliminarCuenta(Buscar_Tbx.Text);
                                    c.cargarCuenta(Cuentas_Dgv);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Consulta_Btn_Click(object sender, EventArgs e)
        {
            if (condicion == 1)
            {
                c.consultarPelicula(Peliculas_Dgv, Buscar_Tbx.Text);
            }
            else
            {
                if (condicion == 2)
                {
                    c.consultarSala(Salas_Dgv, Buscar_Tbx.Text);
                }
                else
                {
                    if (condicion == 3)
                    {
                        c.consultarHorario(Horarios_Dgv, Buscar_Tbx.Text);
                    }
                    else
                    {
                        if (condicion == 4)
                        {
                            c.consultarFuncion(Funciones_Dgv, Buscar_Tbx.Text);
                        }
                        else
                        {
                            if (condicion == 5)
                            {
                                c.consultarBoleto(Boletos_Dgv, Buscar_Tbx.Text);
                            }
                            else
                            {
                                if (condicion == 6)
                                {
                                    c.consultarCuenta(Cuentas_Dgv, Buscar_Tbx.Text);
                                }
                                else
                                {
                                    if(condicion == 7)
                                    {
                                        c.consultarBitacora(Cuentas_Dgv, Buscar_Tbx.Text);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Vista_Btn_Click(object sender, EventArgs e)
        {
            if (condicion == 1)
            {
                c.vistaPelicula(Peliculas_Dgv);
            }
            else
            {
                if (condicion == 2)
                {
                   //vista_Btn.Enabled = false;
                }
                else
                {
                    if (condicion == 3)
                    {
                        //vista_Btn.Enabled = false;
                    }
                    else
                    {
                        if (condicion == 4)
                        {
                            c.vistaFuncion(Funciones_Dgv);
                        }
                        else
                        {
                            if (condicion == 5)
                            {
                                c.vistaBoleto(Boletos_Dgv);
                            }
                            else
                            {
                                if (condicion == 6)
                                {
                                    c.vistaCuenta(Cuentas_Dgv);
                                }
                                else
                                {
                                    if(condicion == 7)
                                    {
                                        //vista_Btn.Enabled = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Bitacora_Btn_Click(object sender, EventArgs e)
        {
            Bitacoras_Dgv.Visible = true;
            Horarios_Dgv.Visible = false;
            Peliculas_Dgv.Visible = false;
            Salas_Dgv.Visible = false;
            Funciones_Dgv.Visible = false;
            Boletos_Dgv.Visible = false;
            Cuentas_Dgv.Visible = false;
            Buscar_Lbl.Visible = true;
            Buscar_Tbx.Visible = true;
            Nuevo_Pbx.Visible = true;
            Nuevo_Btn.Visible = true;
            Eliminar_Pbx.Visible = true;
            Eliminar_Btn.Visible = true;
            consulta_Btn.Visible = true;
            consulta_Pbx.Visible = true;
            vista_Btn.Visible = true;
            vista_Pbx.Visible = true;
            Welcome_Lbl.Visible = false;
            Phrase_Lbl.Visible = false;
            vista_Btn.Enabled = false;
            Nuevo_Btn.Enabled = false;
            Eliminar_Btn.Enabled = false;
            consultaavanzada_Pbx.Enabled = false;
            consultaavanzada_Pbx.Enabled = false;
            consultaavanzada_Pbx.Visible = true;
            consultaavanzada_Btn.Visible = true;
            consultaavanzada_Btn.Enabled = false;

            condicion = 7;
        }

        private void Consultaavanzada_Btn_Click(object sender, EventArgs e)
        {
            if (condicion == 1)
            {
                c.avanzadaPelicula(Peliculas_Dgv);
            }
            else
            {
                if (condicion == 2)
                {
                    c.avanzadaSala(Salas_Dgv);
                }
                else
                {
                    if (condicion == 3)
                    {
                        c.avanzadaHorario(Horarios_Dgv);
                    }
                    else
                    {
                        if (condicion == 4)
                        {
                           // c.vistaFuncion(Funciones_Dgv);
                        }
                        else
                        {
                            if (condicion == 5)
                            {
                               // c.vistaBoleto(Boletos_Dgv);
                            }
                            else
                            {
                                if (condicion == 6)
                                {
                                    c.avanzadaCuenta(Cuentas_Dgv);
                                }
                                else
                                {
                                    if (condicion == 7)
                                    {
                                        //vista_Btn.Enabled = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
