using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace DataAccess
{
  public  class ClientesDA
    {

      static void Main()
      { 

      }

        public void InsertClientes (string CodCliente, string Nombre, string Apellido,string Cedula,
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
                                    decimal IngresosGar, DateTime FechaIngresoGar,string NoCuentaGar)
        {
           
            SqlCommand ObjCmd = new SqlCommand("Sp_InsertClientes", Connection.Get);
            ObjCmd.CommandType = CommandType.StoredProcedure;

            Connection.Get.Open();

      
            SqlParameter PrmCodCliente = new SqlParameter("@CodCliente", CodCliente);
            PrmCodCliente.DbType = DbType.String;
            SqlParameter PrmNombre = new SqlParameter("@Nombre", Nombre);
            PrmNombre.DbType = DbType.String;
            SqlParameter PrmApellido = new SqlParameter("@Apellido", Apellido);
            PrmApellido.DbType = DbType.String;
            SqlParameter PrmCedula = new SqlParameter("@Cedula", Cedula);
            PrmCedula.DbType = DbType.String;
            SqlParameter PrmGenero = new SqlParameter("@Genero", Genero);
            PrmGenero.DbType = DbType.String;
            SqlParameter PrmTefono = new SqlParameter("@Telefono", Telefono);
            PrmTefono.DbType = DbType.String;
            SqlParameter PrmCelular = new SqlParameter("@Celular", Celular);
            PrmCelular.DbType = DbType.String;
            SqlParameter PrmFax = new SqlParameter("@Fax", Fax);
            PrmFax.DbType = DbType.String;
            SqlParameter PrmFechaNaci = new SqlParameter("@FechaNacimiento", FechaNacimiento);
            PrmFechaNaci.DbType = DbType.DateTime;

            SqlParameter PrmCalleoAv = new SqlParameter("@CalleoAv", CalleoAv);
            PrmCalleoAv.DbType = DbType.String;

            SqlParameter PrmNoVivienda = new SqlParameter("@NoVivienda", NoVivienda);
            PrmNoVivienda.DbType = DbType.String;

            SqlParameter PrmSector = new SqlParameter("@Sector", Sector);
            PrmSector.DbType = DbType.String;

            SqlParameter PrmCiudad = new SqlParameter("@Ciudad", Ciudad);
            PrmCiudad.DbType = DbType.String;
            SqlParameter PrmEmail = new SqlParameter("@Email", Email);
            PrmEmail.DbType = DbType.String;
            SqlParameter PrmNoDependiente = new SqlParameter("@NoDependiente", NoDependiente);
            PrmNoDependiente.DbType = DbType.String;

            SqlParameter PrmEmpresa = new SqlParameter("@Empresa", Empresa);
            PrmEmpresa.DbType = DbType.String; 
   

            SqlParameter PrmCalleoAvEmpresa = new SqlParameter("@CalleoAvEmpresa",CalleoAvEmpresa);
            SqlParameter PrmNoEmpresa = new SqlParameter("@NoEmpresa", NoEmpresa);
            SqlParameter PrmRNC = new SqlParameter("@RNC", RNC);
            SqlParameter PrmCiudadEmp = new SqlParameter("@CiudadEmp", CiudadEmp);
            SqlParameter PrmTelefonoEmp = new SqlParameter("@TelefonoEmp", TelefonoEmp);
            SqlParameter PrmFaxEmp = new SqlParameter("@FaxEmp",FaxEmp);
            SqlParameter PrmPuesto = new SqlParameter("@Puesto", Puesto);
            SqlParameter PrmIngresos = new SqlParameter("@Ingresos", Ingresos);
            SqlParameter PrmFechaIngresos = new SqlParameter("@FechaIngresos",FechaIngreso);
            SqlParameter PrmNoCuenta = new SqlParameter("@NoCuenta", NoCuenta);
            SqlParameter PrmNombreGar = new SqlParameter("@NombreGar", NombreGar);
            SqlParameter PrmApellidoGar = new SqlParameter("@ApellidoGar", ApellidoGar);
            SqlParameter PrmCedulaGar = new SqlParameter("@CedulaGar", CedulaGar);
            SqlParameter PrmTelefonoGar = new SqlParameter("@TelefonoGar", TelefonoGar);
            SqlParameter PrmCelularGar = new SqlParameter("@CelularGar", CelularGar);
            SqlParameter PrmEmailGar = new SqlParameter("@EmailGar", EmailGar);
            SqlParameter PrmDireccion = new SqlParameter("@Direccion", Direccion);
            SqlParameter PrmDescripcionGarantia = new SqlParameter("@DescripcionGarantia", DescripcionGarantia);
            SqlParameter PrmEmpresaGar = new SqlParameter("@EmpresaGar", EmpresaGar);
            SqlParameter PrmCalleoAvEmpresaGar = new SqlParameter("@CalleoAvEmpresaGar", CalleoAvEmpresaGar);
            SqlParameter PrmRNCGar = new SqlParameter("@RNCGar", RNCGar);
            SqlParameter PrmCiudadEmpGar = new SqlParameter("@CiudadEmpGar", CiudadEmpGar);
            SqlParameter PrmTelefonoEmpGar = new SqlParameter("@TelefonoEmpGar", TelefonoEmpGar);
            SqlParameter PrmFaxEmpGar = new SqlParameter("@FaxEmpGar", FaxEmpGar);
            SqlParameter PrmPuestoGar = new SqlParameter("@PuestoGar", PuestoGar);
            SqlParameter PrmIngresosGar = new SqlParameter("@IngresosGar", IngresosGar);
            SqlParameter PrmFechaIngresoGar = new SqlParameter("@FechaIngresoGar", FechaIngresoGar);
            SqlParameter PrmNoCuentaGar = new SqlParameter("@NoCuentaGar", NoCuentaGar);


            ObjCmd.Parameters.Add(new SqlParameter ("@CodCliente",CodCliente).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Nombre",Nombre).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Apellido", Apellido).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Cedula", Cedula).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Genero", Genero).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Telefono", Telefono).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Celular", Celular).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@Fax", Fax).DbType = DbType.String);
            ObjCmd.Parameters.Add(new SqlParameter("@FechaNacimiento", FechaNacimiento).DbType = DbType.DateTime);
            ObjCmd.Parameters.Add(PrmCalleoAv);
            ObjCmd.Parameters.Add(PrmNoVivienda);
            ObjCmd.Parameters.Add(PrmSector);
            ObjCmd.Parameters.Add(PrmEmail);
            ObjCmd.Parameters.Add(PrmNoDependiente);
            ObjCmd.Parameters.Add(PrmEmpresa);

            ObjCmd.Parameters.Add(new SqlParameter("@CalleoAvEmpresa",CalleoAvEmpresa).DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmNoEmpresa.DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmRNC.DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmCiudadEmp.DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmTelefonoEmp.DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmFaxEmp.DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmPuesto.DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmIngresos.DbType = DbType.Decimal);
            ObjCmd.Parameters.Add(PrmFechaIngresos.DbType = DbType.DateTime);
            ObjCmd.Parameters.Add(PrmNoCuenta.DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmNombreGar.DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmApellidoGar.DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmCedulaGar.DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmTelefonoGar.DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmCelularGar.DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmEmailGar.DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmDireccion.DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmDescripcionGarantia.DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmEmpresaGar.DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmRNCGar.DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmCiudadEmpGar.DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmTelefonoEmpGar.DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmFaxEmpGar.DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmPuestoGar.DbType = DbType.String);
            ObjCmd.Parameters.Add(PrmIngresosGar.DbType = DbType.Decimal);
            ObjCmd.Parameters.Add(PrmFechaIngresoGar.DbType = DbType.DateTime);
            ObjCmd.Parameters.Add(PrmNoCuentaGar.DbType = DbType.String);























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


    }
}
