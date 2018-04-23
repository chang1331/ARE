namespace ARE
{
    partial class frmSalones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalones));
            this.btnCalcula = new System.Windows.Forms.Button();
            this.txtClases = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxSalones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rBMaestro = new System.Windows.Forms.RadioButton();
            this.rBHorario = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cBSalones = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNRes = new System.Windows.Forms.TextBox();
            this.cbRestriccion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnumClases = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRestricciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcula
            // 
            this.btnCalcula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCalcula.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcula.Location = new System.Drawing.Point(318, 599);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(191, 23);
            this.btnCalcula.TabIndex = 0;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = false;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // txtClases
            // 
            this.txtClases.Location = new System.Drawing.Point(95, 210);
            this.txtClases.Multiline = true;
            this.txtClases.Name = "txtClases";
            this.txtClases.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtClases.Size = new System.Drawing.Size(417, 88);
            this.txtClases.TabIndex = 1;
            this.txtClases.WordWrap = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(678, 275);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 130);
            this.listBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(960, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 67);
            this.button1.TabIndex = 3;
            this.button1.Text = "Eliminar restricción";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(101, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Agrega clases";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(101, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(423, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Escribe el número máximo de salones";
            // 
            // txtMaxSalones
            // 
            this.txtMaxSalones.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxSalones.Location = new System.Drawing.Point(283, 384);
            this.txtMaxSalones.Name = "txtMaxSalones";
            this.txtMaxSalones.Size = new System.Drawing.Size(52, 28);
            this.txtMaxSalones.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(92, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Número de salones:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(674, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tipo: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(674, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Clase: ";
            // 
            // rBMaestro
            // 
            this.rBMaestro.AutoSize = true;
            this.rBMaestro.BackColor = System.Drawing.Color.Transparent;
            this.rBMaestro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rBMaestro.Location = new System.Drawing.Point(1015, 148);
            this.rBMaestro.Name = "rBMaestro";
            this.rBMaestro.Size = new System.Drawing.Size(80, 21);
            this.rBMaestro.TabIndex = 17;
            this.rBMaestro.TabStop = true;
            this.rBMaestro.Text = "Maestro";
            this.rBMaestro.UseVisualStyleBackColor = false;
            // 
            // rBHorario
            // 
            this.rBHorario.AutoSize = true;
            this.rBHorario.BackColor = System.Drawing.Color.Transparent;
            this.rBHorario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rBHorario.Location = new System.Drawing.Point(868, 148);
            this.rBHorario.Name = "rBHorario";
            this.rBHorario.Size = new System.Drawing.Size(76, 21);
            this.rBHorario.TabIndex = 16;
            this.rBHorario.TabStop = true;
            this.rBHorario.Text = "Horario";
            this.rBHorario.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(684, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Agrega restricciones";
            // 
            // cBSalones
            // 
            this.cBSalones.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBSalones.FormattingEnabled = true;
            this.cBSalones.Location = new System.Drawing.Point(866, 99);
            this.cBSalones.Name = "cBSalones";
            this.cBSalones.Size = new System.Drawing.Size(52, 29);
            this.cBSalones.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(674, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Restricción:";
            // 
            // txtNRes
            // 
            this.txtNRes.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNRes.Location = new System.Drawing.Point(1015, 185);
            this.txtNRes.Name = "txtNRes";
            this.txtNRes.Size = new System.Drawing.Size(52, 28);
            this.txtNRes.TabIndex = 22;
            // 
            // cbRestriccion
            // 
            this.cbRestriccion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRestriccion.FormattingEnabled = true;
            this.cbRestriccion.Location = new System.Drawing.Point(868, 184);
            this.cbRestriccion.Name = "cbRestriccion";
            this.cbRestriccion.Size = new System.Drawing.Size(109, 29);
            this.cbRestriccion.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(91, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "Número de clases:";
            // 
            // txtnumClases
            // 
            this.txtnumClases.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumClases.Location = new System.Drawing.Point(283, 99);
            this.txtnumClases.Name = "txtnumClases";
            this.txtnumClases.Size = new System.Drawing.Size(52, 28);
            this.txtnumClases.TabIndex = 25;
            this.txtnumClases.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(101, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(318, 29);
            this.label9.TabIndex = 24;
            this.label9.Text = "Escribe el número de clases";
            // 
            // btnRestricciones
            // 
            this.btnRestricciones.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestricciones.Location = new System.Drawing.Point(960, 275);
            this.btnRestricciones.Name = "btnRestricciones";
            this.btnRestricciones.Size = new System.Drawing.Size(135, 60);
            this.btnRestricciones.TabIndex = 27;
            this.btnRestricciones.Text = "Agregar Restricciones";
            this.btnRestricciones.UseVisualStyleBackColor = true;
            // 
            // frmSalones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1152, 658);
            this.Controls.Add(this.btnRestricciones);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnumClases);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbRestriccion);
            this.Controls.Add(this.txtNRes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rBMaestro);
            this.Controls.Add(this.rBHorario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBSalones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaxSalones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtClases);
            this.Controls.Add(this.btnCalcula);
            this.Name = "frmSalones";
            this.Text = "ARE";
            this.Load += new System.EventHandler(this.frmSalones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.TextBox txtClases;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxSalones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rBMaestro;
        private System.Windows.Forms.RadioButton rBHorario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBSalones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNRes;
        private System.Windows.Forms.ComboBox cbRestriccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnumClases;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRestricciones;
    }
}

