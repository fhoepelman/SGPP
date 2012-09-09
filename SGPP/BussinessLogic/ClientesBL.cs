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

                //Indica que el Cliente ya existe en la BD
                ObjClientesEntidad.Accion = "1";

            }
            else
            {

                ObjClientesDA.InsertClientes(ObjClientesEntidad);
                MessageBox.Show("Registro Guardado Correctamente");
            }
           

                


          

            
           

            
        
        
        }



    }
}
