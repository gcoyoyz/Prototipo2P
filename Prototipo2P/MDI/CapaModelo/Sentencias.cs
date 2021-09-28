using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
   public class Sentencias
    {
        Conexion cn = new Conexion();
        OdbcCommand Comm;
        private DataTable tabla;
        //funcion para realizar consultas al a DB

        public OdbcDataAdapter llenarTblalumnos(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "call consultalumnos();";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarTblcursos(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "call consultacursos();";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public bool ingresoalumnos(string carnet_alumno, string nombre_alumno, string direccion_alumno, string telefono_alumno, string email_alumno, string estatus_alumno) //Ingreso Clientes
        {
            int i = 0;
            try
            {
                string cadena = "call ingalumnos('" + carnet_alumno + "','" + nombre_alumno + "','" + direccion_alumno + "','" + telefono_alumno + "','" + email_alumno + "','" + estatus_alumno + "',); ";
                OdbcCommand ingreso = new OdbcCommand(cadena, cn.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);

            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ingresocursos(string codigo_curso, string nombre_curso, string estatus_curso) //Ingreso Clientes
        {
            int i = 0;
            try
            {
                string cadena = "call ingcursos('" + codigo_curso + "','" + nombre_curso + "','" + estatus_curso + "','" + "',); ";
                OdbcCommand ingreso = new OdbcCommand(cadena, cn.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);

            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public OdbcDataReader funcConsulta(string Consulta)
        {
            try
            {
                Comm = new OdbcCommand(Consulta, cn.conexion());
                OdbcDataReader reader = Comm.ExecuteReader();
                return reader;
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error en modelo " + Error);
                return null;
            }

        }
        public DataTable funcObtenerCamposCombobox(string Comando)
        {
            try
            {
                OdbcDataAdapter datos = new OdbcDataAdapter(Comando, cn.conexion());
                tabla = new DataTable();
                datos.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //funcion para insertar en la BD
        public OdbcDataReader funcInsertar(String Consulta)
        {
            try
            {
                Comm = new OdbcCommand(Consulta, cn.conexion());
                OdbcDataReader mostrar = Comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine("Ocurrio un error al registrar modelo" + err);
                return null;
            }
        }
        //funcion para la modificacion en la DB
        public OdbcDataReader funcModificar(string Consulta)
        {
            try
            {
                Comm = new OdbcCommand(Consulta, cn.conexion());
                OdbcDataReader mostrar = Comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error en modelo-modificar ", Error);
                return null;
            }
        }
    }
}
