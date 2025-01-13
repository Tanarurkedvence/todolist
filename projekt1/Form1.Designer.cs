namespace projekt1
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
            this.input = new System.Windows.Forms.TextBox();
            this.gomb = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(71, 54);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(219, 20);
            this.input.TabIndex = 0;
            // 
            // gomb
            // 
            this.gomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gomb.Location = new System.Drawing.Point(323, 54);
            this.gomb.Name = "gomb";
            this.gomb.Size = new System.Drawing.Size(60, 37);
            this.gomb.TabIndex = 1;
            this.gomb.Text = "+";
            this.gomb.UseVisualStyleBackColor = true;
            this.gomb.Click += new System.EventHandler(this.gomb_Click);
            // 
            // content
            // 
            this.content.AutoScroll = true;
            this.content.Location = new System.Drawing.Point(71, 108);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(219, 486);
            this.content.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 631);
            this.Controls.Add(this.content);
            this.Controls.Add(this.gomb);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button gomb;
        private System.Windows.Forms.Panel content;
    }
}

