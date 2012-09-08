using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aPresentacion
{
    public partial class FrmPlantilla : Form
    {
        public FrmPlantilla()
        {
            InitializeComponent();
        }

   
        private void btnSalir_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Desea Salir Realmente Del Sistema", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                Close();
            
            }
        
        }

        private void FrmPlantilla_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            

        }
      

       
       
      

       
    }

     
}
