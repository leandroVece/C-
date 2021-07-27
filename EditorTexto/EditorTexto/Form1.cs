using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EditorTexto
{
    public partial class Form1 : Form
    {
        Archivo Miarchivo = new Archivo();
        string textoSeleccionado;
        float tamañoSeleccionadoTexto = 0;
        bool tachado = false;
        string[] fontStrings = { "Bold", "Italic", "Underline", "Strikeout" }; 

        public Form1()
        {
            InitializeComponent();
        }

        private void NuevoArchivo()
        {
    
                richTextBox1.Clear();
                richTextBox1.Focus();

        }



        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoArchivo();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void cantidadDeVocesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarManual();
        }

        private void SalvarArchivo()
        {
            if (MessageBox.Show("¿Desea guardar el archivo?", "Recodatorio", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    GuardarManual();
                    MessageBox.Show("archivo guardado correctamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("respetaremos su decicion por mas pendeja que sea");
            }
        }

        private void GuardarManual()
        {
            SaveFileDialog salvar = new SaveFileDialog();

            if (salvar.ShowDialog() == DialogResult.OK)
            {
                //logiaca para guardar archivo en formato txt, pdf o word
                Miarchivo.Salvar();
            }
        }



        private void Negrita()
        {
            string textoSeleccionado;
            float tamañoSeleccionadoTexto = 0;
            bool n = false,i = false, s=false,t = false;
            
            textoSeleccionado = richTextBox1.Font.Name;
            tamañoSeleccionadoTexto = richTextBox1.Font.Size;

            richTextBox1.SelectionFont = new Font(textoSeleccionado, tamañoSeleccionadoTexto, FontStyle.Regular);
            if (n = richTextBox1.Font.Bold)
            {
                if (i == true && s == true && t == true)
                {

                }
                else if(i == true && s == true && t == true)
                {

                }
                richTextBox1.SelectionFont = new Font(textoSeleccionado, tamañoSeleccionadoTexto, FontStyle.Regular);
            }
            else
            {   

            }
            //PROBAR ESTE
            //richTextBox1.SelectionFont = new Font(textoSeleccionado,tamañoSeleccionadoTexto, (FontStyle)Enum.Parse(typeof(FontStyle), fontStrings[0], true));

        }


        private void cursiva()
        {
            string textoSeleccionado;
            float tamañoSeleccionadoTexto = 0;
            bool italica = false;

            textoSeleccionado = richTextBox1.Font.Name;
            tamañoSeleccionadoTexto = richTextBox1.Font.Size;
            if (italica = richTextBox1.Font.Italic)
            {
                richTextBox1.SelectionFont = new Font(textoSeleccionado, tamañoSeleccionadoTexto, FontStyle.Regular);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(textoSeleccionado, tamañoSeleccionadoTexto, FontStyle.Italic);

            }

        }

        private void Subrrayado()
        {
            string textoSeleccionado;
            float tamañoSeleccionadoTexto = 0;
            bool sub = false;

            textoSeleccionado = richTextBox1.Font.Name;
            tamañoSeleccionadoTexto = richTextBox1.Font.Size;
            if (sub = richTextBox1.Font.Italic)
            {
                richTextBox1.SelectionFont = new Font(textoSeleccionado, tamañoSeleccionadoTexto, FontStyle.Regular);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(textoSeleccionado, tamañoSeleccionadoTexto, FontStyle.Underline);

            }

        }

        private void Tachado()
        {
            string textoSeleccionado;
            float tamañoSeleccionadoTexto = 0;
            bool tachado = false;

            textoSeleccionado = richTextBox1.Font.Name;
            tamañoSeleccionadoTexto = richTextBox1.Font.Size;

            if (tachado = richTextBox1.Font.Italic)
            {
                richTextBox1.SelectionFont = new Font(textoSeleccionado, tamañoSeleccionadoTexto, FontStyle.Regular);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(textoSeleccionado, tamañoSeleccionadoTexto, FontStyle.Strikeout);

            } 

        }

        private void negritaToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        
    }
}
