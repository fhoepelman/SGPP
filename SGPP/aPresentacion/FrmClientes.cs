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
    

        public FrmClientes()
        {
            InitializeComponent();
            //btnNuevo.Click += new EventHandler(btnNuevo_Click);
            btnGuardar.Click += new EventHandler(btnGuardar_Click);

        }

        void btnGuardar_Click(object sender, EventArgs e)
        {

            //Cliente x = new Cliente();
            //x.FaxEmp = "asdf";

            MessageBox.Show("sdaf");

            Entidades.Clientes ObjClientesEntidad = new Entidades.Clientes();

           
           
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

    

    }
}













