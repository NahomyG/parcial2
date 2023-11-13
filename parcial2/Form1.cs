using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial2
{
    public partial class Form1 : Form
    {
        private List<Profesor> listaProfesores = new List<Profesor>();
        private List<Estudiante> listaEstudiantes = new List<Estudiante>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void GD_Click(object sender, EventArgs e)
        {
            if (Profesor.Checked)
            {
                Profesor nuevoProfesor = new Profesor
                {
                    Nombres = txtNombres.Text,
                    Apellidos = txtApellidos.Text,
                    CarreraAsignada = lblCarrera.Text,
                };

                listaProfesores.Add(nuevoProfesor);
            }
            else if (rdbEstudiante.Checked)
            {
                Estudiante nuevoEstudiante = new Estudiante
                {
                    Nombres = txtNombres.Text,
                    Apellidos = txtApellidos.Text,
                    Ciclo = Convert.ToInt32(txtCiclo.Text),
                    Cum = Convert.ToDouble(txtCum.Text),
                    Carrera = txtCarrera.Text
                };

                listaEstudiantes.Add(nuevoEstudiante);
            }

            
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            lblCarrera.Clear();
            txtCiclo.Clear();
            txtCum.Clear();
            lblCarrera.Text = "";
        }

        private void Mujer_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }

