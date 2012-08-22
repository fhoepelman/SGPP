using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;



namespace DataAccess
{
    class ClientesDA
    {


        public void InsertClientes(string CodCliente, string Nombre)
        {

            SqlCommand ObjCmd = new SqlCommand("Sp_InsertClientes", connection.Get);
            ObjCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter PrmCodCliente = new SqlParameter("@CodCliente", CodCliente);
            PrmCodCliente.DbType = DbType.String;
            SqlParameter PrmNombre = new SqlParameter("@Nombre", Nombre);
            PrmNombre.DbType = DbType.String;


            
            
        


        
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
