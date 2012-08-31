using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BussinessLogic;




namespace aPresentation
{
    public partial class FrmClientes : FrmPlantilla
    {

        ValidarControles VC = new ValidarControles();
        //AdministrarControles AC = new AdministrarControles();


        public FrmClientes()
        {
            InitializeComponent();
            btnNuevo.Click += new EventHandler(btnNuevo_Click);

            
            btnGuardar.Click += new EventHandler(btnGuardar_Click);
           

        }

        void btnNuevo_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Pruebaaaa");
        }


        void btnGuardar_Click(object sender, EventArgs e)
        {

            Entidades.Clientes ObjClientesEn = new Entidades.Clientes();

            ObjClientesEn.CodCliente = txtCliente.Text;
            ObjClientesEn.
        
        }

        


        private void FrmClientes_Load(object sender, EventArgs e)
        {

            //AC.ColorText(this, System.Drawing.Color.LightSteelBlue);
            //AC.DeshabilitarDGV(this);
            //AC.DeshabilitarText(this);
            //AC.DeshabilitarMaskText(this);
            //AC.ColorMaskText(this, System.Drawing.Color.LightSteelBlue);

          }

  

        private void txtCedula_Validating(object sender, CancelEventArgs e)
        {

            txtCedula.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (txtCedula.Text.Length != 0)
            {

                if (ValidarControles.ValidaCedula(txtCedula))
                {
                    ErrProClientes.SetError(txtCedula, null);
                }
                else
                {
                    ErrProClientes.SetError(txtCedula, "Cedula Incorrecta");
                    txtCedula.Focus();
                }
            }
            else
            {
                ErrProClientes.SetError(txtCedula, null);
            }

        }

        
        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            VC.ValidarTelefono(txtTelefono, "Telefono Incorrecto");
        }

        private void txtCelular_Validating(object sender, CancelEventArgs e)
        {
            VC.ValidarTelefono(txtCelular, "Celular Incorrecto");
        }

        private void txtFax_Validating(object sender, CancelEventArgs e)
        {
            VC.ValidarTelefono(txtFax, "Fax Incorrecto");
        }

        private void txtTelefonoEmpresa_Validating(object sender, CancelEventArgs e)
        {
            VC.ValidarTelefono(txtTelefonoEmpresa, "Telefono Incorrecto");
        }

        private void txtFaxEmpresa_Validating(object sender, CancelEventArgs e)
        {
            VC.ValidarTelefono(txtFaxEmpresa, "Fax Incorrecto");
        }

        private void txtCedulaGarante_Validating(object sender, CancelEventArgs e)
        {

            txtCedulaGarante.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (txtCedulaGarante.Text.Length != 0)
            {

                if (ValidarControles.ValidaCedula(txtCedulaGarante))
                {
                    ErrProClientes.SetError(txtCedulaGarante, null);
                }
                else
                {
                    ErrProClientes.SetError(txtCedulaGarante, "Cedula Incorrecta");
                    txtCedulaGarante.Focus();
                }
            }
            else
            {
                ErrProClientes.SetError(txtCedulaGarante, null);
            }


        }

        private void txtTelefonoGarante_Validating(object sender, CancelEventArgs e)
        {
            VC.ValidarTelefono(txtTelefonoGarante, "Telefono Incorrecto");
        }

        private void txtCelularGarante_Validating(object sender, CancelEventArgs e)
        {
            VC.ValidarTelefono(txtCelularGarante, "Celular Incorrecto");
        }

        private void txtTelefonoEmpresaGarante_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            VC.ValidarTelefono(txtTelefonoEmpresaGarante, "Telefono Incorrecto");
        }

        private void txtFaxEmpresaGarante_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            VC.ValidarTelefono(txtFaxEmpresaGarante, "Telefono Incorrecto");
        }
    }
}













