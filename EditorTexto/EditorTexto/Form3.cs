using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorTexto
{
    public partial class Form3 : Form
    {
        List<string> nombre = new List<string>();
        SpeechSynthesizer voz = new SpeechSynthesizer();
        int y = 81;
        Dictionary<string, string> dict = new Dictionary<string, string>();

        public Dictionary<string, string> Dict { get => dict; set => dict = value; }

        public Form3(HashSet<string> nombres)
        {
            InitializeComponent();
            this.nombre = nombres.ToList();
            CrearLabelYComboBox("Secundaria:");
            CrearLabelYComboBox("Narrador:");
            for (int i = 0; i < nombres.Count; i++)
            {
                CrearLabelYComboBox(nombre[i]);
            }
        }

        private void CrearLabelYComboBox(string nombre)
        {
            
            Label lbl = new Label();
            lbl.Text = nombre;
            lbl.Font = new Font(lbl.Font.Name, 10);
            lbl.Location = new Point(15, y);
            lbl.Size = new Size(85, 30);
            this.Controls.Add(lbl);

            ComboBox cbx = new ComboBox();
            cbx.Location = new Point(50 + lbl.Size.Width, y);
            cbx.Size = new Size(150, 30);
            cbx.Name = cbx + "-" +nombre;

            foreach (InstalledVoice x in voz.GetInstalledVoices())
            {
                cbx.Items.Add(x.VoiceInfo.Name);
            }
            this.Controls.Add(cbx);

            y += 35;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls) // en vez de this puedes poner el nombre de un panel si es que tus textboxes se encuentran dentro de uno
            {
                if (c is ComboBox && c.Text != "")
                {
                    string [] aux = c.Name.Split('-');
                    Dict.Add(aux[1], c.Text);                    
                }
            }
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
