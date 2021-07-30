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
using EditorTexto.ZetaProducer;

namespace EditorTexto
{
    public partial class Form1 : Form
    {
        CArchivo Miarchivo = new CArchivo();
        List<string> font_style = new List<string>();
        bool n = false, i = false, u = false, s = false; //"Bold, Italic, Underline, Strikeout"
        FontStyle res = FontStyle.Regular;
        const int dist = 24;
        string protagonista;
        int vm = 0;
        int vf = 0; //VF= voz femenina VF = voz maculina

        public string Protagonista { get => protagonista; set => protagonista = value; }
        public int Vm { get => vm; set => vm = value; }
        public int Vf { get => vf; set => vf = value; }

        public Form1()
        {
            InitializeComponent();
            for (int i = 8; i <= 30; i++)
            {
                toolStripComboBox1.Items.Add(i);
            }
            toolStripComboBox1.Text = "10";
            richTextBox1.SetInnerMargins(dist, dist, dist, 0);
            richTextBox1.Focus();

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
            Form2 formConfVoz = new Form2();
            formConfVoz.ShowDialog();
            Protagonista = formConfVoz.Protagonista;
            Vm = formConfVoz.Vm;
            Vf = formConfVoz.Vf;
            CrearBotones();
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
        private void negritaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checked(negritaToolStripMenuItem.Checked);
            n = VerificarFuente(n, "Bold");
        }

        private void kursivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checked(kursivaToolStripMenuItem.Checked);
            i = VerificarFuente(i, "Italic");
        }

        private void tachadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checked(tachadoToolStripMenuItem.Checked);
            s = VerificarFuente(s, "Strikeout");
        }

        private void subralladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checked(subralladoToolStripMenuItem.Checked); //podria usar este parametro para verificar el estado del texto en vez de usar los bool ¿pensar para mas adelante?
            u = VerificarFuente(u, "Underline");

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = richTextBox1.Text.Length.ToString() + " Caracteres";
            label2.Text = CArchivo.ContadorPalabras(richTextBox1.Text).ToString() + " Palabras";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            int indice = toolStripComboBox1.SelectedIndex;
            if (toolStripComboBox1.SelectedIndex < 0)
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSansSerif, 10, res);
            else
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSansSerif, Convert.ToInt32(toolStripComboBox1.Items[indice]), res);

        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(richTextBox1.Text.Split(' ').Length.ToString());
        }

        private bool Checked(bool fuente)
        {
            if (fuente)
                return false;
            else
                return true;
        }
        private bool VerificarFuente(bool estado, string TipoFuente)
        {
            if (estado == false)
            {
                font_style.Add(TipoFuente);
                Fuente();
                richTextBox1.Focus();
                return true;
            }
            else
            {
                font_style.Remove(TipoFuente);
                Fuente();
                richTextBox1.Focus();
                return false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Fuente()
        {
            string textoSeleccionado;
            float tamañoSeleccionadoTexto = 0;

            textoSeleccionado = richTextBox1.Font.Name;
            tamañoSeleccionadoTexto = richTextBox1.Font.Size;


            for (int i = 0; font_style.Count > i; i++)
            {
                res = res | (FontStyle)Enum.Parse(typeof(FontStyle), font_style[i], true);
            }

            richTextBox1.SelectionFont = new Font(textoSeleccionado, tamañoSeleccionadoTexto, res);
        }

        private void CrearBotones()
        {

            InstanciaBoton("Protagonista", null, 80, 25, 30, 74);

            for (int i = 1; i <= Vf; i++)
            {
                InstanciaBoton("VF", i.ToString(), 50, 23, 20, 84 + (i * 50));
            }

            for (int i = 1; i <= Vm; i++)
            {
                InstanciaBoton("VM", i.ToString(), 50, 23, 100, 84 + (i * 50));
            }
        }

        private void InstanciaBoton(string nombre, string i, int sizeX, int sizeY, int x, int y)
        {
            Button btn = new Button();
            btn.Location = new Point(x, y);
            btn.Text = nombre + i;
            btn.Size = new Size(sizeX, sizeY);
            panel1.Controls.Add(btn);
        }
        
    }
}
