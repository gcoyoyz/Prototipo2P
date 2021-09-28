﻿using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador

{
    public class Controlador
    {
        Sentencias Modelo = new Sentencias();
        //clsVariableGlobal glo = new clsVariableGlobal();
        public DataTable funcObtenerCamposCombobox(string Campo1, string Campo2, string Tabla, string Estado)
        {
            string Comando = string.Format("SELECT " + Campo1 + " ," + Campo2 + " FROM " + Tabla + " WHERE " + Estado + "= 1;");
            return Modelo.funcObtenerCamposCombobox(Comando);
        }
        public OdbcDataReader funcConsultaCombo(string Campo1, string Campo2, string Tabla, string Estado, string Codigo)
        {
            string Comando = string.Format("SELECT " + Campo1 + " FROM " + Tabla + " WHERE " + Estado + "= 1 AND " + Campo2 + " = " + Codigo + ";");
            return Modelo.funcConsulta(Comando);

        }
        public OdbcDataReader funcEliminar_perfil(string Codigo)
        {
            string Consulta = "UPDATE  control_producto SET resultado_control_producto = 'Finalizado', estado_control_producto = 0 where pk_id_control_producto = " + Codigo + ";";
            return Modelo.funcModificar(Consulta);
        }
        public OdbcDataReader funcConsultaDetallesCUI(string Tabla, string CodPedido)
        {
            string Consulta = "SELECT * FROM " + Tabla + " Where pk_id_usuario_pasaporte = " + CodPedido + ";";
            return Modelo.funcConsulta(Consulta);
        }
       
        public OdbcDataReader funcConsultaBanco(string Tabla, string CodPedido)
        {
            string Consulta = "SELECT estado_boleta FROM " + Tabla + " Where pk_numero_boleta = " + CodPedido + ";";
            return Modelo.funcConsulta(Consulta);
        }

        public DataTable llenarTblalumnos(string tabla)
        {
            OdbcDataAdapter dt = Modelo.llenarTblalumnos(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblcursos(string tabla)
        {
            OdbcDataAdapter dt = Modelo.llenarTblcursos(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public bool ingresoalumnos(string carnet_alumno, string nombre_alumno, string direccion_alumno, string telefono_alumno, string email_alumno, string estatus_alumno)
        {
            return Modelo.ingresoalumnos(carnet_alumno, nombre_alumno, direccion_alumno, telefono_alumno, email_alumno, estatus_alumno);
        }


        public bool ingresocursos(string codigo_curso, string nombre_curso, string estatus_curso)
        {
            return Modelo.ingresocursos(codigo_curso, nombre_curso, estatus_curso);
        }
    }
}
