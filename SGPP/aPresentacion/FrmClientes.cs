using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using Entidades;
using BussinessLogic;



namespace aPresentacion
{
    public partial class FrmClientes : FrmPlantilla 
    {

        ValidarControles VC = new ValidarControles();
        //AdministrarControles AC = new AdministrarControles();


        //Estado de la Ventana Cliente
        public  string ESTADO_SISTEMA = "";
     
    

        public FrmClientes()
        {
            InitializeComponent();
            btnNuevo.Click += new EventHandler(btnNuevo_Click);
            btnEditar.Click += new EventHandler(btnEditar_Click);
            btnGuardar.Click += new EventHandler(btnGuardar_Click);

        }


        void btnNuevo_Click(object sender, EventArgs e)
        {
            ESTADO_SISTEMA = "Creando";
        
        }

        void btnEditar_Click(object sender, EventArgs e)
        {
            ESTADO_SISTEMA = "Editando";

        }

        void btnGuardar_Click(object sender, EventArgs e)
        {

            Entidades.Clientes ObjClientesEntidad = new Entidades.Clientes();
            BussinessLogic.ClientesBL ObjClientesLogica = new BussinessLogic.ClientesBL();

            ObjClientesEntidad.CodCliente = txtCliente.Text;
            ObjClientesEntidad.Nombre = txtNombre.Text;
            ObjClientesEntidad.Apellido = txtApellido.Text;
            ObjClientesEntidad.Cedula = txtCedula.Text;
            ObjClientesEntidad.Genero = CmbGenero.Text;
            ObjClientesEntidad.Telefono = txtTelefono.Text;
            ObjClientesEntidad.Celular = txtCelular.Text;
            ObjClientesEntidad.Fax = txtFax.Text;
            ObjClientesEntidad.FechaNaci = DtpFechaNaci.Value;
            ObjClientesEntidad.CalleoAv = txtCalle.Text;
            ObjClientesEntidad.NoVivienda = NudNoVivienda.Value;
            ObjClientesEntidad.Sector = txtSector.Text;
            ObjClientesEntidad.Ciudad = txtCiudad.Text;
            ObjClientesEntidad.Email = txtEmail.Text;
            ObjClientesEntidad.Nodependiente = NudNoDependientes.Value;
            ObjClientesEntidad.Empresa = txtNombreEmpresa.Text;
            ObjClientesEntidad.CalleoAvEmpresa = txtCalleEmpresa.Text;
            ObjClientesEntidad.NoEmpresa = NudNoEmpresa.Value;
            ObjClientesEntidad.RNC = TxtRnc.Text;
            ObjClientesEntidad.CiudadEmp = txtCiudad.Text;
            ObjClientesEntidad.TelefonoEmp = txtTelefonoEmpresa.Text;
            ObjClientesEntidad.FaxEmp = txtFaxEmpresa.Text;
            ObjClientesEntidad.Puesto = txtPuestoCliente.Text;
           //Componente de Ingresos
            ObjClientesEntidad.Ingresos = NudNoDependientes.Value;
            ObjClientesEntidad.FechaIngreso = DtpFechaIngreso.Value;
            ObjClientesEntidad.NoCuenta = txtNoCuenta.Text;
            ObjClientesEntidad.NombreGar = txtNombreGarante.Text;
            ObjClientesEntidad.ApellidoGar = txtApellidoGarante.Text;
            ObjClientesEntidad.CedulaGar = txtCedulaGarante.Text;
            ObjClientesEntidad.TelefonoGar = txtTelefonoGarante.Text;
            ObjClientesEntidad.CelularGar = txtCelular.Text;
            ObjClientesEntidad.EmailGar = txtEmail.Text;
            ObjClientesEntidad.DireccionGar = txtDireccionGarante.Text;
            ObjClientesEntidad.DescripcionGarantia = txtDescripcionGarantia.Text;
            ObjClientesEntidad.EmpresaGar = txtEmpresaGarante.Text;
            ObjClientesEntidad.CalleoAvEmpresaGar = txtCalleEmpresaGarante.Text;
            ObjClientesEntidad.NoEmpresaGar = NudNoEmpresaGar.Value;
            ObjClientesEntidad.RNCGar = txtRNCGar.Text;
            ObjClientesEntidad.CiudadEmpGar = txtCiudadEmpresaGarante.Text;
            ObjClientesEntidad.TelefonoEmpGar = txtTelefonoEmpresaGarante.Text;
            ObjClientesEntidad.FaxEmpGar = txtFaxEmpresa.Text;
            ObjClientesEntidad.PuestoGar = txtPuestoEmpresaGarante.Text;
            //Componente de Ingresos
            ObjClientesEntidad.IngresosGar = NudNoDependientes.Value;
            ObjClientesEntidad.FechaIngresoGar = DtpFechaIngresoGarante.Value;
            ObjClientesEntidad.NoCuentaGar = txtNoCuentaGarante.Text;

            if (ESTADO_SISTEMA == "Creando")
            {

                ObjClientesLogica.InsertClientes(ObjClientesEntidad);
            }
            else
            {
                ObjClientesLogica.UpdateClientes(ObjClientesEntidad);
            
            }

        }



