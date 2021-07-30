namespace EditorTexto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Archivo = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.Heramientas = new System.Windows.Forms.TabPage();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.BtnColor = new System.Windows.Forms.ToolStripMenuItem();
            this.btnParrafo = new System.Windows.Forms.ToolStripMenuItem();
            this.centradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justificadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izquierdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLecturaTexto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFormato = new System.Windows.Forms.ToolStripMenuItem();
            this.negritaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subralladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kursivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tachadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTamaño = new System.Windows.Forms.ToolStripMenuItem();
            this.Insertar = new System.Windows.Forms.TabPage();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.btnImagen = new System.Windows.Forms.ToolStripMenuItem();
            this.Configuracion = new System.Windows.Forms.TabPage();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.btnConfiguracionVoz = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.btnCantidadVoces = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.Archivo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Heramientas.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.Insertar.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.Configuracion.SuspendLayout();
            this.menuStrip4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Archivo);
            this.tabControl1.Controls.Add(this.Heramientas);
            this.tabControl1.Controls.Add(this.Insertar);
            this.tabControl1.Controls.Add(this.Configuracion);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(864, 87);
            this.tabControl1.TabIndex = 1;
            // 
            // Archivo
            // 
            this.Archivo.Controls.Add(this.menuStrip1);
            this.Archivo.Location = new System.Drawing.Point(4, 25);
            this.Archivo.Name = "Archivo";
            this.Archivo.Padding = new System.Windows.Forms.Padding(3);
            this.Archivo.Size = new System.Drawing.Size(856, 58);
            this.Archivo.TabIndex = 0;
            this.Archivo.Text = "Archivo";
            this.Archivo.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnGuardarComo,
            this.btnImprimir});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 52);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(8, 0, 12, 0);
            this.btnNuevo.MergeIndex = 2;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(56, 48);
            this.btnNuevo.Text = "Abrir";
            this.btnNuevo.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.MergeIndex = 3;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(71, 48);
            this.btnGuardar.Text = "Guarda";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnGuardarComo
            // 
            this.btnGuardarComo.MergeIndex = 3;
            this.btnGuardarComo.Name = "btnGuardarComo";
            this.btnGuardarComo.Size = new System.Drawing.Size(118, 48);
            this.btnGuardarComo.Text = "Guardar como";
            // 
            // btnImprimir
            // 
            this.btnImprimir.MergeIndex = 4;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 48);
            this.btnImprimir.Text = "Imprimir";
            // 
            // Heramientas
            // 
            this.Heramientas.Controls.Add(this.menuStrip2);
            this.Heramientas.Location = new System.Drawing.Point(4, 25);
            this.Heramientas.Name = "Heramientas";
            this.Heramientas.Size = new System.Drawing.Size(856, 58);
            this.Heramientas.TabIndex = 1;
            this.Heramientas.Text = "Herramientas";
            this.Heramientas.UseVisualStyleBackColor = true;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFuente,
            this.BtnColor,
            this.btnParrafo,
            this.btnLecturaTexto,
            this.btnFormato,
            this.btnTamaño});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(856, 58);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btnFuente
            // 
            this.btnFuente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.btnFuente.Name = "btnFuente";
            this.btnFuente.Size = new System.Drawing.Size(67, 54);
            this.btnFuente.Text = "Fuente";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // BtnColor
            // 
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(59, 54);
            this.BtnColor.Text = "Color";
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // btnParrafo
            // 
            this.btnParrafo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centradoToolStripMenuItem,
            this.justificadoToolStripMenuItem,
            this.izquierdaToolStripMenuItem,
            this.derechaToolStripMenuItem});
            this.btnParrafo.Name = "btnParrafo";
            this.btnParrafo.Size = new System.Drawing.Size(70, 54);
            this.btnParrafo.Text = "Parrafo";
            // 
            // centradoToolStripMenuItem
            // 
            this.centradoToolStripMenuItem.Name = "centradoToolStripMenuItem";
            this.centradoToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.centradoToolStripMenuItem.Text = "Centrado";
            // 
            // justificadoToolStripMenuItem
            // 
            this.justificadoToolStripMenuItem.Name = "justificadoToolStripMenuItem";
            this.justificadoToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.justificadoToolStripMenuItem.Text = "Justificado";
            // 
            // izquierdaToolStripMenuItem
            // 
            this.izquierdaToolStripMenuItem.Name = "izquierdaToolStripMenuItem";
            this.izquierdaToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.izquierdaToolStripMenuItem.Text = "Izquierda";
            // 
            // derechaToolStripMenuItem
            // 
            this.derechaToolStripMenuItem.Name = "derechaToolStripMenuItem";
            this.derechaToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.derechaToolStripMenuItem.Text = "Derecha";
            // 
            // btnLecturaTexto
            // 
            this.btnLecturaTexto.Name = "btnLecturaTexto";
            this.btnLecturaTexto.Size = new System.Drawing.Size(132, 54);
            this.btnLecturaTexto.Text = "Lectura de Texto";
            // 
            // btnFormato
            // 
            this.btnFormato.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritaToolStripMenuItem,
            this.subralladoToolStripMenuItem,
            this.kursivaToolStripMenuItem,
            this.tachadoToolStripMenuItem});
            this.btnFormato.Name = "btnFormato";
            this.btnFormato.Size = new System.Drawing.Size(79, 54);
            this.btnFormato.Text = "Formato";
            this.btnFormato.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // negritaToolStripMenuItem
            // 
            this.negritaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.negritaToolStripMenuItem.Name = "negritaToolStripMenuItem";
            this.negritaToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.negritaToolStripMenuItem.Text = "Negrita";
            this.negritaToolStripMenuItem.Click += new System.EventHandler(this.negritaToolStripMenuItem_Click);
            // 
            // subralladoToolStripMenuItem
            // 
            this.subralladoToolStripMenuItem.Name = "subralladoToolStripMenuItem";
            this.subralladoToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.subralladoToolStripMenuItem.Text = "Subrallado";
            this.subralladoToolStripMenuItem.Click += new System.EventHandler(this.subralladoToolStripMenuItem_Click);
            // 
            // kursivaToolStripMenuItem
            // 
            this.kursivaToolStripMenuItem.Name = "kursivaToolStripMenuItem";
            this.kursivaToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.kursivaToolStripMenuItem.Text = "Cursiva";
            this.kursivaToolStripMenuItem.Click += new System.EventHandler(this.kursivaToolStripMenuItem_Click);
            // 
            // tachadoToolStripMenuItem
            // 
            this.tachadoToolStripMenuItem.Name = "tachadoToolStripMenuItem";
            this.tachadoToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.tachadoToolStripMenuItem.Text = "Tachado";
            this.tachadoToolStripMenuItem.Click += new System.EventHandler(this.tachadoToolStripMenuItem_Click);
            // 
            // btnTamaño
            // 
            this.btnTamaño.Name = "btnTamaño";
            this.btnTamaño.Size = new System.Drawing.Size(75, 54);
            this.btnTamaño.Text = "Tamaño";
            // 
            // Insertar
            // 
            this.Insertar.Controls.Add(this.menuStrip3);
            this.Insertar.Location = new System.Drawing.Point(4, 25);
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(856, 58);
            this.Insertar.TabIndex = 2;
            this.Insertar.Text = "Insertar";
            this.Insertar.UseVisualStyleBackColor = true;
            // 
            // menuStrip3
            // 
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImagen});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(856, 58);
            this.menuStrip3.TabIndex = 0;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // btnImagen
            // 
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(73, 54);
            this.btnImagen.Text = "Imagen";
            // 
            // Configuracion
            // 
            this.Configuracion.Controls.Add(this.menuStrip4);
            this.Configuracion.Location = new System.Drawing.Point(4, 25);
            this.Configuracion.Name = "Configuracion";
            this.Configuracion.Size = new System.Drawing.Size(856, 58);
            this.Configuracion.TabIndex = 3;
            this.Configuracion.Text = "Configuracion";
            this.Configuracion.UseVisualStyleBackColor = true;
            // 
            // menuStrip4
            // 
            this.menuStrip4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfiguracionVoz,
            this.btnCantidadVoces});
            this.menuStrip4.Location = new System.Drawing.Point(0, 0);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(856, 58);
            this.menuStrip4.TabIndex = 1;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // btnConfiguracionVoz
            // 
            this.btnConfiguracionVoz.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.btnConfiguracionVoz.Name = "btnConfiguracionVoz";
            this.btnConfiguracionVoz.Size = new System.Drawing.Size(167, 54);
            this.btnConfiguracionVoz.Text = "Configuracion De Voz";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 28);
            // 
            // btnCantidadVoces
            // 
            this.btnCantidadVoces.Name = "btnCantidadVoces";
            this.btnCantidadVoces.Size = new System.Drawing.Size(146, 54);
            this.btnCantidadVoces.Text = "Cantidad de Voces";
            this.btnCantidadVoces.Click += new System.EventHandler(this.cantidadDeVocesToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 363);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 329);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(651, 34);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "0 Palabras";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "0 carecteres";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(651, 363);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Selector de voces";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(651, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 363);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip3;
            this.Name = "Form1";
            this.Text = "ReadVc";
            this.tabControl1.ResumeLayout(false);
            this.Archivo.ResumeLayout(false);
            this.Archivo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Heramientas.ResumeLayout(false);
            this.Heramientas.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.Insertar.ResumeLayout(false);
            this.Insertar.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.Configuracion.ResumeLayout(false);
            this.Configuracion.PerformLayout();
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Archivo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnNuevo;
        private System.Windows.Forms.ToolStripMenuItem btnGuardar;
        private System.Windows.Forms.ToolStripMenuItem btnGuardarComo;
        private System.Windows.Forms.ToolStripMenuItem btnImprimir;
        private System.Windows.Forms.TabPage Heramientas;
        private System.Windows.Forms.TabPage Insertar;
        private System.Windows.Forms.TabPage Configuracion;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btnFuente;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem BtnColor;
        private System.Windows.Forms.ToolStripMenuItem btnParrafo;
        private System.Windows.Forms.ToolStripMenuItem centradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem justificadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izquierdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnLecturaTexto;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem btnImagen;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem btnConfiguracionVoz;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem btnCantidadVoces;
        private System.Windows.Forms.ToolStripMenuItem btnFormato;
        private System.Windows.Forms.ToolStripMenuItem negritaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subralladoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kursivaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnTamaño;
        private System.Windows.Forms.ToolStripMenuItem tachadoToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}

