namespace Pedido_de_Chefellas
{
    partial class Conversiones
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
            this.BTReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPosfija = new System.Windows.Forms.TextBox();
            this.BTConvertir = new System.Windows.Forms.Button();
            this.textBoxInfija = new System.Windows.Forms.TextBox();
            this.textBoxPrefija = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTReset
            // 
            this.BTReset.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTReset.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTReset.Location = new System.Drawing.Point(99, 165);
            this.BTReset.Name = "BTReset";
            this.BTReset.Size = new System.Drawing.Size(116, 23);
            this.BTReset.TabIndex = 17;
            this.BTReset.Text = "Reiniciar Campos";
            this.BTReset.UseVisualStyleBackColor = false;
            this.BTReset.Click += new System.EventHandler(this.BTReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(38, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "infija";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(222, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Posfija";
            // 
            // textBoxPosfija
            // 
            this.textBoxPosfija.Location = new System.Drawing.Point(204, 119);
            this.textBoxPosfija.Name = "textBoxPosfija";
            this.textBoxPosfija.ReadOnly = true;
            this.textBoxPosfija.Size = new System.Drawing.Size(100, 20);
            this.textBoxPosfija.TabIndex = 14;
            this.textBoxPosfija.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTConvertir
            // 
            this.BTConvertir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTConvertir.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTConvertir.Location = new System.Drawing.Point(121, 64);
            this.BTConvertir.Name = "BTConvertir";
            this.BTConvertir.Size = new System.Drawing.Size(75, 23);
            this.BTConvertir.TabIndex = 13;
            this.BTConvertir.Text = "Convertir";
            this.BTConvertir.UseVisualStyleBackColor = false;
            this.BTConvertir.Click += new System.EventHandler(this.BTConvertir_Click);
            // 
            // textBoxInfija
            // 
            this.textBoxInfija.Location = new System.Drawing.Point(12, 119);
            this.textBoxInfija.Name = "textBoxInfija";
            this.textBoxInfija.ReadOnly = true;
            this.textBoxInfija.Size = new System.Drawing.Size(100, 20);
            this.textBoxInfija.TabIndex = 12;
            this.textBoxInfija.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPrefija
            // 
            this.textBoxPrefija.Location = new System.Drawing.Point(108, 38);
            this.textBoxPrefija.Name = "textBoxPrefija";
            this.textBoxPrefija.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrefija.TabIndex = 11;
            this.textBoxPrefija.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(127, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Prefija";
            // 
            // Conversiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(316, 198);
            this.Controls.Add(this.BTReset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPosfija);
            this.Controls.Add(this.BTConvertir);
            this.Controls.Add(this.textBoxInfija);
            this.Controls.Add(this.textBoxPrefija);
            this.Controls.Add(this.label1);
            this.Name = "Conversiones";
            this.Text = "Conversiones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPosfija;
        private System.Windows.Forms.Button BTConvertir;
        private System.Windows.Forms.TextBox textBoxInfija;
        private System.Windows.Forms.TextBox textBoxPrefija;
        private System.Windows.Forms.Label label1;
    }
}