using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using BussinessLogic;
using BussinessLogic;




namespace aPresentation
{
    public partial class FrmClientes : FrmPlantla
    {

        ValidarControles VC = new ValidarControles();
        //AdministrarControles AC = new AdministrarControles();


        public FrmClientes()
  InitializeComponent();
            btnNuevo.Click += new EventHandler(btnNuevo_Click);
            btnGuardar.Click += new EventHandler(btnGuardartHandler(btnNuevo_Click);

            
            btnGuardar.Click += new EventHandler(b           
        }

        void btnGuardar_Click(object sender, EventArgs e)
        {

            Entidades.Clientes ObjClientesEn = new Entidades.Clientes();


            ObjClientesEn.CodCliente = txtCliente.Text;
            ObjClientesEn.Nombre = txtNombre.Text;
            ObjClientesEn.Apellido = txtApellido.Text;
            ObjClientesEn.Cedula = txtCedula.Text;
            ObjClientesEn.Genero = CmbGenero.Text;
            ObjClientesEn.Telefono = txtTelefono.Text;
            ObjClientesEn.Celular = txtCelular.Text;
            ObjClientesEn.Fax = txtFax.Text;
            ObjClientesEn.FechaNaci = DtpFechaNaci.Value;
            ObjClientesEn.CalleoAv = txtCalle.Text;
            ObjClientesEn.NoVivienda = NudNoVivienda.Value;
            ObjClientesEn.Sector = txtSector.Text;
            ObjClientesEn.Ciudad = txtCiudadEmpresa.Text;
            ObjClientesEn.Email = txtEmail.Text;
            ObjClientesEn.Nodependiente = NudNoDependientes.Value;
            ObjClientesEn.Empresa = txtNombreEmpresa.Text;
            ObjClientesEn.CalleoAvEmpresa = txtCalleEmpresa.Text;
            ObjClientesEn.NoEmpresa = NudNoEmpresa.Value;
            ObjClientesEn.RNC = TxtRnc.Text;
            ObjClientesEn.CiudadEmp = txtCiudadEmpresa.Text;
           
        }



    }
}













