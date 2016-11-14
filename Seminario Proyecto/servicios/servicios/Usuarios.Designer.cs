namespace servicios
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.navegador1 = new Navegador.Navegador();
            this.cbo_emp = new System.Windows.Forms.ComboBox();
            this.txt_emp = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_tipoemp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(46, 32);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tbl_usuario";
            this.navegador1.TabIndex = 0;
            // 
            // cbo_emp
            // 
            this.cbo_emp.FormattingEnabled = true;
            this.cbo_emp.Location = new System.Drawing.Point(211, 68);
            this.cbo_emp.Name = "cbo_emp";
            this.cbo_emp.Size = new System.Drawing.Size(197, 21);
            this.cbo_emp.TabIndex = 1;
            this.cbo_emp.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_emp
            // 
            this.txt_emp.Location = new System.Drawing.Point(438, 68);
            this.txt_emp.Multiline = true;
            this.txt_emp.Name = "txt_emp";
            this.txt_emp.Size = new System.Drawing.Size(53, 21);
            this.txt_emp.TabIndex = 2;
            this.txt_emp.Tag = "tbl_empleados_idtbl_empleados";
            this.txt_emp.Visible = false;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(211, 126);
            this.txt_usuario.Multiline = true;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(197, 21);
            this.txt_usuario.TabIndex = 3;
            this.txt_usuario.Tag = "nom_usuario";
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(211, 155);
            this.txt_contraseña.Multiline = true;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(197, 21);
            this.txt_contraseña.TabIndex = 4;
            this.txt_contraseña.Tag = "contra_usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txt_tipoemp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbo_emp);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.txt_emp);
            this.groupBox1.Controls.Add(this.txt_contraseña);
            this.groupBox1.Controls.Add(this.txt_usuario);
            this.groupBox1.Location = new System.Drawing.Point(46, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 244);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo usuario";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Secretaria"});
            this.comboBox1.Location = new System.Drawing.Point(211, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // txt_tipoemp
            // 
            this.txt_tipoemp.Location = new System.Drawing.Point(437, 95);
            this.txt_tipoemp.Name = "txt_tipoemp";
            this.txt_tipoemp.Size = new System.Drawing.Size(54, 20);
            this.txt_tipoemp.TabIndex = 9;
            this.txt_tipoemp.Tag = "tipo_usuario";
            this.txt_tipoemp.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Empleado";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(211, 31);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(51, 20);
            this.txt_id.TabIndex = 5;
            this.txt_id.Tag = "idtbl_usuario";
            this.txt_id.Visible = false;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 379);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.navegador1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.ComboBox cbo_emp;
        private System.Windows.Forms.TextBox txt_emp;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_tipoemp;
        private System.Windows.Forms.Label label4;
    }
}