using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aPresentation
{
    public partial class FrmPlantilla : Form
    {
        public FrmPlantilla()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Declaramos un Objeto de Tipo Entidades de Clientes
            Entidades.Clientes ObjClientes = new Entidades.Clientes();

            ObjClientes.CodCliente = textBox1.Text;
            ObjClientes.Nombre = textBox2.Text;
            ObjClientes.Apellido = textBox3.Text;
            ObjClientes.Cedula = textBox4.Text;
            ObjClientes.Genero = textBox5.Text;
            ObjClientes.Telefono = textBox6.Text;
            ObjClientes.Celular = textBox7.Text;
            ObjClientes.Fax = textBox8.Text;
            ObjClientes.FechaNaci = dateTimePicker1.Value;

            ObjClientes.CalleoAv = textBox9.Text;
            ObjClientes.NoVivienda = textBox10.Text;
            ObjClientes.Sector = textBox11.Text;
            ObjClientes.Ciudad = textBox12.Text;
            ObjClientes.Email = textBox13.Text;
            ObjClientes.Nodependiente = textBox14.Text;
            ObjClientes.Empresa = textBox15.Text;
            ObjClientes.CalleoAvEmpresa = textBox16.Text;
            ObjClientes.NoEmpresa = textBox17.Text;
            ObjClientes.RNC = textBox18.Text;

            ObjClientes.CiudadEmp = textBox19.Text;
            ObjClientes.TelefonoEmp = textBox20.Text;
            ObjClientes.FaxEmp = textBox21.Text;
            ObjClientes.Puesto = textBox22.Text;
            ObjClientes.Ingresos = Convert.ToDecimal( textBox23.Text);
            ObjClientes.FechaIngreso = dateTimePicker2.Value;
            ObjClientes.NoCuenta = textBox24.Text;
            ObjClientes.NombreGar = textBox25.Text;
            ObjClientes.ApellidoGar = textBox26.Text;
            ObjClientes.CedulaGar = textBox27.Text;
            ObjClientes.TelefonoGar = textBox28.Text;

            ObjClientes.CelularGar = textBox29.Text;
            ObjClientes.EmailGar = textBox30.Text;
            ObjClientes.DireccionGar = textBox31.Text;
            ObjClientes.DescripcionGarantia = textBox32.Text;
            ObjClientes.EmpresaGar = textBox33.Text;
            ObjClientes.CalleoAvEmpresaGar = textBox34.Text;
            ObjClientes.NoEmpresaGar = textBox35.Text;
            ObjClientes.RNCGar = textBox36.Text;

            ObjClientes.CiudadEmpGar = textBox1.Text;
            ObjClientes.TelefonoEmpGar = textBox1.Text;
            ObjClientes.FaxEmpGar = textBox1.Text;
            ObjClientes.PuestoGar = textBox1.Text;
            ObjClientes.IngresosGar = Convert.ToDecimal(textBox25.Text);

            ObjClientes.FechaIngresoGar = dateTimePicker3.Value;
            ObjClientes.NoCuentaGar = textBox1.Text;


















            //Declaramos un Objeto de tipo Inteligencia de Negocios 
            BussinessLogic.ClientesBL ObjClientesBL = new BussinessLogic.ClientesBL();

            ObjClientesBL.Clientes(ObjClientes);

        }
    }
}
