namespace Array_Dengan_Input
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBNama = new System.Windows.Forms.TextBox();
            this.btInput = new System.Windows.Forms.Button();
            this.lBNama = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // tBNama
            // 
            this.tBNama.Location = new System.Drawing.Point(54, 10);
            this.tBNama.Name = "tBNama";
            this.tBNama.Size = new System.Drawing.Size(175, 20);
            this.tBNama.TabIndex = 1;
            // 
            // btInput
            // 
            this.btInput.Location = new System.Drawing.Point(235, 8);
            this.btInput.Name = "btInput";
            this.btInput.Size = new System.Drawing.Size(75, 23);
            this.btInput.TabIndex = 2;
            this.btInput.Text = "Input";
            this.btInput.UseVisualStyleBackColor = true;
            this.btInput.Click += new System.EventHandler(this.btInput_Click);
            // 
            // lBNama
            // 
            this.lBNama.FormattingEnabled = true;
            this.lBNama.Location = new System.Drawing.Point(16, 48);
            this.lBNama.Name = "lBNama";
            this.lBNama.Size = new System.Drawing.Size(294, 160);
            this.lBNama.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 221);
            this.Controls.Add(this.lBNama);
            this.Controls.Add(this.btInput);
            this.Controls.Add(this.tBNama);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Array Dengan Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBNama;
        private System.Windows.Forms.Button btInput;
        private System.Windows.Forms.ListBox lBNama;
    }
}

