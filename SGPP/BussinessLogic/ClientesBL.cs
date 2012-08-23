using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessLogic
{
   public class ClientesBL
    {



        public void Clientes(string CodCliente, string Nombre, string Apellido,string Cedula,
                                   string Genero,string Telefono,string Celular, string Fax,
                                    DateTime FechaNacimiento)
        {

            


            DataAccess.ClientesDA objClientesDA = new DataAccess.ClientesDA();


            objClientesDA.InsertClientes(CodCliente, Nombre, Apellido, Cedula, Genero, Telefono, Celular, Fax, FechaNacimiento);
        
        
        
        
        
        }



        static void Main()
        {

        }

    }
}
