namespace Pedido_de_Chefellas
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
            this.TBCant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTIniciar = new System.Windows.Forms.Button();
            this.PNMenu = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTCasoColaC = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BTCasoColaS = new System.Windows.Forms.Button();
            this.BTConversiones = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BTCasoPila = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PNTamaño = new System.Windows.Forms.Panel();
            this.BTCasoListEnlazadaS = new System.Windows.Forms.Button();
            this.PNMenu.SuspendLayout();
            this.PNTamaño.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBCant
            // 
            this.TBCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCant.Location = new System.Drawing.Point(76, 144);
            this.TBCant.Name = "TBCant";
            this.TBCant.Size = new System.Drawing.Size(53, 22);
            this.TBCant.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el tamaño de la estructura";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tamaño";
            // 
            // BTIniciar
            // 
            this.BTIniciar.Location = new System.Drawing.Point(57, 172);
            this.BTIniciar.Name = "BTIniciar";
            this.BTIniciar.Size = new System.Drawing.Size(90, 25);
            this.BTIniciar.TabIndex = 13;
            this.BTIniciar.Text = "Iniciar";
            this.BTIniciar.UseVisualStyleBackColor = true;
            this.BTIniciar.Click += new System.EventHandler(this.BTMostrarRegistros_Click);
            // 
            // PNMenu
            // 
            this.PNMenu.Controls.Add(this.BTCasoListEnlazadaS);
            this.PNMenu.Controls.Add(this.label8);
            this.PNMenu.Controls.Add(this.label6);
            this.PNMenu.Controls.Add(this.label7);
            this.PNMenu.Controls.Add(this.BTCasoColaC);
            this.PNMenu.Controls.Add(this.label5);
            this.PNMenu.Controls.Add(this.BTCasoColaS);
            this.PNMenu.Controls.Add(this.BTConversiones);
            this.PNMenu.Controls.Add(this.label4);
            this.PNMenu.Controls.Add(this.BTCasoPila);
            this.PNMenu.Controls.Add(this.label3);
            this.PNMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNMenu.Location = new System.Drawing.Point(0, 0);
            this.PNMenu.Name = "PNMenu";
            this.PNMenu.Size = new System.Drawing.Size(216, 281);
            this.PNMenu.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(47, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Listas Enlazadas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cola Simple";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(115, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cola Circular";
            // 
            // BTCasoColaC
            // 
            this.BTCasoColaC.Location = new System.Drawing.Point(111, 172);
            this.BTCasoColaC.Name = "BTCasoColaC";
            this.BTCasoColaC.Size = new System.Drawing.Size(90, 25);
            this.BTCasoColaC.TabIndex = 18;
            this.BTCasoColaC.Text = "Chefellas";
            this.BTCasoColaC.UseVisualStyleBackColor = true;
            this.BTCasoColaC.Click += new System.EventHandler(this.BTCasoColaC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(85, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Colas";
            // 
            // BTCasoColaS
            // 
            this.BTCasoColaS.Location = new System.Drawing.Point(15, 172);
            this.BTCasoColaS.Name = "BTCasoColaS";
            this.BTCasoColaS.Size = new System.Drawing.Size(90, 25);
            this.BTCasoColaS.TabIndex = 17;
            this.BTCasoColaS.Text = "Chefellas";
            this.BTCasoColaS.UseVisualStyleBackColor = true;
            this.BTCasoColaS.Click += new System.EventHandler(this.BTCasoColaS_Click);
            // 
            // BTConversiones
            // 
            this.BTConversiones.Location = new System.Drawing.Point(111, 88);
            this.BTConversiones.Name = "BTConversiones";
            this.BTConversiones.Size = new System.Drawing.Size(90, 25);
            this.BTConversiones.TabIndex = 16;
            this.BTConversiones.Text = "Conversión";
            this.BTConversiones.UseVisualStyleBackColor = true;
            this.BTConversiones.Click += new System.EventHandler(this.BTConversiones_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(90, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Pilas";
            // 
            // BTCasoPila
            // 
            this.BTCasoPila.Location = new System.Drawing.Point(15, 88);
            this.BTCasoPila.Name = "BTCasoPila";
            this.BTCasoPila.Size = new System.Drawing.Size(90, 25);
            this.BTCasoPila.TabIndex = 15;
            this.BTCasoPila.Text = "Chefellas";
            this.BTCasoPila.UseVisualStyleBackColor = true;
            this.BTCasoPila.Click += new System.EventHandler(this.BTCasoPila_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(71, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Menu";
            // 
            // PNTamaño
            // 
            this.PNTamaño.Controls.Add(this.label2);
            this.PNTamaño.Controls.Add(this.label1);
            this.PNTamaño.Controls.Add(this.BTIniciar);
            this.PNTamaño.Controls.Add(this.TBCant);
            this.PNTamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNTamaño.Location = new System.Drawing.Point(0, 0);
            this.PNTamaño.Name = "PNTamaño";
            this.PNTamaño.Size = new System.Drawing.Size(216, 281);
            this.PNTamaño.TabIndex = 20;
            // 
            // BTCasoListEnlazadaS
            // 
            this.BTCasoListEnlazadaS.Location = new System.Drawing.Point(61, 243);
            this.BTCasoListEnlazadaS.Name = "BTCasoListEnlazadaS";
            this.BTCasoListEnlazadaS.Size = new System.Drawing.Size(90, 25);
            this.BTCasoListEnlazadaS.TabIndex = 20;
            this.BTCasoListEnlazadaS.Text = "Chefellas";
            this.BTCasoListEnlazadaS.UseVisualStyleBackColor = true;
            this.BTCasoListEnlazadaS.Click += new System.EventHandler(this.BTCasoListEnlazadaS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(215, 280);
            this.Controls.Add(this.PNMenu);
            this.Controls.Add(this.PNTamaño);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chefellas Pedidos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PNMenu.ResumeLayout(false);
            this.PNMenu.PerformLayout();
            this.PNTamaño.ResumeLayout(false);
            this.PNTamaño.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TBCant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTIniciar;
        private System.Windows.Forms.Panel PNMenu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTCasoColaC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTCasoColaS;
        private System.Windows.Forms.Button BTConversiones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTCasoPila;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PNTamaño;
        private System.Windows.Forms.Button BTCasoListEnlazadaS;
    }
}

