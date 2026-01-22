using PracticaFinalAdoNetV2.Models;
using PracticaFinalAdoNetV2.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFinalAdoNetV2
{
    public partial class FormPracticaFinalV2 : Form
    {
        RepositoryPracticaFinal repo;
        public FormPracticaFinalV2()
        {
            InitializeComponent();
            this.repo = new RepositoryPracticaFinal();
            this.LoadDepartamentos();
        }

        private async Task LoadDepartamentos()
        {
            List<string> departametnos = await this.repo.GetDepartamentosAsync();
            this.cmbDepartamentos.Items.Clear();
            foreach (string item in departametnos)
            {
                this.cmbDepartamentos.Items.Add(item);
            }
        }

        private async Task LoadEmpleados(int dept_num)
        {
            List<string> empleado = await this.repo.GetEmpleadosApellidosAsync(dept_num);
            this.lstEmpleados.Items.Clear();
            foreach (string emp in empleado)
            {
                this.lstEmpleados.Items.Add(emp);
            }
        }
        private async void btnCrearDepartamento_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtDeptNum.Text.ToString());
            string nombre = this.txtDeptNom.ToString();
            string localidad = this.txtDeptLoc.ToString();
            await this.repo.CreateDepartamentoAsync(num, nombre, localidad);
        }

        private async void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string apellido = this.lstEmpleados.SelectedItem.ToString();
            Empleado empelado = await this.repo.GetDataEmpleadoAsync(apellido);
            this.txtEmpApellido.Text = empelado.Apellido.ToString();
            this.txtEmpOficio.Text = empelado.Oficio.ToString();
            this.txtEmpSalario.Text = empelado.Salario.ToString();
        }

        private async void btnUpdateEmpleado_Click(object sender, EventArgs e)
        {

            string apellido = this.txtEmpApellido.Text.ToString();
            string oficio = this.txtEmpOficio.Text.ToString();
            int salario = int.Parse(this.txtEmpSalario.Text.ToString());
            
            await this.repo.UpdateEmpleadoAsync(apellido,oficio, salario);
            
        }

        private async void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dept = this.cmbDepartamentos.SelectedItem.ToString();
            Departamento departament = await this.repo.GetDataDepartamentoAsync(dept);
            this.LoadEmpleados(departament.DeptNumero);
            this.txtDeptNom.Text = departament.DeptNombre.ToString();
            this.txtDeptNum.Text = departament.DeptNumero.ToString();
            this.txtDeptLoc.Text = departament.Localidad.ToString();
        }
    }
}
