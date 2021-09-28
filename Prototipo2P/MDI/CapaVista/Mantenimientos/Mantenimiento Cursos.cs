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
    public partial class Mantenimiento_Cursos : Form
    {
        Controlador cn = new Controlador();

        public Mantenimiento_Cursos()
        {
            InitializeComponent();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            DataTable data = cn.llenarTblcursos("");
            dgvcursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvcursos.DataSource = data;
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string codigo_curso = txtcurso.Text;
            string nombre_curso = txtnomcurso.Text;
            string estatus_curso = txtestatuscur.Text;

            if (cn.ingresocursos(codigo_curso, nombre_curso, estatus_curso))
            {
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                MessageBox.Show("Error de ingreso");
            }
            txtcurso.Text = "";
            txtnomcurso.Text = "";
            txtestatuscur.Text = "";
        }
    }
}
