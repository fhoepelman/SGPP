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

            string CodCliente = textBox1.Text;
            string Nombre = textBox2.Text;
            string Apellido = textBox3.Text;
            string Cedula= textBox4.Text;
            string Genero = textBox5.Text;
            string Telefono = textBox6.Text;
            string Celular = textBox7.Text;
            string Fax = textBox8.Text;
            DateTime FechaNaci = dateTimePicker1.Value;


            BussinessLogic.ClientesBL ObjClientesBL = new BussinessLogic.ClientesBL();

            ObjClientesBL.Clientes(CodCliente, Nombre, Apellido, Cedula, Genero, Telefono, Celular, Fax, FechaNaci);




        }
    }
}
