using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoF
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {

            //WindowState = FormWindowState.Maximized;
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;



        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox4.Visible = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Empleados Emp = new Empleados();
            Emp.Show();
        }

        private void btnVacuna_Click(object sender, EventArgs e)
        {
            Vacunas Vac = new Vacunas();
            Vac.Show();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            Pacientes Pac = new Pacientes();
            Pac.Show();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();
            reg.Show();
        }

        private void btnCampaña_Click(object sender, EventArgs e)
        {
            Campaña cam = new Campaña();
            cam.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
