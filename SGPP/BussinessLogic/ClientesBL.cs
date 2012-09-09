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

            //ValidarControles chare = new ValidarControles();

            //chare.ValidarTelefono(ObjClientesEn.Telefono, "Holaaaa");
     


            DataAccess.ClientesDA ObjClientesDA = new DataAccess.ClientesDA();

            if (ObjClientesDA.SearchClientes(ObjClientesEntidad) == 1)
            {
                MessageBox.Show("1");

            }
            else
            {
                MessageBox.Show("0");

                //ObjClientesDA.InsertClientes(ObjClientesEntidad);
            }

            
           

            
        
        
        }



    }
}
