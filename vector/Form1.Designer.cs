namespace vector
{
    partial class Form1
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
            this.btn_plano = new System.Windows.Forms.Button();
            this.btn_vector = new System.Windows.Forms.Button();
            this.btn_vectorabjo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_plano
            // 
            this.btn_plano.Location = new System.Drawing.Point(12, 12);
            this.btn_plano.Name = "btn_plano";
            this.btn_plano.Size = new System.Drawing.Size(95, 23);
            this.btn_plano.TabIndex = 0;
            this.btn_plano.Text = "Dibujar plano";
            this.btn_plano.UseVisualStyleBackColor = true;
            this.btn_plano.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_vector
            // 
            this.btn_vector.Location = new System.Drawing.Point(12, 41);
            this.btn_vector.Name = "btn_vector";
            this.btn_vector.Size = new System.Drawing.Size(95, 23);
            this.btn_vector.TabIndex = 1;
            this.btn_vector.Text = "Dibujar vector";
            this.btn_vector.UseVisualStyleBackColor = true;
            this.btn_vector.Click += new System.EventHandler(this.btn_vector_Click);
            // 
            // btn_vectorabjo
            // 
            this.btn_vectorabjo.Location = new System.Drawing.Point(12, 70);
            this.btn_vectorabjo.Name = "btn_vectorabjo";
            this.btn_vectorabjo.Size = new System.Drawing.Size(95, 23);
            this.btn_vectorabjo.TabIndex = 2;
            this.btn_vectorabjo.Text = "Dibujar vector";
            this.btn_vectorabjo.UseVisualStyleBackColor = true;
            this.btn_vectorabjo.Click += new System.EventHandler(this.btn_vectorabjo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 447);
            this.Controls.Add(this.btn_vectorabjo);
            this.Controls.Add(this.btn_vector);
            this.Controls.Add(this.btn_plano);
            this.Name = "Form1";
            this.Text = "Vector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_plano;
        private System.Windows.Forms.Button btn_vector;
        private System.Windows.Forms.Button btn_vectorabjo;
    }
}

