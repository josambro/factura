namespace SIP_Administrativo
{
    partial class wf_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wf_Empleados));
            this.gboPersonales = new System.Windows.Forms.GroupBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldire = new System.Windows.Forms.Label();
            this.lbldpi = new System.Windows.Forms.Label();
            this.lblnom1 = new System.Windows.Forms.Label();
            this.lblnit = new System.Windows.Forms.Label();
            this.lblape1 = new System.Windows.Forms.Label();
            this.txtdpi_emp = new System.Windows.Forms.TextBox();
            this.txtnom1_emp = new System.Windows.Forms.TextBox();
            this.txtape1_emp = new System.Windows.Forms.TextBox();
            this.txtdire_emp = new System.Windows.Forms.TextBox();
            this.txtnit_emp = new System.Windows.Forms.TextBox();
            this.lblcodEmp = new System.Windows.Forms.Label();
            this.txtcod_emp = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.gboPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboPersonales
            // 
            this.gboPersonales.Controls.Add(this.txt_fecha);
            this.gboPersonales.Controls.Add(this.label1);
            this.gboPersonales.Controls.Add(this.lbldire);
            this.gboPersonales.Controls.Add(this.lbldpi);
            this.gboPersonales.Controls.Add(this.lblnom1);
            this.gboPersonales.Controls.Add(this.lblnit);
            this.gboPersonales.Controls.Add(this.lblape1);
            this.gboPersonales.Controls.Add(this.txtdpi_emp);
            this.gboPersonales.Controls.Add(this.txtnom1_emp);
            this.gboPersonales.Controls.Add(this.txtape1_emp);
            this.gboPersonales.Controls.Add(this.txtdire_emp);
            this.gboPersonales.Controls.Add(this.txtnit_emp);
            this.gboPersonales.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboPersonales.Location = new System.Drawing.Point(37, 114);
            this.gboPersonales.Name = "gboPersonales";
            this.gboPersonales.Size = new System.Drawing.Size(617, 162);
            this.gboPersonales.TabIndex = 52;
            this.gboPersonales.TabStop = false;
            this.gboPersonales.Text = "Datos Personales";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(114, 123);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(209, 21);
            this.txt_fecha.TabIndex = 37;
            this.txt_fecha.Tag = "fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Fecha";
            // 
            // lbldire
            // 
            this.lbldire.AutoSize = true;
            this.lbldire.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldire.Location = new System.Drawing.Point(18, 97);
            this.lbldire.Name = "lbldire";
            this.lbldire.Size = new System.Drawing.Size(60, 15);
            this.lbldire.TabIndex = 21;
            this.lbldire.Text = "Dirección";
            // 
            // lbldpi
            // 
            this.lbldpi.AutoSize = true;
            this.lbldpi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldpi.Location = new System.Drawing.Point(18, 73);
            this.lbldpi.Name = "lbldpi";
            this.lbldpi.Size = new System.Drawing.Size(25, 15);
            this.lbldpi.TabIndex = 15;
            this.lbldpi.Text = "DPI";
            // 
            // lblnom1
            // 
            this.lblnom1.AutoSize = true;
            this.lblnom1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom1.Location = new System.Drawing.Point(18, 39);
            this.lblnom1.Name = "lblnom1";
            this.lblnom1.Size = new System.Drawing.Size(59, 15);
            this.lblnom1.TabIndex = 17;
            this.lblnom1.Text = "Nombres:";
            // 
            // lblnit
            // 
            this.lblnit.AutoSize = true;
            this.lblnit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnit.Location = new System.Drawing.Point(346, 70);
            this.lblnit.Name = "lblnit";
            this.lblnit.Size = new System.Drawing.Size(23, 15);
            this.lblnit.TabIndex = 16;
            this.lblnit.Text = "NIT";
            // 
            // lblape1
            // 
            this.lblape1.AutoSize = true;
            this.lblape1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblape1.Location = new System.Drawing.Point(329, 39);
            this.lblape1.Name = "lblape1";
            this.lblape1.Size = new System.Drawing.Size(60, 15);
            this.lblape1.TabIndex = 19;
            this.lblape1.Text = "Apellidos:";
            // 
            // txtdpi_emp
            // 
            this.txtdpi_emp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdpi_emp.Location = new System.Drawing.Point(114, 67);
            this.txtdpi_emp.MaxLength = 13;
            this.txtdpi_emp.Name = "txtdpi_emp";
            this.txtdpi_emp.Size = new System.Drawing.Size(209, 21);
            this.txtdpi_emp.TabIndex = 28;
            this.txtdpi_emp.Tag = "dpi_emp";
            // 
            // txtnom1_emp
            // 
            this.txtnom1_emp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom1_emp.Location = new System.Drawing.Point(114, 36);
            this.txtnom1_emp.Name = "txtnom1_emp";
            this.txtnom1_emp.Size = new System.Drawing.Size(209, 21);
            this.txtnom1_emp.TabIndex = 30;
            this.txtnom1_emp.Tag = "nombre_emp";
            // 
            // txtape1_emp
            // 
            this.txtape1_emp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtape1_emp.Location = new System.Drawing.Point(395, 36);
            this.txtape1_emp.Name = "txtape1_emp";
            this.txtape1_emp.Size = new System.Drawing.Size(198, 21);
            this.txtape1_emp.TabIndex = 32;
            this.txtape1_emp.Tag = "apellido_emp";
            // 
            // txtdire_emp
            // 
            this.txtdire_emp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdire_emp.Location = new System.Drawing.Point(114, 97);
            this.txtdire_emp.Name = "txtdire_emp";
            this.txtdire_emp.Size = new System.Drawing.Size(479, 21);
            this.txtdire_emp.TabIndex = 34;
            this.txtdire_emp.Tag = "dire_emp";
            // 
            // txtnit_emp
            // 
            this.txtnit_emp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnit_emp.Location = new System.Drawing.Point(395, 67);
            this.txtnit_emp.MaxLength = 9;
            this.txtnit_emp.Name = "txtnit_emp";
            this.txtnit_emp.Size = new System.Drawing.Size(198, 21);
            this.txtnit_emp.TabIndex = 29;
            this.txtnit_emp.Tag = "nit_emp";
            // 
            // lblcodEmp
            // 
            this.lblcodEmp.AutoSize = true;
            this.lblcodEmp.Location = new System.Drawing.Point(485, 91);
            this.lblcodEmp.Name = "lblcodEmp";
            this.lblcodEmp.Size = new System.Drawing.Size(90, 13);
            this.lblcodEmp.TabIndex = 56;
            this.lblcodEmp.Text = "Codigo Empleado";
            // 
            // txtcod_emp
            // 
            this.txtcod_emp.Location = new System.Drawing.Point(581, 88);
            this.txtcod_emp.Name = "txtcod_emp";
            this.txtcod_emp.Size = new System.Drawing.Size(49, 20);
            this.txtcod_emp.TabIndex = 55;
            this.txtcod_emp.Tag = "idtbl_empleados";
            this.txtcod_emp.TextChanged += new System.EventHandler(this.txtcod_emp_TextChanged);
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(47, 13);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tbl_empleados";
            this.navegador1.TabIndex = 54;
            this.navegador1.btnNuevo_BeforeClick += new System.EventHandler(this.navegador1_btnNuevo_BeforeClick_1);
            // 
            // wf_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 288);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lblcodEmp);
            this.Controls.Add(this.txtcod_emp);
            this.Controls.Add(this.gboPersonales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "wf_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATSA - Empleados";
            this.Load += new System.EventHandler(this.wf_Empleados_Load);
            this.gboPersonales.ResumeLayout(false);
            this.gboPersonales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboPersonales;
        private System.Windows.Forms.Label lbldire;
        private System.Windows.Forms.Label lbldpi;
        private System.Windows.Forms.Label lblnom1;
        private System.Windows.Forms.Label lblnit;
        private System.Windows.Forms.Label lblape1;
        private System.Windows.Forms.TextBox txtdpi_emp;
        private System.Windows.Forms.TextBox txtnom1_emp;
        private System.Windows.Forms.TextBox txtape1_emp;
        private System.Windows.Forms.TextBox txtdire_emp;
        private System.Windows.Forms.TextBox txtnit_emp;
        private System.Windows.Forms.Label lblcodEmp;
        private System.Windows.Forms.TextBox txtcod_emp;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_fecha;
    }
}