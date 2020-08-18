namespace Aprobacion_de_una_materia
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
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.txtnota4 = new System.Windows.Forms.TextBox();
            this.txtnota5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F);
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese nota 1:";
            // 
            // txtnota1
            // 
            this.txtnota1.Font = new System.Drawing.Font("Arial", 16F);
            this.txtnota1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtnota1.Location = new System.Drawing.Point(190, 38);
            this.txtnota1.MaxLength = 5;
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(52, 32);
            this.txtnota1.TabIndex = 1;
            this.txtnota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnota1_KeyPress_1);
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnborrar.Font = new System.Drawing.Font("Arial", 16F);
            this.btnborrar.ForeColor = System.Drawing.Color.White;
            this.btnborrar.Location = new System.Drawing.Point(28, 341);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(136, 53);
            this.btnborrar.TabIndex = 3;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnconsultar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnconsultar.ForeColor = System.Drawing.Color.White;
            this.btnconsultar.Location = new System.Drawing.Point(28, 281);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(136, 54);
            this.btnconsultar.TabIndex = 4;
            this.btnconsultar.Text = "Consulta aqui tu promedio ";
            this.btnconsultar.UseVisualStyleBackColor = false;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F);
            this.label2.Location = new System.Drawing.Point(23, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese nota 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F);
            this.label3.Location = new System.Drawing.Point(23, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese nota 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16F);
            this.label4.Location = new System.Drawing.Point(23, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingrese nota 4:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16F);
            this.label5.Location = new System.Drawing.Point(23, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ingrese nota 5:";
            // 
            // txtnota2
            // 
            this.txtnota2.Font = new System.Drawing.Font("Arial", 16F);
            this.txtnota2.Location = new System.Drawing.Point(190, 86);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(52, 32);
            this.txtnota2.TabIndex = 9;
            this.txtnota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnota2_KeyPress);
            // 
            // txtnota3
            // 
            this.txtnota3.Font = new System.Drawing.Font("Arial", 16F);
            this.txtnota3.Location = new System.Drawing.Point(190, 134);
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(52, 32);
            this.txtnota3.TabIndex = 10;
            this.txtnota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnota3_KeyPress);
            // 
            // txtnota4
            // 
            this.txtnota4.Font = new System.Drawing.Font("Arial", 16F);
            this.txtnota4.Location = new System.Drawing.Point(190, 187);
            this.txtnota4.Name = "txtnota4";
            this.txtnota4.Size = new System.Drawing.Size(52, 32);
            this.txtnota4.TabIndex = 11;
            this.txtnota4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnota4_KeyPress);
            // 
            // txtnota5
            // 
            this.txtnota5.Font = new System.Drawing.Font("Arial", 16F);
            this.txtnota5.Location = new System.Drawing.Point(190, 235);
            this.txtnota5.Name = "txtnota5";
            this.txtnota5.Size = new System.Drawing.Size(52, 32);
            this.txtnota5.TabIndex = 12;
            this.txtnota5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnota5_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 16F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(170, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tu promedio es:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 16F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(345, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "resultado";
            this.label7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 413);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnota5);
            this.Controls.Add(this.txtnota4);
            this.Controls.Add(this.txtnota3);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.txtnota1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aprobacion de una materia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.TextBox txtnota3;
        private System.Windows.Forms.TextBox txtnota4;
        private System.Windows.Forms.TextBox txtnota5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

