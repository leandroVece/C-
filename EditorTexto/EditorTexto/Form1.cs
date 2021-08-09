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
using System.Speech.Synthesis;
using System.Threading;

namespace EditorTexto
{
    public partial class Form1 : Form
    {
        CArchivo Miarchivo = new CArchivo();
        List<string> font_style = new List<string>();
        bool n = false, i = false, u = false, s = false; //"Bold, Italic, Underline, Strikeout"
        FontStyle res = FontStyle.Regular;
        const int dist = 50;
        int indice =0;
        SpeechSynthesizer voz;
        List<string> texto = new List<string>();
        private int y = 145;
        Dictionary<string, string> PersonajesYVoces = new Dictionary<string, string>();
        int lineas = 0;
        public int Y { get => y; set => y = value; }


        public Form1()
        {
            InitializeComponent();
            for (int i = 8; i <= 30; i++)
            {
                toolStripComboBox1.Items.Add(i);
            }
            toolStripComboBox1.Text = "10";
            richTextBox1.SetInnerMargins(dist, dist, dist, 0);
            //richTextBox2.SetInnerMargins(0, dist, 0, 0);
            //LineTextBox1.ReadOnly = true;
            //LineTextBox1.Click = false;
            richTextBox1.Focus();
            voz = new SpeechSynthesizer();
            panel1.Visible = false;

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            OpenFileDialog direcrotio = new OpenFileDialog();
            if (direcrotio.ShowDialog() == DialogResult.OK)
            {
                if (Miarchivo.LeerArchivos(direcrotio.FileName) == null)
                    MessageBox.Show("Archivo no compatible");
                else
                {
                    richTextBox1.Text = Miarchivo.LeerArchivos(direcrotio.FileName);
                }
            }
            richTextBox1.Focus();
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

            //string name = "Mi archivo";
            salvar.FileName = "MiArchivo";
            salvar.Filter = "  Archivo TXT|*.txt| Archivo PDF|*.pdf| Archivo Word|*.docx| Archivo Word|*.doc";
            DialogResult result = salvar.ShowDialog();
            if (result == DialogResult.OK)
            {
                StreamWriter fileStream = new StreamWriter(salvar.FileName);

                foreach (object line in richTextBox1.Lines)
                {
                    fileStream.WriteLine(line);
                }
                fileStream.Close();
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

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            label1.Text = richTextBox1.Text.Length.ToString() + " Caracteres";
            label2.Text = CArchivo.ContadorPalabras(richTextBox1.Text).ToString() + " Palabras";
            //MessageBox.Show();

           if(lineas < richTextBox1.Lines.Length)
           {
                lineas = richTextBox1.Lines.Length;
                int posY = richTextBox1.GetPositionFromCharIndex(richTextBox1.GetFirstCharIndexOfCurrentLine()).Y;
                crearLavel(posY, lineas.ToString());
           }
           if(lineas> richTextBox1.Lines.Length)
            {
                int lineasBorrar = lineas - richTextBox1.Lines.Length;
                for (int i = 0; i < lineasBorrar; i++)
                {
                    richTextBox1.Controls.RemoveAt(richTextBox1.Lines.Length);
                }
                lineas = richTextBox1.Lines.Length;
            }
            
        }

        public void crearLavel(int puntoY,string text)
        {
            Label LineNumber = new Label();
            LineNumber.Location = new System.Drawing.Point(5,puntoY);
            LineNumber.Font = richTextBox1.Font;
            LineNumber.Name = "label"+text;
            LineNumber.Text = text;  
            LineNumber.Size = new System.Drawing.Size(40, LineNumber.PreferredHeight);
            LineNumber.ForeColor = Color.Crimson;
            LineNumber.BackColor = Color.DimGray;
            richTextBox1.Controls.Add(LineNumber);      
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
      
            /*if(lineas != richTextBox1.Lines.Length)
            {
                LineTextBox1.Text = "";
                lineas = richTextBox1.Lines.Length;
                for (int i = 0; i < lineas; i++)
                {
                    LineTextBox1.Text += "\r\n"+ (i+1);
                    
                }
                //LineTextBox1. = HorizontalAlignment.Center;
                LineTextBox1.SelectionStart = LineTextBox1.TextLength;
            }*/
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
            MessageBox.Show("Palabras = " + CArchivo.ContadorPalabras(richTextBox1.Text).ToString()
                            + "\nLineas = " + richTextBox1.Lines.Length);
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

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (panel1.Visible)
                    panel1.Visible = false;
                else
                {
                    panel1.Visible = true;
                    richTextBox1.SelectAll();
                    richTextBox1.SelectionBackColor = Color.White;
                    indice = richTextBox1.Text.IndexOf('-');
                    richTextBox1.Select(richTextBox1.Text.IndexOf('-'),1);
                    richTextBox1.SelectionBackColor = Color.Yellow;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Abra un archivo primero");
            }
            
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

        private void btnLecturaTexto_Click(object sender, EventArgs e)
        {
            LecturaTexto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SelectAll();
                richTextBox1.SelectionBackColor = Color.White;

                indice = richTextBox1.Text.IndexOf('-',indice+1);

                richTextBox1.Select(richTextBox1.Text.IndexOf('-',indice), 1);
                richTextBox1.SelectionBackColor = Color.Yellow;

            }
            catch (Exception)
            {

                MessageBox.Show("No hay mas cambio que hacer");
            }

        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Capture F5 KeyPress
            if (e.KeyCode == Keys.F5)
            {
                LecturaTexto();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AgregarCambios(button3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = TBName.Text + ": ";
            btn.Font = new Font(btn.Font.Name,10);
            btn.Location = new Point(20, Y);
            btn.Size = new Size(100, 30);
            btn.Click += new EventHandler(btn_click);

            panel1.Controls.Add(btn);
            Y += 35;
        }

        private void btnVGF_Click(object sender, EventArgs e)
        {
            AgregarCambios(btnVGF.Text);
        }

        private void btnConfiguracionVoz_Click(object sender, EventArgs e)
        {
            HashSet<string> nombres = new HashSet<string>();
            string[] parrafo = richTextBox1.Text.Split('\n');
            for (int i = 0; i < parrafo.Length; i++)
            {
                if (parrafo[i] != "" && parrafo[i] != "...")
                {
                    //string aux = (a[i].Substring(0, a[i].IndexOf(" ")));
                    //para que de esta manera el que tenga un punto antes de un espacio pueda reconocerlo. 
                    string[] aux = parrafo[i].Split(' ');
                    if (aux[0].Contains(':'))
                        nombres.Add(aux[0]);
                }
            }
            Form3 ConfiVoz = new Form3(nombres);
            ConfiVoz.ShowDialog();
            PersonajesYVoces = ConfiVoz.Dict;

        }

        private void btn_click(object sender, EventArgs e)
        {
            Button Btnclick = (Button)sender;
            AgregarCambios(Btnclick.Text);
        }

        private void AgregarCambios(string variable)
        {
            indice = richTextBox1.Text.IndexOf('-',indice);
            string a = richTextBox1.Text.Remove(indice, 1);
            a = a.Insert(indice, variable);
            richTextBox1.Text = a;

            richTextBox1.Select(richTextBox1.Text.IndexOf('-', indice), 1);
            richTextBox1.SelectionBackColor = Color.Yellow;

        }

        private void controlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PanelControlVoz.Visible)
                PanelControlVoz.Visible = false;
            else
                PanelControlVoz.Visible = true;
        }

        private void LecturaTexto()
        {
            menuStrip5.Visible = true;
            PanelControlVoz.Visible = true;
            voz = new SpeechSynthesizer();
            voz.Volume = 60;
            voz.Rate = 0;
            string nombrevoces = selectorVoces("Narrador:");
            string[] texto = richTextBox1.Text.Split('\n');

             for (int i = 0; i < texto.Length; i++)
            {
                string[] parrafo = texto[i].Split(' ');

                if (parrafo[0].Contains(':'))
                {
                    nombrevoces = selectorVoces(parrafo[0]);
                    voz.SelectVoice(nombrevoces);
                    texto[i] = texto[i].Replace(parrafo[0], "");
                }
                voz.SpeakAsync(texto[i]);
                Thread.Sleep(2400);
                //bool a = await VozSalida(texto[i]);
            }

        }

        private async Task<bool> VozSalida(string parrafo) //intento de no usar el Thread
        {
            await Task.Run(() =>
            {
                voz.SpeakAsync(parrafo);
            });
            return true;
        }

        private string selectorVoces(string nombre)
        {
            foreach(KeyValuePair<string,string> itens in PersonajesYVoces)
            {
                if (itens.Key == nombre)
                    return itens.Value;
            }
            return PersonajesYVoces["Narrador:"];
        }

    }
}
