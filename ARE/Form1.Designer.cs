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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxSalones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnumClases = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtResMaes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResHor = new System.Windows.Forms.TextBox();
            this.btnllenaDef = new System.Windows.Forms.Button();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(684, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Agrega restricciones de horario";
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
            // txtResMaes
            // 
            this.txtResMaes.Location = new System.Drawing.Point(689, 301);
            this.txtResMaes.Multiline = true;
            this.txtResMaes.Name = "txtResMaes";
            this.txtResMaes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResMaes.Size = new System.Drawing.Size(276, 88);
            this.txtResMaes.TabIndex = 29;
            this.txtResMaes.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(684, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(361, 29);
            this.label6.TabIndex = 32;
            this.label6.Text = "Agrega restricciones de maestro";
            // 
            // txtResHor
            // 
            this.txtResHor.Location = new System.Drawing.Point(689, 104);
            this.txtResHor.Multiline = true;
            this.txtResHor.Name = "txtResHor";
            this.txtResHor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResHor.Size = new System.Drawing.Size(276, 88);
            this.txtResHor.TabIndex = 33;
            this.txtResHor.WordWrap = false;
            // 
            // btnllenaDef
            // 
            this.btnllenaDef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnllenaDef.BackColor = System.Drawing.Color.Transparent;
            this.btnllenaDef.Location = new System.Drawing.Point(488, 469);
            this.btnllenaDef.Name = "btnllenaDef";
            this.btnllenaDef.Size = new System.Drawing.Size(191, 23);
            this.btnllenaDef.TabIndex = 34;
            this.btnllenaDef.Text = "LlenaDefault";
            this.btnllenaDef.UseVisualStyleBackColor = false;
            this.btnllenaDef.Click += new System.EventHandler(this.btnllenaDef_Click);
            // 
            // frmSalones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1152, 658);
            this.Controls.Add(this.btnllenaDef);
            this.Controls.Add(this.txtResHor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtResMaes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnumClases);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaxSalones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxSalones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnumClases;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtResMaes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResHor;
        private System.Windows.Forms.Button btnllenaDef;
    }
}

