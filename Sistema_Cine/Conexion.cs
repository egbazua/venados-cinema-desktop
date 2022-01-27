using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_Cine
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter da;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=CINE_ITH;Integrated Security=True");
                cn.Open();
                //MessageBox.Show("Conexión correcta.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conectó con la base de datos: " + ex.ToString());
            }
        }

        //Funciones para el módulo de película.

        // Función para insertar película.
        public string insertar_pelicula(int xid_pelicula, String xnombre_pelicula, String xgenero, String xduracion, String xclasificacion, String xidioma)
        {

            string salida = "Proceso terminado.";
            try
            {
                cmd = new SqlCommand("[INSERTA_PELICULA]", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@xid_pelicula", SqlDbType.Int).Value = xid_pelicula;
                cmd.Parameters.Add("@xnombre_pelicula", SqlDbType.VarChar).Value = xnombre_pelicula;
                cmd.Parameters.Add("@xgenero", SqlDbType.VarChar).Value = xgenero;
                cmd.Parameters.Add("@xduracion", SqlDbType.VarChar).Value = xduracion;
                cmd.Parameters.Add("@xclasificacion", SqlDbType.VarChar).Value = xclasificacion;
                cmd.Parameters.Add("@mensaje", SqlDbType.VarChar).Value = "";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conectó: " + ex.ToString();
            }

            return salida;
        }

        // Función para cargar película.
        public void cargarPelicula(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from PELICULA", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        //Función para consultar película.
        public void consultarPelicula(DataGridView dgv, string xbuscar)
        {
            if (xbuscar == "")
            {
                string query = "Select * from PELICULA";
                SqlCommand comando = new SqlCommand(query, cn);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgv.DataSource = tabla;
            }
            else
            {
                string query = "Select * from PELICULA where nombre_pelicula = '" + xbuscar + "'";
                SqlCommand comando = new SqlCommand(query, cn);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgv.DataSource = tabla;
            }
        }

        //Función para consultar avanzadamente película.
        public void avanzadaPelicula(DataGridView dgv)
        {
            string query = "SELECT PELICULA.nombre_pelicula, PELICULA.genero, FUNCION.tipo_funcion FROM PELICULA INNER JOIN FUNCION ON PELICULA.id_pelicula = FUNCION.id_funcion";
            SqlCommand comando = new SqlCommand(query, cn);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dgv.DataSource = tabla;
        }

        //Función para vista de película.
        public void vistaPelicula(DataGridView dgv)
        {
            string query = "Select * from Vista_Pelicula";
            SqlCommand comando = new SqlCommand(query, cn);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dgv.DataSource = tabla;
        }

        // Función para eliminar película.
        public void eliminarPelicula(String xtext)
        {

            int flag = 0;
            string cadena = "Delete from PELICULA where nombre_pelicula = '" + xtext + "'";
            SqlCommand comando = new SqlCommand(cadena, cn);
            flag = comando.ExecuteNonQuery();

            if (flag == 1)
            {
                MessageBox.Show("Se realizó el eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al intentar eliminar.");
            }

        }

        //Función para modificar película.
        public string modificarPelicula(int xid_pelicula, String xnombre_pelicula, String xgenero, String xduracion, String xclasificacion, String xidioma)
        {
            string salida = "Modificación completada.";
            int flag = 0;
            SqlCommand cmd = new SqlCommand("UPDATE PELICULA SET nombre_pelicula='" + xnombre_pelicula + "', genero='" + xgenero + "'," +
                "duracion='" + xduracion + "'," + "clasificacion='" + xclasificacion + "'," + "idioma='" + xidioma + "' WHERE id_pelicula=" + Convert.ToInt32(xid_pelicula+""), cn);
            flag = cmd.ExecuteNonQuery();
            if (flag == 1)
            {
                //MessageBox.Show("Modificación completada.");
            }
            else
            {
                MessageBox.Show("Error al intentar modificar.");
            }
            return salida;
        }


        //Funciones para el módulo de horario.

        //Función para insertar horario.
        public string insertarHorario(int xid_horario, String xfecha, String xhora)
        {

            string salida = "Proceso terminado.";
            try
            {
                cmd = new SqlCommand("[INSERTA_HORARIO]", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@xid_horario", SqlDbType.Int).Value = xid_horario;
                cmd.Parameters.Add("@xfecha", SqlDbType.DateTime).Value = xfecha;
                cmd.Parameters.Add("@xhora", SqlDbType.VarChar).Value = xhora;
                cmd.Parameters.Add("@mensaje", SqlDbType.VarChar).Value = "";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conectó: " + ex.ToString();
            }

            return salida;
        }

        //Función para cargar horario.
        public void cargarHorario(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from HORARIO", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        //Función para consultar horario.
        public void consultarHorario(DataGridView dgv, string xbuscar)
        {
            if (xbuscar == "")
            {
                string query = "Select * from HORARIO";
                SqlCommand comando = new SqlCommand(query, cn);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgv.DataSource = tabla;
            }
            else
            {
                string query = "Select * from HORARIO where hora = '" + xbuscar + "'";
                SqlCommand comando = new SqlCommand(query, cn);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgv.DataSource = tabla;
            }
        }

        //Función para consultar avanzadamente horario.
        public void avanzadaHorario(DataGridView dgv)
        {
            string query = "SELECT HORARIO.fecha, FUNCION.tipo_funcion FROM HORARIO INNER JOIN FUNCION ON HORARIO.id_horario = FUNCION.id_funcion";
            SqlCommand comando = new SqlCommand(query, cn);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dgv.DataSource = tabla;
        }

        //Función para eliminar horario.
        public void eliminarHorario(String xtext)
        {
            int flag = 0;
            string cadena = "Delete from HORARIO where hora = '" + xtext + "'";
            SqlCommand comando = new SqlCommand(cadena, cn);
            flag = comando.ExecuteNonQuery();

            if (flag == 1)
            {
                MessageBox.Show("Se realizó el eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al intentar eliminar");
            }
        }

        //Función para modificar horario.
        public string modificarHorario(int xid_horario, String xfecha, String xhora)
        {
            string salida = "Modificación completada.";
            int flag = 0;
            SqlCommand cmd = new SqlCommand("UPDATE HORARIO SET fecha='" + xfecha + "', hora='" + xhora + "' WHERE id_horario=" + Convert.ToInt32(xid_horario + ""), cn);
            //SqlCommand cmd = new SqlCommand("UPDATE PELICULA SET nombre_pelicula='" + xnombre_pelicula + "', genero='" + xgenero + "'," +
              //  "duracion='" + xduracion + "'," + "clasificacion='" + xclasificacion + "'," + "idioma='" + xidioma + "' WHERE id_pelicula=" + Convert.ToInt32(xid_pelicula + ""), cn);
            flag = cmd.ExecuteNonQuery();
            if (flag == 1)
            {
                //MessageBox.Show("Modificación completada.");
            }
            else
            {
                MessageBox.Show("Error al intentar modificar.");
            }
            return salida;
        }

        //Funciones para el módulo de sala.

        //Función para insetar sala.
        public string insertarSala(int xid_sala, String xcapacidad)
        {

            string salida = "Proceso terminado.";
            try
            {
                cmd = new SqlCommand("[INSERTA_SALA]", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@xid_sala", SqlDbType.Int).Value = xid_sala;
                cmd.Parameters.Add("@xcapacidad", SqlDbType.VarChar).Value = xcapacidad;
                cmd.Parameters.Add("@mensaje", SqlDbType.VarChar).Value = "";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conectó: " + ex.ToString();
            }

            return salida;
        }

        //Función para cargar sala.
        public void cargarSala(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from SALA", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        //Función para consultar sala.
        public void consultarSala(DataGridView dgv, string xbuscar)
        {
            if (xbuscar == "")
            {
                string query = "Select * from SALA";
                SqlCommand comando = new SqlCommand(query, cn);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgv.DataSource = tabla;
            }
            else
            {
                string query = "Select * from SALA where capacidad = '" + xbuscar + "'";
                SqlCommand comando = new SqlCommand(query, cn);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgv.DataSource = tabla;
            }
        }

        //Función para consultar avanzadamente sala.
        public void avanzadaSala(DataGridView dgv)
        {
            string query = "SELECT HORARIO.fecha, FUNCION.tipo_funcion FROM HORARIO INNER JOIN FUNCION ON HORARIO.id_horario = FUNCION.id_funcion";
            SqlCommand comando = new SqlCommand(query, cn);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dgv.DataSource = tabla;
        }

        //Función para eliminar sala.
        public void eliminarSala(String xtext)
        {
            int flag = 0;
            string cadena = "Delete from SALA where capacidad = '" + xtext + "'";
            SqlCommand comando = new SqlCommand(cadena, cn);
            flag = comando.ExecuteNonQuery();

            if (flag == 1)
            {
                MessageBox.Show("Se realizó el eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al intentar eliminar");
            }
        }

        //Función para modificar sala.
        public string modificarSala(int xid_sala, String xcapacidad)
        {
            string salida = "Modificación completada.";
            int flag = 0;
            SqlCommand cmd = new SqlCommand("UPDATE SALA SET capacidad='" + xcapacidad + "' WHERE id_sala=" + Convert.ToInt32(xid_sala + ""), cn);
            flag = cmd.ExecuteNonQuery();
            if (flag == 1)
            {
                //MessageBox.Show("Modificación completada.");
            }
            else
            {
                MessageBox.Show("Error al intentar modificar.");
            }
            return salida;
        }


        //Funciones para el módulo de CUENTA.

        //Función para insertar cuenta.
        public string insertarCuenta(int xid_cuenta, String xnombre, String xtelefono, String xcorreo_electronico, String xfecha_nacimiento, String xmetodo_pago)
        {

            string salida = "Proceso terminado.";
            try
            {
                cmd = new SqlCommand("[INSERTA_CUENTA]", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@xid_cuenta", SqlDbType.Int).Value = xid_cuenta;
                cmd.Parameters.Add("@xnombre", SqlDbType.VarChar).Value = xnombre;
                cmd.Parameters.Add("@xtelefono", SqlDbType.VarChar).Value = xtelefono;
                cmd.Parameters.Add("@xcorreo_electronico", SqlDbType.VarChar).Value = xcorreo_electronico;
                cmd.Parameters.Add("@xfecha_nacimiento", SqlDbType.DateTime).Value = xfecha_nacimiento;
                cmd.Parameters.Add("@xmetodo_pago", SqlDbType.VarChar).Value = xmetodo_pago;
                cmd.Parameters.Add("@mensaje", SqlDbType.VarChar).Value = "";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conectó: " + ex.ToString();
            }

            return salida;
        }

        //Función para cargar cuenta.
        public void cargarCuenta(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from CUENTA", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        //Función para consultar CUENTA.
        public void consultarCuenta(DataGridView dgv, string xbuscar)
        {
            if (xbuscar == "")
            {
                string query = "Select * from CUENTA";
                SqlCommand comando = new SqlCommand(query, cn);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgv.DataSource = tabla;
            }
            else
            {
                string query = "Select * from CUENTA where nombre = '" + xbuscar + "'";
                SqlCommand comando = new SqlCommand(query, cn);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgv.DataSource = tabla;
            }
        }

        //Función para consultar avanzadamente CUENTA.
        public void avanzadaCuenta(DataGridView dgv)
        {
            string query = "SELECT CUENTA.nombre, CUENTA.telefono, BOLETO.id_boleto FROM CUENTA INNER JOIN BOLETO ON CUENTA.id_cuenta = BOLETO.id_boleto";
            SqlCommand comando = new SqlCommand(query, cn);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dgv.DataSource = tabla;
        }

        //Función para vista de cuenta.
        public void vistaCuenta(DataGridView dgv)
        {
            string query = "Select * from Vista_Cuenta";
            SqlCommand comando = new SqlCommand(query, cn);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dgv.DataSource = tabla;
        }

        //Función para eliminar cuenta.
        public void eliminarCuenta(String xtext)
        {
            int flag = 0;
            string cadena = "Delete from CUENTA where telefono = '" + xtext + "'";
            SqlCommand comando = new SqlCommand(cadena, cn);
            flag = comando.ExecuteNonQuery();

            if (flag == 1)
            {
                MessageBox.Show("Se realizó el eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al intentar eliminar");
            }
        }

        //Función para modificar cuenta.
        public string modificarCuenta(int xid_cuenta, String xnombre, String xtelefono, String xcorreo_electronico, String xfecha_nacimiento, String xmetodo_pago)
        {
            string salida = "Modificación completada.";
            int flag = 0;
            SqlCommand cmd = new SqlCommand("UPDATE CUENTA SET nombre='" + xnombre + "', telefono='" + xtelefono + "'," +
                "correo_electronico='" + xcorreo_electronico + "'," + "fecha_nacimiento='" + xfecha_nacimiento + "'," + "metodo_pago='" + xmetodo_pago + "' WHERE id_cuenta=" + Convert.ToInt32(xid_cuenta + ""), cn);
           // SqlCommand cmd = new SqlCommand("UPDATE HORARIO SET fecha='" + xfecha + "', hora='" + xhora + "' WHERE id_horario=" + Convert.ToInt32(xid_horario + ""), cn);
            flag = cmd.ExecuteNonQuery();
            if (flag == 1)
            {
                //MessageBox.Show("Modificación completada.");
            }
            else
            {
                MessageBox.Show("Error al intentar modificar.");
            }
            return salida;
        }

        //Funciones para el módulo de BOLETO.

        //Función para insertar boleto.
        public string insertarBoleto(int xid_boleto, int xid_cuenta, int xid_funcion, float ximporte_total)
        {

            string salida = "Proceso terminado.";
            try
            {
                cmd = new SqlCommand("[INSERTA_BOLETO]", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@xid_boleto", SqlDbType.Int).Value = xid_boleto;
                cmd.Parameters.Add("@xid_cuenta", SqlDbType.Int).Value = xid_cuenta;
                cmd.Parameters.Add("@xid_funcion", SqlDbType.Int).Value = xid_funcion;
                cmd.Parameters.Add("@ximporte_total", SqlDbType.Float).Value = ximporte_total;
                cmd.Parameters.Add("@mensaje", SqlDbType.VarChar).Value = "";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conectó: " + ex.ToString();
            }

            return salida;
        }

        //Función para cargar boleto.
        public void cargarBoleto(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from BOLETO", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        //Función para consultar película.
        public void consultarBoleto(DataGridView dgv, string xbuscar)
        {
            if (xbuscar == "")
            {
                string query = "Select * from BOLETO";
                SqlCommand comando = new SqlCommand(query, cn);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgv.DataSource = tabla;
            }
            else
            {
                string query = "Select * from BOLETO where importe_total = '" + xbuscar + "'";
                SqlCommand comando = new SqlCommand(query, cn);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgv.DataSource = tabla;
            }
        }

        //Función para vista de película.
        public void vistaBoleto(DataGridView dgv)
        {
            string query = "Select * from Vista_Boleto";
            SqlCommand comando = new SqlCommand(query, cn);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dgv.DataSource = tabla;
        }

        //Función para eliminar boleto.
        public void eliminarBoleto(String xtext)
        {
            int flag = 0;
            string cadena = "Delete from BOLETO where importe_total = '" + xtext + "'";
            SqlCommand comando = new SqlCommand(cadena, cn);
            flag = comando.ExecuteNonQuery();

            if (flag == 1)
            {
                MessageBox.Show("Se realizó el eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al intentar eliminar");
            }
        }

        //Función para modificar boleto.
        public string modificarBoleto(int xid_boleto, int xid_cuenta, int xid_funcion, float ximporte_total)
        {
            string salida = "Modificación completada.";
            int flag = 0;
            SqlCommand cmd = new SqlCommand("UPDATE BOLETO SET id_cuenta='" + xid_cuenta + "', id_funcion='" + xid_funcion + "'," +
                "importe_total='" + ximporte_total + "' WHERE id_boleto=" + Convert.ToInt32(xid_boleto + ""), cn);
            flag = cmd.ExecuteNonQuery();
            if (flag == 1)
            {
                //MessageBox.Show("Modificación completada.");
            }
            else
            {
                MessageBox.Show("Error al intentar modificar.");
            }
            return salida;
        }

        //Funciones para el módulo de FUNCION.

        //Función para insertar funcion.
        public string insertarFuncion(int xid_funcion, string xtipo_funcion, int xid_pelicula, int xid_sala, int xid_horario)
        {

            string salida = "Proceso terminado.";
            try
            {
                cmd = new SqlCommand("[INSERTA_FUNCION]", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@xid_funcion", SqlDbType.Int).Value = xid_funcion;
                cmd.Parameters.Add("@xtipo_funcion", SqlDbType.VarChar).Value = xtipo_funcion;
                cmd.Parameters.Add("@xid_pelicula", SqlDbType.Int).Value = xid_pelicula;
                cmd.Parameters.Add("@xid_sala", SqlDbType.Int).Value = xid_sala;
                cmd.Parameters.Add("@xid_horario", SqlDbType.Int).Value = xid_horario;
                cmd.Parameters.Add("@mensaje", SqlDbType.VarChar).Value = "";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conectó: " + ex.ToString();
            }

            return salida;
        }

        //Función para cargar función.
        public void cargarFuncion(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from FUNCION", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        //Función para consultar función.
        public void consultarFuncion(DataGridView dgv, string xbuscar)
        {
            if (xbuscar == "")
            {
                string query = "Select * from FUNCION";
                SqlCommand comando = new SqlCommand(query, cn);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgv.DataSource = tabla;
            }
            else
            {
                string query = "Select * from FUNCION where tipo_funcion = '" + xbuscar + "'";
                SqlCommand comando = new SqlCommand(query, cn);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgv.DataSource = tabla;
            }
        }

        //Función para vista de función.
        public void vistaFuncion(DataGridView dgv)
        {
            string query = "Select * from Vista_Funcion";
            SqlCommand comando = new SqlCommand(query, cn);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dgv.DataSource = tabla;
        }

        //Función para eliminar función.
        public void eliminarFuncion(String xtext)
        {
            int flag = 0;
            string cadena = "Delete from FUNCION where tipo_funcion = '" + xtext + "'";
            SqlCommand comando = new SqlCommand(cadena, cn);
            flag = comando.ExecuteNonQuery();

            if (flag == 1)
            {
                MessageBox.Show("Se realizó el eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al intentar eliminar");
            }
        }

        //Función para modificar función.
        public string modificarFuncion(int xid_funcion, string xtipo_funcion, int xid_pelicula, int xid_sala, int xid_horario)
        {
            string salida = "Modificación completada.";
            int flag = 0;
            SqlCommand cmd = new SqlCommand("UPDATE FUNCION SET tipo_funcion='" + xtipo_funcion + "', id_pelicula='" + xid_pelicula + "'," +
                "id_sala='" + xid_sala + "', id_horario='" + xid_horario + "' WHERE id_funcion=" + Convert.ToInt32(xid_funcion + ""), cn);
            flag = cmd.ExecuteNonQuery();
            if (flag == 1)
            {
                //MessageBox.Show("Modificación completada.");
            }
            else
            {
                MessageBox.Show("Error al intentar modificar.");
            }
            return salida;
        }

        //Funciones para BITACORA.

        // Función para cargar bitacora.
        public void cargarBitacora(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from BITACORA", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        //Funcion para consultar bitacora.
        public void consultarBitacora(DataGridView dgv, string xbuscar)
        {
            if (xbuscar == "")
            {
                string query = "Select * from BITACORA";
                SqlCommand comando = new SqlCommand(query, cn);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgv.DataSource = tabla;
            }
            else
            {
                string query = "Select * from BITACORA where tabla = '" + xbuscar + "'";
                SqlCommand comando = new SqlCommand(query, cn);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgv.DataSource = tabla;
            }
        }

    } // Fin de clase.
}