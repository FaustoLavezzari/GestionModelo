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
    public partial class asistencia : Form
    {
        private double total;
        HashSet<string> presentes;
        private Dictionary<string, Delegacion> paises;
        public asistencia(Dictionary<string, Delegacion> lista_pais)
        {
            
            InitializeComponent();
            paises = lista_pais;
            vista.Items.Add("Todos");
            vista.Items.Add("Presentes");
            vista.Items.Add("Ausentes");
            vista.DropDownStyle = ComboBoxStyle.DropDownList; //de esta forma no deja editar o escribir el combox
            presentes = new HashSet<string>();
            total = paises.Count ;
        }

       
        
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            foreach (string item in checkedListBox1.Items)//limpio
            {
                   presentes.Remove(item);
                   paises[item].setAsistencia(false);
            }
            foreach (string item in checkedListBox1.CheckedItems)//marco asistencia
            {
               presentes.Add(item);
               paises[item].setAsistencia(true);             
                        
            }
               asist_prom.Text =((((presentes.Count+0.0)/total)*100).ToString()+"   ").Substring(0,3) + "%";
   
        }

        private void asistencia_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            foreach (var item in paises.Values.ToList()) // cargo lista de paises en el diccionario
            {
               checkedListBox1.Items.Add(item.getNombre(),item.getAsistencia());
            }
        }


      

        private void select_Click(object sender, EventArgs e)//seleccionar todos
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
            checkedListBox1_SelectedIndexChanged(sender, e);

        }


        private void clean_Click(object sender, EventArgs e)//deseleccionar todos
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            checkedListBox1_SelectedIndexChanged(sender, e);
        }

        private void vista_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (vista.Text == "Todos") { asistencia_Load(sender, e); }

            else
            {
                bool cnd;
                if (vista.Text == "Presentes") { cnd = true; }
                else { cnd = false; }

                checkedListBox1.Items.Clear();
                foreach (var item in paises.Values.ToList()) // cargo lista de paises en el diccionario
                {
                    if (item.getAsistencia() == cnd)

                    {
                        checkedListBox1.Items.Add(item.getNombre(), item.getAsistencia());
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//hay que revisar para excepciones
            if (checkedListBox1.FindString(buscador.Text) != ListBox.NoMatches)
            {
                checkedListBox1.SetSelected(checkedListBox1.FindString(buscador.Text), true);
            }
            else 
            {
                MessageBox.Show("No se encontro el país \"" + buscador.Text + "\" en la lista.");
            }
        }





    }

}

            /*Para posible ediciones estos metodos podrian servir:
             * Console.WriteLine(checkedListBox1.FindString(string_a_buscar));
             *   object a = checkedListBox1.SelectedItem; objeto seleccionado se castea con string y tira el pais 
             *  checkedListBox1.FindString(buscador.Text);//si no esta hay que lanzar excepcion 
                
             * */