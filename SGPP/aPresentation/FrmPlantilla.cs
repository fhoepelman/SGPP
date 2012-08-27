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
            ObjClientes.CalleoAv = textBox5.Text;
            ObjClientes.Telefono = textBox6.Text;
            ObjClientes.Celular = textBox7.Text;
            ObjClientes.FechaNaci = dateTimePicker1.Value;

            //Declaramos un Objeto de tipo Inteligencia de Negocios 
            BussinessLogic.ClientesBL ObjClientesBL = new BussinessLogic.ClientesBL();

            ObjClientesBL.Clientes(ObjClientes);

        }
    }
}
