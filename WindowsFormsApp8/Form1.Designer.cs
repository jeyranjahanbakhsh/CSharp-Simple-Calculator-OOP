namespace WindowsFormsApp8
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
            this.txtsum = new System.Windows.Forms.Button();
            this.menha = new System.Windows.Forms.Button();
            this.taghsim = new System.Windows.Forms.Button();
            this.zarb = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsum
            // 
            this.txtsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsum.Location = new System.Drawing.Point(131, 105);
            this.txtsum.Name = "txtsum";
            this.txtsum.Size = new System.Drawing.Size(75, 35);
            this.txtsum.TabIndex = 0;
            this.txtsum.Text = "+";
            this.txtsum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtsum.UseVisualStyleBackColor = true;
            this.txtsum.Click += new System.EventHandler(this.txtsum_Click_1);
            // 
            // menha
            // 
            this.menha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menha.Location = new System.Drawing.Point(38, 105);
            this.menha.Name = "menha";
            this.menha.Size = new System.Drawing.Size(75, 35);
            this.menha.TabIndex = 1;
            this.menha.Text = "-";
            this.menha.UseVisualStyleBackColor = true;
            this.menha.Click += new System.EventHandler(this.menha_Click);
            // 
            // taghsim
            // 
            this.taghsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taghsim.Location = new System.Drawing.Point(131, 58);
            this.taghsim.Name = "taghsim";
            this.taghsim.Size = new System.Drawing.Size(75, 35);
            this.taghsim.TabIndex = 2;
            this.taghsim.Text = "/";
            this.taghsim.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.taghsim.UseVisualStyleBackColor = true;
            this.taghsim.Click += new System.EventHandler(this.taghsim_Click);
            // 
            // zarb
            // 
            this.zarb.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zarb.Location = new System.Drawing.Point(38, 58);
            this.zarb.Name = "zarb";
            this.zarb.Size = new System.Drawing.Size(75, 35);
            this.zarb.TabIndex = 3;
            this.zarb.Text = "*";
            this.zarb.UseVisualStyleBackColor = true;
            this.zarb.Click += new System.EventHandler(this.zarb_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(75, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 194);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.zarb);
            this.Controls.Add(this.taghsim);
            this.Controls.Add(this.menha);
            this.Controls.Add(this.txtsum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtsum;
        private System.Windows.Forms.Button menha;
        private System.Windows.Forms.Button taghsim;
        private System.Windows.Forms.Button zarb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}

