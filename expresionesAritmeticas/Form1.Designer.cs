﻿namespace expresionesAritmeticas
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAritmetica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSolucion = new System.Windows.Forms.TextBox();
            this.btnresolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAritmetica
            // 
            this.txtAritmetica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAritmetica.Location = new System.Drawing.Point(31, 53);
            this.txtAritmetica.Name = "txtAritmetica";
            this.txtAritmetica.Size = new System.Drawing.Size(236, 30);
            this.txtAritmetica.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa expresion aritmetica";
            // 
            // txtSolucion
            // 
            this.txtSolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolucion.Location = new System.Drawing.Point(31, 200);
            this.txtSolucion.Name = "txtSolucion";
            this.txtSolucion.Size = new System.Drawing.Size(236, 30);
            this.txtSolucion.TabIndex = 2;
            // 
            // btnresolver
            // 
            this.btnresolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresolver.Location = new System.Drawing.Point(40, 135);
            this.btnresolver.Name = "btnresolver";
            this.btnresolver.Size = new System.Drawing.Size(227, 32);
            this.btnresolver.TabIndex = 3;
            this.btnresolver.Text = "Resolver";
            this.btnresolver.UseVisualStyleBackColor = true;
            this.btnresolver.Click += new System.EventHandler(this.btnresolver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 258);
            this.Controls.Add(this.btnresolver);
            this.Controls.Add(this.txtSolucion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAritmetica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAritmetica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSolucion;
        private System.Windows.Forms.Button btnresolver;
    }
}

