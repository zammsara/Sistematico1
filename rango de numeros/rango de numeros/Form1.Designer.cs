namespace rango_de_numeros
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.btnShowNumbers = new System.Windows.Forms.Button();
            this.ltsNumbers = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero2";
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(109, 22);
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(44, 20);
            this.numX.TabIndex = 3;
            // 
            // numY
            // 
            this.numY.Location = new System.Drawing.Point(112, 66);
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(41, 20);
            this.numY.TabIndex = 4;
            // 
            // btnShowNumbers
            // 
            this.btnShowNumbers.Image = global::rango_de_numeros.Properties.Resources.calculadora;
            this.btnShowNumbers.Location = new System.Drawing.Point(194, 12);
            this.btnShowNumbers.Name = "btnShowNumbers";
            this.btnShowNumbers.Size = new System.Drawing.Size(82, 64);
            this.btnShowNumbers.TabIndex = 5;
            this.btnShowNumbers.UseVisualStyleBackColor = true;
            this.btnShowNumbers.Click += new System.EventHandler(this.btnShowNumbers_Click);
            // 
            // ltsNumbers
            // 
            this.ltsNumbers.FormattingEnabled = true;
            this.ltsNumbers.Location = new System.Drawing.Point(25, 116);
            this.ltsNumbers.Name = "ltsNumbers";
            this.ltsNumbers.Size = new System.Drawing.Size(153, 199);
            this.ltsNumbers.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 354);
            this.Controls.Add(this.ltsNumbers);
            this.Controls.Add(this.btnShowNumbers);
            this.Controls.Add(this.numY);
            this.Controls.Add(this.numX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rango de numeros ";
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.Button btnShowNumbers;
        private System.Windows.Forms.ListBox ltsNumbers;
    }
}

