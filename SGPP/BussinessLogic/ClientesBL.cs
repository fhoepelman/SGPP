using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Capa de Logica De Negocio
namespace BussinessLogic
{
   public class ClientesBL
    {


        //Metodo para Recibir los datos de la capa de Presentacion y enviarlos a DataAccess
        public void Clientes (string CodCliente, string Nombre, string Apellido, string Cedula,
                                   string Genero, string Telefono, string Celular, string Fax,
                                   DateTime FechaNacimiento, string CalleoAv, string NoVivienda,
                                   string Sector, string Ciudad, string Email, string NoDependiente,
                                   string Empresa, string CalleoAvEmpresa, string NoEmpresa,
                                   string RNC, string CiudadEmp, string TelefonoEmp, string FaxEmp,
                                   string Puesto, decimal Ingresos, DateTime FechaIngreso, string NoCuenta,
                                   string NombreGar, string ApellidoGar, string CedulaGar, string TelefonoGar,
                                   string CelularGar, string EmailGar, string Direccion, string DescripcionGarantia,
                                   string EmpresaGar, string CalleoAvEmpresaGar, string NoEmpresaGar, string RNCGar,
                                   string CiudadEmpGar, string TelefonoEmpGar, string FaxEmpGar, string PuestoGar,
                                   decimal IngresosGar, DateTime FechaIngresoGar, string NoCuentaGar)
        {


            //Aqui van las Validaciones de Lugar


            if (String.IsNullOrEmpty(CodCliente))
            {


            }
            else
            {
                DataAccess.ClientesDA ObjClientesDA = new DataAccess.ClientesDA();
                ObjClientesDA.InsertClientes(CodCliente, Nombre, Apellido, Cedula,
                                        Genero, Telefono, Celular, Fax,
                                        FechaNacimiento, CalleoAv, NoVivienda,
                                        Sector, Ciudad, Email, NoDependiente,
                                        Empresa, CalleoAvEmpresa, NoEmpresa,
                                        RNC, CiudadEmp, TelefonoEmp, FaxEmp,
                                        Puesto, Ingresos, FechaIngreso, NoCuenta,
                                        NombreGar, ApellidoGar, CedulaGar, TelefonoGar,
                                        CelularGar, EmailGar, Direccion, DescripcionGarantia,
                                        EmpresaGar, CalleoAvEmpresaGar, NoEmpresaGar, RNCGar,
                                        CiudadEmpGar, TelefonoEmpGar, FaxEmpGar, PuestoGar,
                                        IngresosGar, FechaIngresoGar, NoCuentaGar);
            }
        
        
        
        }



        static void Main()
        {

        }

    }
}
