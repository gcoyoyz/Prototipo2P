using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista.Mantenimientos
{
    public partial class mantenimiento1 : Form
    {
        Controlador cn = new Controlador();
        public mantenimiento1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            DataTable data = cn.llenarTblalumnos("");
            dgvalumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvalumnos.DataSource = data;
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string carnet_alumno = txtcarnet.Text;
            string nombre_alumno = txtnombre.Text;
            string direccion_alumno = txtdireccion.Text;
            string telefono_alumno = txttelefono.Text; 
            string email_alumno = txtemail.Text;
            string estatus_alumno = txtestatus.Text;

            if (cn.ingresoalumnos(carnet_alumno, nombre_alumno, direccion_alumno, telefono_alumno, email_alumno, estatus_alumno))
            {
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                MessageBox.Show("Error de ingreso");
            }
            txtcarnet.Text = "";
            txtnombre.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
            txtemail.Text = "";
            txtestatus.Text = "";
        }
    }
}
