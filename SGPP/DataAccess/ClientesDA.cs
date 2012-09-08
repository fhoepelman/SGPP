using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Entidades;


//Capa de Accesoo a Datos 
namespace DataAccess
{
   
    // Clase Para Manipular Clientes de la Capa de Accesoo
  public  class ClientesDA
    {

       
      
      //Metodo para insertar Clientes 
        public  void InsertClientes (Entidades.Clientes ObjClientesEn)
   
        {
           
            SqlCommand ObjCmd = new SqlCommand("Sp_Insert", Connection.Get);
            ObjCmd.CommandType = CommandType.StoredProcedure;

            Connection.Get.Open();


            ObjCmd.Parameters.Add(new SqlParameter("@CodCliente", ObjClientesEn.CodCliente) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Nombre", ObjClientesEn.Nombre) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Apellido", ObjClientesEn.Apellido) { SqlDbType = SqlDbType.NVarChar});
            ObjCmd.Parameters.Add(new SqlParameter("@Cedula", ObjClientesEn.Cedula) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Genero", ObjClientesEn.Genero) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Telefono", ObjClientesEn.Telefono) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Celular", ObjClientesEn.Celular) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Fax", ObjClientesEn.Fax) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@FechaNacimiento", ObjClientesEn.FechaNaci) { SqlDbType = SqlDbType.DateTime });
            ObjCmd.Parameters.Add(new SqlParameter("@CalleoAv", ObjClientesEn.CalleoAv) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@NoVivienda", ObjClientesEn.NoVivienda) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Sector", ObjClientesEn.Sector) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Ciudad", ObjClientesEn.Ciudad) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Email", ObjClientesEn.Email) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Nodependiente", ObjClientesEn.Nodependiente) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Empresa", ObjClientesEn.Empresa) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@CalleoAvEmpresa", ObjClientesEn.CalleoAvEmpresa) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Noempresa", ObjClientesEn.NoEmpresa) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@RNC", ObjClientesEn.RNC) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@CiudadEmp", ObjClientesEn.CiudadEmp) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@TelefonoEmp", ObjClientesEn.TelefonoEmp) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@FaxEmp", ObjClientesEn.FaxEmp) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Puesto", ObjClientesEn.Puesto) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Ingresos", ObjClientesEn.Ingresos) { SqlDbType = SqlDbType.Decimal });
            ObjCmd.Parameters.Add(new SqlParameter("@FechaIngreso", ObjClientesEn.FechaIngreso) { SqlDbType = SqlDbType.DateTime });
            ObjCmd.Parameters.Add(new SqlParameter("@NoCuenta", ObjClientesEn.NoCuenta) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@NombreGar", ObjClientesEn.NombreGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@ApellidoGar", ObjClientesEn.ApellidoGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@CedulaGar", ObjClientesEn.CedulaGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@TelefonoGar", ObjClientesEn.TelefonoGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@CelularGar", ObjClientesEn.CelularGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@EmailGar", ObjClientesEn.EmailGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Direccion", ObjClientesEn.DireccionGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Descripciongarantia", ObjClientesEn.DescripcionGarantia) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@EmpresaGar", ObjClientesEn.EmpresaGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@CalleoAvEmpresaGar", ObjClientesEn.CalleoAvEmpresaGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@NoEmpresaGar", ObjClientesEn.NoEmpresaGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@RNCgar", ObjClientesEn.RNCGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@CiudadEmpGar", ObjClientesEn.CiudadEmpGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@TelefonoEmpGar", ObjClientesEn.TelefonoEmpGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@FaxEmpGar", ObjClientesEn.FaxEmpGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@PuestoGar", ObjClientesEn.PuestoGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@IngresosGar", ObjClientesEn.IngresosGar) { SqlDbType = SqlDbType.Decimal });
            ObjCmd.Parameters.Add(new SqlParameter("@FechaIngresoGar", ObjClientesEn.FechaIngresoGar) { SqlDbType = SqlDbType.DateTime });
            ObjCmd.Parameters.Add(new SqlParameter("@NoCuentaGar", ObjClientesEn.NoCuentaGar) { SqlDbType = SqlDbType.NVarChar });

            ObjCmd.ExecuteNonQuery();
            Connection.Get.Close();

        
        }

        public void UpdateClientes()
        {


        }


        public void DeleteClientes()
        {


        }

        public bool SearchClientes(Entidades.Clientes ObjClientesEn)
        {

            SqlCommand ObjCmd = new SqlCommand("Sp_InsertClientes", Connection.Get);
            ObjCmd.CommandType = CommandType.StoredProcedure;

            Connection.Get.Open();

            ObjCmd.Parameters.Add(new SqlParameter("@CodCliente", ObjClientesEn.CodCliente) { SqlDbType = SqlDbType.NVarChar });


            return true;


        }

   

   

    }
}
