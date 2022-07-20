namespace Week_1_Activity_2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userInputMiles = new System.Windows.Forms.TextBox();
            this.beginConversionButton = new System.Windows.Forms.Button();
            this.kilometers = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convert Miles to Kilometers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Miles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kilometers:";
            // 
            // userInputMiles
            // 
            this.userInputMiles.Location = new System.Drawing.Point(130, 106);
            this.userInputMiles.Name = "userInputMiles";
            this.userInputMiles.Size = new System.Drawing.Size(134, 22);
            this.userInputMiles.TabIndex = 3;
            // 
            // beginConversionButton
            // 
            this.beginConversionButton.Location = new System.Drawing.Point(47, 249);
            this.beginConversionButton.Name = "beginConversionButton";
            this.beginConversionButton.Size = new System.Drawing.Size(92, 31);
            this.beginConversionButton.TabIndex = 5;
            this.beginConversionButton.Text = "Convert";
            this.beginConversionButton.UseVisualStyleBackColor = true;
            this.beginConversionButton.Click += new System.EventHandler(this.beginConversionButton_Click);
            // 
            // kilometers
            // 
            this.kilometers.AutoSize = true;
            this.kilometers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kilometers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kilometers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilometers.Location = new System.Drawing.Point(130, 187);
            this.kilometers.Name = "kilometers";
            this.kilometers.Size = new System.Drawing.Size(130, 20);
            this.kilometers.TabIndex = 6;
            this.kilometers.Text = "                              ";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(177, 249);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(99, 31);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(107, 308);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(103, 30);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 350);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.kilometers);
            this.Controls.Add(this.beginConversionButton);
            this.Controls.Add(this.userInputMiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Miles to Kilometer Conversion App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userInputMiles;
        private System.Windows.Forms.Button beginConversionButton;
        private System.Windows.Forms.Label kilometers;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button closeButton;
    }
}

