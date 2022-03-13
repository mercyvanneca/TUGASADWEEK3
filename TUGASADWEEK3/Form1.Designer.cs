namespace TUGASADWEEK3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_InputData = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Button_Process = new System.Windows.Forms.Button();
            this.Label_Empty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_InputData
            // 
            this.Label_InputData.AutoSize = true;
            this.Label_InputData.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_InputData.Location = new System.Drawing.Point(12, 9);
            this.Label_InputData.Name = "Label_InputData";
            this.Label_InputData.Size = new System.Drawing.Size(81, 20);
            this.Label_InputData.TabIndex = 0;
            this.Label_InputData.Text = "Input Data";
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 32);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(285, 23);
            this.TextBox.TabIndex = 1;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Button_Process
            // 
            this.Button_Process.Location = new System.Drawing.Point(16, 78);
            this.Button_Process.Name = "Button_Process";
            this.Button_Process.Size = new System.Drawing.Size(75, 23);
            this.Button_Process.TabIndex = 2;
            this.Button_Process.Text = "Process";
            this.Button_Process.UseVisualStyleBackColor = true;
            this.Button_Process.Click += new System.EventHandler(this.Button_Process_Click);
            // 
            // Label_Empty
            // 
            this.Label_Empty.AutoSize = true;
            this.Label_Empty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Empty.Location = new System.Drawing.Point(16, 124);
            this.Label_Empty.Name = "Label_Empty";
            this.Label_Empty.Size = new System.Drawing.Size(68, 21);
            this.Label_Empty.TabIndex = 3;
            this.Label_Empty.Text = "[EMPTY]";
            this.Label_Empty.Click += new System.EventHandler(this.Label_Empty_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 224);
            this.Controls.Add(this.Label_Empty);
            this.Controls.Add(this.Button_Process);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Label_InputData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_InputData;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Button_Process;
        private System.Windows.Forms.Label Label_Empty;
    }
}
