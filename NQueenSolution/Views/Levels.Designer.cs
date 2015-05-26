namespace NQueenSolution
{
    partial class Levels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Levels));
            this.rbtn5x5 = new System.Windows.Forms.RadioButton();
            this.rbtn6x6 = new System.Windows.Forms.RadioButton();
            this.rbtn7x7 = new System.Windows.Forms.RadioButton();
            this.rbtn8x8 = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtn5x5
            // 
            this.rbtn5x5.AutoSize = true;
            this.rbtn5x5.BackColor = System.Drawing.Color.Transparent;
            this.rbtn5x5.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn5x5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbtn5x5.Location = new System.Drawing.Point(104, 62);
            this.rbtn5x5.Name = "rbtn5x5";
            this.rbtn5x5.Size = new System.Drawing.Size(77, 29);
            this.rbtn5x5.TabIndex = 0;
            this.rbtn5x5.TabStop = true;
            this.rbtn5x5.Text = "5 X 5";
            this.rbtn5x5.UseVisualStyleBackColor = false;
            // 
            // rbtn6x6
            // 
            this.rbtn6x6.AutoSize = true;
            this.rbtn6x6.BackColor = System.Drawing.Color.Transparent;
            this.rbtn6x6.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn6x6.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbtn6x6.Location = new System.Drawing.Point(104, 95);
            this.rbtn6x6.Name = "rbtn6x6";
            this.rbtn6x6.Size = new System.Drawing.Size(77, 29);
            this.rbtn6x6.TabIndex = 1;
            this.rbtn6x6.TabStop = true;
            this.rbtn6x6.Text = "6 X 6";
            this.rbtn6x6.UseVisualStyleBackColor = false;
            // 
            // rbtn7x7
            // 
            this.rbtn7x7.AutoSize = true;
            this.rbtn7x7.BackColor = System.Drawing.Color.Transparent;
            this.rbtn7x7.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn7x7.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbtn7x7.Location = new System.Drawing.Point(104, 127);
            this.rbtn7x7.Name = "rbtn7x7";
            this.rbtn7x7.Size = new System.Drawing.Size(82, 29);
            this.rbtn7x7.TabIndex = 2;
            this.rbtn7x7.TabStop = true;
            this.rbtn7x7.Text = "7 x 7 ";
            this.rbtn7x7.UseVisualStyleBackColor = false;
            // 
            // rbtn8x8
            // 
            this.rbtn8x8.AutoSize = true;
            this.rbtn8x8.BackColor = System.Drawing.Color.Transparent;
            this.rbtn8x8.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn8x8.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbtn8x8.Location = new System.Drawing.Point(104, 162);
            this.rbtn8x8.Name = "rbtn8x8";
            this.rbtn8x8.Size = new System.Drawing.Size(77, 29);
            this.rbtn8x8.TabIndex = 3;
            this.rbtn8x8.TabStop = true;
            this.rbtn8x8.Text = "8 x 8";
            this.rbtn8x8.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(71, 207);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 27);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Levels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NQueenSolution.Properties.Resources.boardLevels;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rbtn8x8);
            this.Controls.Add(this.rbtn7x7);
            this.Controls.Add(this.rbtn6x6);
            this.Controls.Add(this.rbtn5x5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Levels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Levels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn5x5;
        private System.Windows.Forms.RadioButton rbtn6x6;
        private System.Windows.Forms.RadioButton rbtn7x7;
        private System.Windows.Forms.RadioButton rbtn8x8;
        private System.Windows.Forms.Button btnStart;
    }
}