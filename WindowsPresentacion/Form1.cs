using LibEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        Empleado empleado1;
        Empleado empleado2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarComision_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Empleado.Comision.ToString()) ;
        }

        private void btnInsertarEmpleado1_Click(object sender, EventArgs e)
        {
            empleado1 = new Empleado((decimal)150.5, 1, "Matias", "Tito");
            MessageBox.Show(Empleado.Comision.ToString());
        }

        private void btnInsertarEmpleado2_Click(object sender, EventArgs e)
        {
        empleado2 = new Empleado((decimal)20.5, 2, "Juan", "Gomez");
        MessageBox.Show(Empleado.Comision.ToString());
        }
    }
}
