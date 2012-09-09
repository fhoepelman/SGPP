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
      public void InsertClientes(Entidades.Clientes ObjClientesEntidad)
   
        {
           
            SqlCommand ObjCmd = new SqlCommand("Sp_Insert_Cli", Connection.Get);
            ObjCmd.CommandType = CommandType.StoredProcedure;

            Connection.Get.Open();


            ObjCmd.Parameters.Add(new SqlParameter("@CodCliente", ObjClientesEntidad.CodCliente) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Nombre", ObjClientesEntidad.Nombre) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Apellido", ObjClientesEntidad.Apellido) { SqlDbType = SqlDbType.NVarChar});
            ObjCmd.Parameters.Add(new SqlParameter("@Cedula", ObjClientesEntidad.Cedula) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Genero", ObjClientesEntidad.Genero) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Telefono", ObjClientesEntidad.Telefono) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Celular", ObjClientesEntidad.Celular) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Fax", ObjClientesEntidad.Fax) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@FechaNacimiento", ObjClientesEntidad.FechaNaci) { SqlDbType = SqlDbType.DateTime });
            ObjCmd.Parameters.Add(new SqlParameter("@CalleoAv", ObjClientesEntidad.CalleoAv) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@NoVivienda", ObjClientesEntidad.NoVivienda) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Sector", ObjClientesEntidad.Sector) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Ciudad", ObjClientesEntidad.Ciudad) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Email", ObjClientesEntidad.Email) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Nodependiente", ObjClientesEntidad.Nodependiente) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Empresa", ObjClientesEntidad.Empresa) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@CalleoAvEmpresa", ObjClientesEntidad.CalleoAvEmpresa) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Noempresa", ObjClientesEntidad.NoEmpresa) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@RNC", ObjClientesEntidad.RNC) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@CiudadEmp", ObjClientesEntidad.CiudadEmp) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@TelefonoEmp", ObjClientesEntidad.TelefonoEmp) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@FaxEmp", ObjClientesEntidad.FaxEmp) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Puesto", ObjClientesEntidad.Puesto) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Ingresos", ObjClientesEntidad.Ingresos) { SqlDbType = SqlDbType.Decimal });
            ObjCmd.Parameters.Add(new SqlParameter("@FechaIngreso", ObjClientesEntidad.FechaIngreso) { SqlDbType = SqlDbType.DateTime });
            ObjCmd.Parameters.Add(new SqlParameter("@NoCuenta", ObjClientesEntidad.NoCuenta) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@NombreGar", ObjClientesEntidad.NombreGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@ApellidoGar", ObjClientesEntidad.ApellidoGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@CedulaGar", ObjClientesEntidad.CedulaGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@TelefonoGar", ObjClientesEntidad.TelefonoGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@CelularGar", ObjClientesEntidad.CelularGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@EmailGar", ObjClientesEntidad.EmailGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Direccion", ObjClientesEntidad.DireccionGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@Descripciongarantia", ObjClientesEntidad.DescripcionGarantia) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@EmpresaGar", ObjClientesEntidad.EmpresaGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@CalleoAvEmpresaGar", ObjClientesEntidad.CalleoAvEmpresaGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@NoEmpresaGar", ObjClientesEntidad.NoEmpresaGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@RNCgar", ObjClientesEntidad.RNCGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@CiudadEmpGar", ObjClientesEntidad.CiudadEmpGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@TelefonoEmpGar", ObjClientesEntidad.TelefonoEmpGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@FaxEmpGar", ObjClientesEntidad.FaxEmpGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@PuestoGar", ObjClientesEntidad.PuestoGar) { SqlDbType = SqlDbType.NVarChar });
            ObjCmd.Parameters.Add(new SqlParameter("@IngresosGar", ObjClientesEntidad.IngresosGar) { SqlDbType = SqlDbType.Decimal });
            ObjCmd.Parameters.Add(new SqlParameter("@FechaIngresoGar", ObjClientesEntidad.FechaIngresoGar) { SqlDbType = SqlDbType.DateTime });
            ObjCmd.Parameters.Add(new SqlParameter("@NoCuentaGar", ObjClientesEntidad.NoCuentaGar) { SqlDbType = SqlDbType.NVarChar });

            ObjCmd.ExecuteNonQuery();
            Connection.Get.Close();

        
        }

        public void UpdateClientes()
        {


        }


        public void DeleteClientes()
        {


        }

        public int SearchClientes(Entidades.Clientes ObjClientesEntidad)
        {

            SqlCommand ObjCmd = new SqlCommand("Sp_Search_Cli", Connection.Get);
            ObjCmd.CommandType = CommandType.StoredProcedure;

            Connection.Get.Open();

            ObjCmd.Parameters.Add(new SqlParameter("@CodCliente", ObjClientesEntidad.CodCliente) { SqlDbType = SqlDbType.NVarChar });

            SqlParameter Prm = ObjCmd.Parameters.Add("@Returns", SqlDbType.Bit);
            Prm.Direction = ParameterDirection.Output;
            //Prm.Value = cmbAccount.Text;

            Connection.Get.Close();

            return Convert.ToInt32( (ObjCmd.Parameters["@Returns"].Value));


        }

   

   

    }
}
