using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Entidades;



namespace DataAccess
{
  public  class ClientesDA
    {

        Entidades.Clientes ObjClientes = new Entidades.Clientes();
      
        public  void InsertClientes (string CodCliente, string Nombre, string Apellido,string Cedula, 
                                    string Genero,string Telefono,string Celular, string Fax,
                                    DateTime FechaNacimiento, string CalleoAv,string NoVivienda,
                                    string Sector,string Ciudad, string Email, string NoDependiente,
                                    string Empresa, string CalleoAvEmpresa, string NoEmpresa,
                                    string RNC, string CiudadEmp, string TelefonoEmp, string FaxEmp,
                                    string Puesto, decimal Ingresos, DateTime FechaIngreso, string NoCuenta,
                                    string NombreGar, string ApellidoGar, string CedulaGar, string TelefonoGar,
                                    string CelularGar, string EmailGar, string Direccion, string DescripcionGarantia,
                                    string EmpresaGar, string CalleoAvEmpresaGar, string NoEmpresaGar, string RNCGar,
                                    string CiudadEmpGar, string TelefonoEmpGar, string FaxEmpGar, string PuestoGar,
                                    decimal IngresosGar, DateTime FechaIngresoGar,string NoCuentaGar )
        {
           
            SqlCommand ObjCmd = new SqlCommand("Sp_InsertClientes", Connection.Get);
            ObjCmd.CommandType = CommandType.StoredProcedure;

            Connection.Get.Open();
   
            ObjCmd.Parameters.Add(new SqlParameter ("@CodCliente",CodCliente).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Nombre",Nombre).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Apellido", Apellido).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Cedula", Cedula).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Genero", Genero).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Telefono", Telefono).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Celular", Celular).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Fax", Fax).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@FechaNacimiento", FechaNacimiento).DbType = DbType.DateTime);
            ObjCmd.Parameters.Add(new SqlParameter("@CalleoAv", CalleoAv).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@NoVivienda", NoVivienda).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Sector", Sector).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Ciudad", Ciudad).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Email", Email).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Nodependiente", NoDependiente).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Empresa",Empresa).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@CalleoAvEmpresa", CalleoAvEmpresa).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Noempresa", NoEmpresa).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@RNC", RNC).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@CiudadEmp", CiudadEmp).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@TelefonoEmp", TelefonoEmp).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@FaxEmp", FaxEmp).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Puesto", Puesto).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Ingresos", Ingresos).DbType = DbType.Decimal);
            ObjCmd.Parameters.Add(new SqlParameter("@FechaIngreso", FechaIngreso).DbType = DbType.DateTime);
            ObjCmd.Parameters.Add(new SqlParameter("@NoCuenta", NoCuenta).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@NombreGar", NombreGar).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@ApellidoGar", ApellidoGar).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@CedulaGar", CedulaGar).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@TelefonoGar", TelefonoGar).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@CelularGar", CelularGar).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@EmailGar", EmailGar).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Direccion", Direccion).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Descripciongarantia", DescripcionGarantia).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@EmpresaGar", EmpresaGar).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@CalleoAvEmpresaGar", CalleoAvEmpresaGar).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@NoEmpresaGar", NoEmpresaGar).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@RNCgar", RNCGar).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@CiudadEmpGar", CiudadEmpGar).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@TelefonoEmpGar", TelefonoEmpGar).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@FaxEmpGar", FaxEmpGar).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@PuestoGar",PuestoGar).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@IngresosGar", IngresosGar).DbType = DbType.Decimal);
            ObjCmd.Parameters.Add(new SqlParameter("@FechaIngresoGar", FechaIngresoGar).DbType = DbType.DateTime);
            ObjCmd.Parameters.Add(new SqlParameter("@NoCuentaGar", NoCuentaGar).DbType = DbType.String);

            ObjCmd.ExecuteNonQuery();
            Connection.Get.Close();

        
        }

        public void UpdateClientes()
        {


        }


        public void DeleteClientes()
        {


        }

        public void SearchClientes()
        {


        }


        static void Main()
        {

        }

    }
}