        private void FrmClientes_Load(object sender, EventArgs e)
        {

            //AC.ColorText(this, System.Drawing.Color.LightSteelBlue);
            //AC.DeshabilitarDGV(this);
            //AC.DeshabilitarText(this);
            //AC.DeshabilitarMaskText(this);
            //AC.ColorMaskText(this, System.Drawing.Color.LightSteelBlue);

        }

        private void txtTelefono_Validated(object sender, EventArgs e)
        {

            VC.ValidarTelefono(txtTelefono, "El Campo Telefono Esta Incorrecto");
            
        }

        private void txtCelular_Validated(object sender, EventArgs e)
        {
           
            VC.ValidarTelefono(txtCelular, "El Campo Celular Esta Incorrecto");
        }

        private void txtFax_Validated(object sender, EventArgs e)
        {
            
            VC.ValidarTelefono(txtFax, "El Campo Fax Esta Incorrecto");
            
        }

        private void txtTelefonoEmpresa_Validated(object sender, EventArgs e)
        {
     
            VC.ValidarTelefono(txtTelefonoEmpresa, "El Campo Telefono Esta Incorrecto");
        }

        private void txtFaxEmpresa_Validated(object sender, EventArgs e)
        {
          
            VC.ValidarTelefono(txtFaxEmpresa, "El Campo Telefono Esta Incorrecto");
        }

        private void txtTelefonoGarante_Validated(object sender, EventArgs e)
        {
         
            VC.ValidarTelefono(txtTelefonoGarante, "El Campo Telefono Esta Incorrecto");
        }

        private void txtCelularGarante_Validated(object sender, EventArgs e)
        {
         
            VC.ValidarTelefono(txtCelularGarante, "El Campo Celular Esta Incorrecto");
        }

        private void txtCedula_Validated(object sender, EventArgs e)
        {

            bool Resultado;
            txtCedula.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (txtCedula.Text.Length != 0)
            {

                Resultado = ValidarControles.ValidaCedula(txtCedula);

                if (Resultado == true)
                {
                    ErrProClientes.SetError(txtCedula, null);
                }
                else
                {
                    ErrProClientes.SetError(txtCedula, "La Cedula Es Incorrecta");
                    txtCedula.Focus();
                }
            }
            else
            {
                ErrProClientes.SetError(txtCedula, null);
            }
        }

        private void txtCedulaGarante_Validated(object sender, EventArgs e)
        {
            bool Resultado;
            txtCedulaGarante.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (txtCedulaGarante.Text.Length != 0)
            {
                Resultado = ValidarControles.ValidaCedula(txtCedulaGarante);

                if (Resultado == true)
                {
                    ErrProClientes.SetError(txtCedulaGarante, null);
                }
                else
                {
                    ErrProClientes.SetError(txtCedulaGarante, "La Cedula Es Incorrecta");
                    txtCedulaGarante.Focus();
                }
            }
            else
            {
                ErrProClientes.SetError(txtCedulaGarante, null);
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            VC.ValidarEmail(txtEmail);
        }

        private void txtEmailGarante_Validated(object sender, EventArgs e)
        {
       
            VC.ValidarEmail(txtEmailGarante);
        }

        private void txtCliente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

          //  //Declaramos la variables de BussinessLogic y Entidades de Clientes
          //  BussinessLogic.ClientesBL ObjClienteLogica = new BussinessLogic.ClientesBL();
          //  Entidades.Clientes ObjClienteEntidad = new Entidades.Clientes();


          //  //Asignamos el valor del txtcliente a la entidad del cliente
          //  ObjClienteEntidad.CodCliente = txtCliente.Text;
          

        
          //  //Si es Igual a 1 quiere decir que el cliente existe en la base de datos
          //if (ObjClienteLogica.SearchClientes(ObjClienteEntidad) == 1)
          //{
          //    ErrProClientes.SetError(txtCliente, "El Cliente " + txtCliente.Text + " Ya Existe En Nuestra Base De Datos");
          //    txtCliente.Focus();
          //}
          //else
          //{
          //    ErrProClientes.SetError(txtCliente, null);
          //}
            
        }

    

    }
}













