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
    public partial class Interpelacion : Form
    {
        Sesion ses_aux;
        Delegacion en_estrado;
        public Interpelacion(Delegacion en_estrado, Sesion sesion)
        {
            InitializeComponent();
            this.en_estrado = en_estrado;
            ses_aux = sesion;
            foreach (Delegacion aux in ses_aux.getListaPaises())
            {
                del_interpeladora.Items.Add(aux.getNombre());
            }            
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            Delegacion interpeladora;
            if (ses_aux.getDiccionarioPaises().TryGetValue(del_interpeladora.Text, out interpeladora))
            {
                interpeladora.incrementarInterpelaciones();
                en_estrado.incrementarRespuestas();
            }
            else
            { MessageBox.Show("Por favor ingrese un valor válido"); }
             

            this.Close();
            ((PantallaPrincipal)PantallaPrincipal.ActiveForm).comboBox1_SelectedIndexChanged(sender, e);
            this.Dispose();          

        }
    }
}
