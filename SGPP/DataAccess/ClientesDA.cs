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


        public void InsertClientes (string CodCliente, string Nombre, string Apellido,string Cedula,
                                   string Genero,string Telefono,string Celular, string Fax,
                                    DateTime FechaNacimiento)
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

            ObjCmd.Parameters.Add ( PrmCodCliente);
            ObjCmd.Parameters.Add ( PrmNombre);
            ObjCmd.Parameters.Add ( PrmApellido);
            ObjCmd.Parameters.Add ( PrmCedula);
            ObjCmd.Parameters.Add ( PrmGenero);
            ObjCmd.Parameters.Add ( PrmTefono);
            ObjCmd.Parameters.Add ( PrmCelular);
            ObjCmd.Parameters.Add ( PrmFax);
            ObjCmd.Parameters.Add ( PrmFechaNaci);

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
