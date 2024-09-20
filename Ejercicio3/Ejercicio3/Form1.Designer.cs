namespace Ejercicio3
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
            this.tbMatriz1 = new System.Windows.Forms.TextBox();
            this.tbMatriz2 = new System.Windows.Forms.TextBox();
            this.btnMatriz1 = new System.Windows.Forms.Button();
            this.btnMatriz2 = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escribe los datos de la primer matrz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escribe los datos de ls segunda matriz:";
            // 
            // tbMatriz1
            // 
            this.tbMatriz1.Location = new System.Drawing.Point(204, 28);
            this.tbMatriz1.Name = "tbMatriz1";
            this.tbMatriz1.Size = new System.Drawing.Size(125, 20);
            this.tbMatriz1.TabIndex = 2;
            // 
            // tbMatriz2
            // 
            this.tbMatriz2.Location = new System.Drawing.Point(218, 64);
            this.tbMatriz2.Name = "tbMatriz2";
            this.tbMatriz2.Size = new System.Drawing.Size(111, 20);
            this.tbMatriz2.TabIndex = 3;
            // 
            // btnMatriz1
            // 
            this.btnMatriz1.Location = new System.Drawing.Point(354, 19);
            this.btnMatriz1.Name = "btnMatriz1";
            this.btnMatriz1.Size = new System.Drawing.Size(101, 36);
            this.btnMatriz1.TabIndex = 4;
            this.btnMatriz1.Text = "Guardar dato";
            this.btnMatriz1.UseVisualStyleBackColor = true;
            this.btnMatriz1.Click += new System.EventHandler(this.btnMatriz1_Click);
            // 
            // btnMatriz2
            // 
            this.btnMatriz2.Location = new System.Drawing.Point(354, 61);
            this.btnMatriz2.Name = "btnMatriz2";
            this.btnMatriz2.Size = new System.Drawing.Size(93, 34);
            this.btnMatriz2.TabIndex = 5;
            this.btnMatriz2.Text = "Guardar dato";
            this.btnMatriz2.UseVisualStyleBackColor = true;
            this.btnMatriz2.Click += new System.EventHandler(this.btnMatriz2_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(162, 131);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(179, 39);
            this.btnSuma.TabIndex = 6;
            this.btnSuma.Text = "Calcular Suma de las matrices";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 168);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnMatriz2);
            this.Controls.Add(this.btnMatriz1);
            this.Controls.Add(this.tbMatriz2);
            this.Controls.Add(this.tbMatriz1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMatriz1;
        private System.Windows.Forms.TextBox tbMatriz2;
        private System.Windows.Forms.Button btnMatriz1;
        private System.Windows.Forms.Button btnMatriz2;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

