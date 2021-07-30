using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorTexto
{
    public partial class Form2 : Form
    {
        private string protagonista;
        private int vm, vf;

        public string Protagonista { get => protagonista; set => protagonista = value; }
        public int Vm { get => vm; set => vm = value; }
        public int Vf { get => vf; set => vf = value; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Protagonista = comboBox1.Text;
            Vf = Convert.ToInt32(textBox1.Text);
            Vm = Convert.ToInt32(textBox2.Text);
            this.Close();

        }
    }
}
