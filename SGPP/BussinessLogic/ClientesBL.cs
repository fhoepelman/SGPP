using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Windows.Forms;
//Capa de Logica De Negocio
namespace BussinessLogic
{
   public class ClientesBL
    {


        //Metodo para Recibir los datos de la capa de Presentacion y enviarlos a DataAccess
        public void Clientes (Entidades.Clientes ObjClientesEntidad)
           
        {

            //Aqui van las Validaciones de Lugar     
            DataAccess.ClientesDA ObjClientesDA = new DataAccess.ClientesDA();
        
         

                ObjClientesDA.InsertClientes(ObjClientesEntidad);
                MessageBox.Show("Registro Guardado Correctamente");
        }


        public int SearchClientes(Entidades.Clientes ObjClientesEntidad)
        {
            DataAccess.ClientesDA ObjClientesDA = new DataAccess.ClientesDA();

            return ObjClientesDA.SearchClientes(ObjClientesEntidad);
          
            }
        
      

    }
}
