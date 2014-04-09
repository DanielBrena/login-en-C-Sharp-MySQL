namespace WindowsFormsApplication4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxIniciaSesion = new System.Windows.Forms.GroupBox();
            this.textBoxUsuarioI = new System.Windows.Forms.TextBox();
            this.textBoxContrasenaI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAccederI = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxOperaciones = new System.Windows.Forms.GroupBox();
            this.buttonAgregarO = new System.Windows.Forms.Button();
            this.buttonrRecargarO = new System.Windows.Forms.Button();
            this.groupBoxAgregar = new System.Windows.Forms.GroupBox();
            this.textBoxNombreA = new System.Windows.Forms.TextBox();
            this.textBoxUsuarioA = new System.Windows.Forms.TextBox();
            this.textBoxContrasenaA = new System.Windows.Forms.TextBox();
            this.numericUpDownEstatusA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPerfilA = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCancelarA = new System.Windows.Forms.Button();
            this.buttonAgregarA = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxIniciaSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxOperaciones.SuspendLayout();
            this.groupBoxAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEstatusA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPerfilA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxIniciaSesion
            // 
            this.groupBoxIniciaSesion.Controls.Add(this.label3);
            this.groupBoxIniciaSesion.Controls.Add(this.buttonAccederI);
            this.groupBoxIniciaSesion.Controls.Add(this.label2);
            this.groupBoxIniciaSesion.Controls.Add(this.label1);
            this.groupBoxIniciaSesion.Controls.Add(this.textBoxContrasenaI);
            this.groupBoxIniciaSesion.Controls.Add(this.textBoxUsuarioI);
            this.groupBoxIniciaSesion.Location = new System.Drawing.Point(26, 26);
            this.groupBoxIniciaSesion.Name = "groupBoxIniciaSesion";
            this.groupBoxIniciaSesion.Size = new System.Drawing.Size(195, 240);
            this.groupBoxIniciaSesion.TabIndex = 0;
            this.groupBoxIniciaSesion.TabStop = false;
            this.groupBoxIniciaSesion.Text = "Inicia Sesión";
            // 
            // textBoxUsuarioI
            // 
            this.textBoxUsuarioI.Location = new System.Drawing.Point(33, 60);
            this.textBoxUsuarioI.Name = "textBoxUsuarioI";
            this.textBoxUsuarioI.Size = new System.Drawing.Size(111, 20);
            this.textBoxUsuarioI.TabIndex = 0;
            // 
            // textBoxContrasenaI
            // 
            this.textBoxContrasenaI.Location = new System.Drawing.Point(33, 144);
            this.textBoxContrasenaI.Name = "textBoxContrasenaI";
            this.textBoxContrasenaI.PasswordChar = '*';
            this.textBoxContrasenaI.Size = new System.Drawing.Size(111, 20);
            this.textBoxContrasenaI.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // buttonAccederI
            // 
            this.buttonAccederI.Location = new System.Drawing.Point(51, 202);
            this.buttonAccederI.Name = "buttonAccederI";
            this.buttonAccederI.Size = new System.Drawing.Size(75, 23);
            this.buttonAccederI.TabIndex = 4;
            this.buttonAccederI.Text = "Acceder";
            this.buttonAccederI.UseVisualStyleBackColor = true;
            this.buttonAccederI.Click += new System.EventHandler(this.buttonAccederI_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(268, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(399, 215);
            this.dataGridView1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(15, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario o contraseña incorrecto";
            // 
            // groupBoxOperaciones
            // 
            this.groupBoxOperaciones.Controls.Add(this.buttonrRecargarO);
            this.groupBoxOperaciones.Controls.Add(this.buttonAgregarO);
            this.groupBoxOperaciones.Location = new System.Drawing.Point(26, 26);
            this.groupBoxOperaciones.Name = "groupBoxOperaciones";
            this.groupBoxOperaciones.Size = new System.Drawing.Size(195, 240);
            this.groupBoxOperaciones.TabIndex = 6;
            this.groupBoxOperaciones.TabStop = false;
            this.groupBoxOperaciones.Text = "Operaciones";
            this.groupBoxOperaciones.Visible = false;
            // 
            // buttonAgregarO
            // 
            this.buttonAgregarO.Location = new System.Drawing.Point(51, 56);
            this.buttonAgregarO.Name = "buttonAgregarO";
            this.buttonAgregarO.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarO.TabIndex = 0;
            this.buttonAgregarO.Text = "Agregar";
            this.buttonAgregarO.UseVisualStyleBackColor = true;
            this.buttonAgregarO.Click += new System.EventHandler(this.buttonAgregarO_Click);
            // 
            // buttonrRecargarO
            // 
            this.buttonrRecargarO.Location = new System.Drawing.Point(51, 144);
            this.buttonrRecargarO.Name = "buttonrRecargarO";
            this.buttonrRecargarO.Size = new System.Drawing.Size(75, 23);
            this.buttonrRecargarO.TabIndex = 1;
            this.buttonrRecargarO.Text = "Recargar ";
            this.buttonrRecargarO.UseVisualStyleBackColor = true;
            this.buttonrRecargarO.Click += new System.EventHandler(this.buttonrRecargarO_Click);
            // 
            // groupBoxAgregar
            // 
            this.groupBoxAgregar.Controls.Add(this.label9);
            this.groupBoxAgregar.Controls.Add(this.buttonAgregarA);
            this.groupBoxAgregar.Controls.Add(this.buttonCancelarA);
            this.groupBoxAgregar.Controls.Add(this.label8);
            this.groupBoxAgregar.Controls.Add(this.label7);
            this.groupBoxAgregar.Controls.Add(this.label6);
            this.groupBoxAgregar.Controls.Add(this.label5);
            this.groupBoxAgregar.Controls.Add(this.label4);
            this.groupBoxAgregar.Controls.Add(this.numericUpDownPerfilA);
            this.groupBoxAgregar.Controls.Add(this.numericUpDownEstatusA);
            this.groupBoxAgregar.Controls.Add(this.textBoxContrasenaA);
            this.groupBoxAgregar.Controls.Add(this.textBoxUsuarioA);
            this.groupBoxAgregar.Controls.Add(this.textBoxNombreA);
            this.groupBoxAgregar.Location = new System.Drawing.Point(26, 26);
            this.groupBoxAgregar.Name = "groupBoxAgregar";
            this.groupBoxAgregar.Size = new System.Drawing.Size(195, 240);
            this.groupBoxAgregar.TabIndex = 2;
            this.groupBoxAgregar.TabStop = false;
            this.groupBoxAgregar.Text = "Agregar usuario";
            this.groupBoxAgregar.Visible = false;
            // 
            // textBoxNombreA
            // 
            this.textBoxNombreA.Location = new System.Drawing.Point(44, 30);
            this.textBoxNombreA.Name = "textBoxNombreA";
            this.textBoxNombreA.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreA.TabIndex = 0;
            // 
            // textBoxUsuarioA
            // 
            this.textBoxUsuarioA.Location = new System.Drawing.Point(42, 65);
            this.textBoxUsuarioA.Name = "textBoxUsuarioA";
            this.textBoxUsuarioA.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsuarioA.TabIndex = 1;
            // 
            // textBoxContrasenaA
            // 
            this.textBoxContrasenaA.Location = new System.Drawing.Point(42, 101);
            this.textBoxContrasenaA.Name = "textBoxContrasenaA";
            this.textBoxContrasenaA.Size = new System.Drawing.Size(100, 20);
            this.textBoxContrasenaA.TabIndex = 2;
            // 
            // numericUpDownEstatusA
            // 
            this.numericUpDownEstatusA.Location = new System.Drawing.Point(44, 137);
            this.numericUpDownEstatusA.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEstatusA.Name = "numericUpDownEstatusA";
            this.numericUpDownEstatusA.Size = new System.Drawing.Size(98, 20);
            this.numericUpDownEstatusA.TabIndex = 3;
            // 
            // numericUpDownPerfilA
            // 
            this.numericUpDownPerfilA.Location = new System.Drawing.Point(44, 175);
            this.numericUpDownPerfilA.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownPerfilA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPerfilA.Name = "numericUpDownPerfilA";
            this.numericUpDownPerfilA.Size = new System.Drawing.Size(98, 20);
            this.numericUpDownPerfilA.TabIndex = 4;
            this.numericUpDownPerfilA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Contraseña";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Estatus";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Perfil ID";
            // 
            // buttonCancelarA
            // 
            this.buttonCancelarA.Location = new System.Drawing.Point(6, 216);
            this.buttonCancelarA.Name = "buttonCancelarA";
            this.buttonCancelarA.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarA.TabIndex = 10;
            this.buttonCancelarA.Text = "Cancelar";
            this.buttonCancelarA.UseVisualStyleBackColor = true;
            this.buttonCancelarA.Click += new System.EventHandler(this.buttonCancelarA_Click);
            // 
            // buttonAgregarA
            // 
            this.buttonAgregarA.Location = new System.Drawing.Point(98, 216);
            this.buttonAgregarA.Name = "buttonAgregarA";
            this.buttonAgregarA.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarA.TabIndex = 11;
            this.buttonAgregarA.Text = "Agregar";
            this.buttonAgregarA.UseVisualStyleBackColor = true;
            this.buttonAgregarA.Click += new System.EventHandler(this.buttonAgregarA_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(31, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Faltan algunos campos";
            this.label9.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 290);
            this.Controls.Add(this.groupBoxAgregar);
            this.Controls.Add(this.groupBoxOperaciones);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxIniciaSesion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxIniciaSesion.ResumeLayout(false);
            this.groupBoxIniciaSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxOperaciones.ResumeLayout(false);
            this.groupBoxAgregar.ResumeLayout(false);
            this.groupBoxAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEstatusA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPerfilA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIniciaSesion;
        private System.Windows.Forms.Button buttonAccederI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxContrasenaI;
        private System.Windows.Forms.TextBox textBoxUsuarioI;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxOperaciones;
        private System.Windows.Forms.Button buttonrRecargarO;
        private System.Windows.Forms.Button buttonAgregarO;
        private System.Windows.Forms.GroupBox groupBoxAgregar;
        private System.Windows.Forms.NumericUpDown numericUpDownEstatusA;
        private System.Windows.Forms.TextBox textBoxContrasenaA;
        private System.Windows.Forms.TextBox textBoxUsuarioA;
        private System.Windows.Forms.TextBox textBoxNombreA;
        private System.Windows.Forms.Button buttonAgregarA;
        private System.Windows.Forms.Button buttonCancelarA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownPerfilA;
        private System.Windows.Forms.Label label9;
    }
}

