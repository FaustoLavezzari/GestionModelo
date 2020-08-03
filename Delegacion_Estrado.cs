using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiónModelo
{
    public partial class Del_Estrado :Form
    {
        public Del_Estrado()
        {
            InitializeComponent();
        }
        ~Del_Estrado()
        {
            Console.WriteLine("Out..");
        }
        public void CargarDelegacion(Delegacion dele)
        {
            pictureBox1.Image = dele.getBandera();
            delegacion_name.Text = dele.getNombre();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            delegacion_name.Text = null;
            bajar.Visible = false;
           
          
         
         
      
        }
    }
}
