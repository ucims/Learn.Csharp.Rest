namespace CSharpRestExample
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
            this.textRequestURL = new System.Windows.Forms.TextBox();
            this.textResponse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonMaju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textRequestURL
            // 
            this.textRequestURL.Location = new System.Drawing.Point(12, 36);
            this.textRequestURL.Name = "textRequestURL";
            this.textRequestURL.Size = new System.Drawing.Size(339, 20);
            this.textRequestURL.TabIndex = 0;
            // 
            // textResponse
            // 
            this.textResponse.Location = new System.Drawing.Point(12, 111);
            this.textResponse.Multiline = true;
            this.textResponse.Name = "textResponse";
            this.textResponse.Size = new System.Drawing.Size(339, 169);
            this.textResponse.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Request URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Response";
            // 
            // buttonMaju
            // 
            this.buttonMaju.Location = new System.Drawing.Point(12, 63);
            this.buttonMaju.Name = "buttonMaju";
            this.buttonMaju.Size = new System.Drawing.Size(339, 23);
            this.buttonMaju.TabIndex = 2;
            this.buttonMaju.Text = "Maju";
            this.buttonMaju.UseVisualStyleBackColor = true;
            this.buttonMaju.Click += new System.EventHandler(this.buttonMaju_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 292);
            this.Controls.Add(this.buttonMaju);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textResponse);
            this.Controls.Add(this.textRequestURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textRequestURL;
        private System.Windows.Forms.TextBox textResponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonMaju;
    }
}

