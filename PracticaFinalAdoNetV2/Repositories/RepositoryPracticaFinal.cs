using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PracticaFinalAdoNetV2.Helpers;
using Microsoft.Extensions.Configuration;
using PracticaFinalAdoNetV2.Models;

#region PROCEDIMIENTOS_ALMACENADOS
//create procedure SP_ALL_DEPARTAMENTOS
//as
//	select * from Dept
//go

//create procedure SP_DATA_DEPARTAMENT
//(@nombre nvarchar(50))
//as
//	declare @numdepartamento int
//	select @numdepartamento = DEPT_NO from DEPT where DNOMBRE= @nombre

//	select * from dept where dept_no=@numdepartamento
//go

//create procedure SP_DATA_EMPLEADOS
//(@nombre nvarchar (50))
//as
//	declare @idemp int
//	select @idemp = emp_no from emp where apellido = @nombre
//	select * from emp where emp_no=@idemp
//go
#endregion

namespace PracticaFinalAdoNetV2.Repositories
{
    public class RepositoryPracticaFinal
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public RepositoryPracticaFinal()
        {
            IConfigurationRoot configuration= HelperConfiguration.GetConfiguration();
            string connectionString = configuration.GetConnectionString("SqlLocal");
            this.cn= new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetDepartamentosAsync()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> departament = new List<string>();
            while(await this.reader.ReadAsync())
            {
                string dept_nom = this.reader["DNOMBRE"].ToString();
                departament.Add(dept_nom);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departament;
        }

        public async Task<Departamento> GetDataDepartamentoAsync(string dept_nombre)
        {
            string sql = "SP_DATA_DEPARTAMENT";
            SqlParameter pamNom = new SqlParameter("@nombre", dept_nombre);
            this.com.Parameters.Add(pamNom);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            Departamento departament = new Departamento();
            while (await this.reader.ReadAsync())
            {
                int dept_num = int.Parse(this.reader["DEPT_NO"].ToString());
                string dept_nom = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();
                departament.DeptNumero = dept_num;
                departament.DeptNombre = dept_nom;
                departament.Localidad = localidad;
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return departament;
        }

        public async Task<List<string>> GetEmpleadosApellidosAsync(int dept_num)
        {
            string sql = "Select * from emp where dept_no=" + dept_num;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            List<string> apellidos = new List<string>();
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                string ape = this.reader["apellido"].ToString();
                apellidos.Add(ape);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return apellidos;
        }

        public async Task CreateDepartamentoAsync(int dept_num, string dept_nombre, string localidad)
        {
            string sql = "insert into dept values (@id, @nombre, @localidad)";
            SqlParameter pamNum = new SqlParameter("@id",dept_num);
            this.com.Parameters.Add(pamNum);
            SqlParameter pamNom = new SqlParameter("@nombre", dept_nombre);
            this.com.Parameters.Add(pamNom);
            SqlParameter pamLoc = new SqlParameter("@localidad", localidad);
            this.com.Parameters.Add(pamLoc);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task<Empleado> GetDataEmpleadoAsync(string apellido)
        {
            string sql = "SP_DATA_EMPLEADOS";
            SqlParameter pamApe = new SqlParameter("@nombre", apellido);
            this.com.Parameters.Add(pamApe);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            Empleado empelado = new Empleado();
            this.reader = await this.com.ExecuteReaderAsync();
            while(await this.reader.ReadAsync())
            {
                string ape = this.reader["apellido"].ToString();
                string oficio = this.reader["oficio"].ToString();
                int salario = int.Parse(this.reader["salario"].ToString());
                int numero = int.Parse(this.reader["dept_no"].ToString());
                empelado.Apellido = apellido;
                empelado.Oficio = oficio;
                empelado.Salario = salario;
                empelado.Dept_num = numero;
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return empelado;
        }

        public async Task UpdateEmpleadoAsync(string apellido, string oficio, int salario)
        {
            string sql = "update Emp set apellido=@apellido, oficio=@oficio, salario=@salario where apellido=@apellido";
            SqlParameter pamApe = new SqlParameter("@apellido", apellido);
            this.com.Parameters.Add(pamApe);
            SqlParameter pamOfi = new SqlParameter("@oficio", oficio);
            this.com.Parameters.Add(pamOfi);
            SqlParameter pamSalario = new SqlParameter("@salario", salario);
            this.com.Parameters.Add(pamSalario);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
