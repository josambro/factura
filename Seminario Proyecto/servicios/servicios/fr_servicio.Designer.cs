namespace servicios
{
    partial class fr_servicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_servicio));
            this.navegador1 = new Navegador.Navegador();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.txt_nomser = new System.Windows.Forms.TextBox();
            this.txt_preser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_estser = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(32, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "articulo";
            this.navegador1.TabIndex = 0;
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(125, 35);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(39, 20);
            this.txt_cod.TabIndex = 1;
            this.txt_cod.Tag = "Numero";
            this.txt_cod.Visible = false;
            // 
            // txt_nomser
            // 
            this.txt_nomser.Location = new System.Drawing.Point(125, 61);
            this.txt_nomser.Multiline = true;
            this.txt_nomser.Name = "txt_nomser";
            this.txt_nomser.Size = new System.Drawing.Size(295, 28);
            this.txt_nomser.TabIndex = 3;
            this.txt_nomser.Tag = "Descripcion";
            // 
            // txt_preser
            // 
            this.txt_preser.Location = new System.Drawing.Point(125, 105);
            this.txt_preser.Multiline = true;
            this.txt_preser.Name = "txt_preser";
            this.txt_preser.Size = new System.Drawing.Size(295, 28);
            this.txt_preser.TabIndex = 4;
            this.txt_preser.Tag = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre Servicio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txt_estser);
            this.groupBox1.Controls.Add(this.txt_nomser);
            this.groupBox1.Controls.Add(this.txt_cod);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_preser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 226);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_estser
            // 
            this.txt_estser.Location = new System.Drawing.Point(336, 153);
            this.txt_estser.Multiline = true;
            this.txt_estser.Name = "txt_estser";
            this.txt_estser.Size = new System.Drawing.Size(84, 21);
            this.txt_estser.TabIndex = 11;
            this.txt_estser.Tag = "Upc";
            this.txt_estser.Visible = false;
            // 
            // fr_servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 348);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.navegador1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "fr_servicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.fr_servicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.TextBox txt_nomser;
        private System.Windows.Forms.TextBox txt_preser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_estser;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}