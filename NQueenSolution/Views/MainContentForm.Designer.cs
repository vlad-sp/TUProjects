namespace NQueenSolution.Views
{
    partial class MainContentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainContentForm));
            this.lblQueensLeft = new System.Windows.Forms.Label();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.btnCheckSolution = new System.Windows.Forms.Button();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.gbHowToPlay = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbHowToPlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQueensLeft
            // 
            this.lblQueensLeft.AutoSize = true;
            this.lblQueensLeft.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueensLeft.Location = new System.Drawing.Point(452, 298);
            this.lblQueensLeft.Name = "lblQueensLeft";
            this.lblQueensLeft.Size = new System.Drawing.Size(94, 16);
            this.lblQueensLeft.TabIndex = 0;
            this.lblQueensLeft.Text = "Queens left:";
            // 
            // txtbox
            // 
            this.txtbox.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox.Location = new System.Drawing.Point(552, 296);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(100, 23);
            this.txtbox.TabIndex = 10;
            // 
            // btnCheckSolution
            // 
            this.btnCheckSolution.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckSolution.Location = new System.Drawing.Point(489, 331);
            this.btnCheckSolution.Name = "btnCheckSolution";
            this.btnCheckSolution.Size = new System.Drawing.Size(126, 32);
            this.btnCheckSolution.TabIndex = 2;
            this.btnCheckSolution.Text = "Check Solution";
            this.btnCheckSolution.UseVisualStyleBackColor = false;
            this.btnCheckSolution.Click += new System.EventHandler(this.btnCheckSolution_Click);
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMain.Location = new System.Drawing.Point(489, 383);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(126, 32);
            this.btnBackToMain.TabIndex = 3;
            this.btnBackToMain.Text = "Back To Start";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // gbHowToPlay
            // 
            this.gbHowToPlay.Controls.Add(this.label2);
            this.gbHowToPlay.Controls.Add(this.label1);
            this.gbHowToPlay.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHowToPlay.Location = new System.Drawing.Point(421, 40);
            this.gbHowToPlay.Name = "gbHowToPlay";
            this.gbHowToPlay.Size = new System.Drawing.Size(231, 120);
            this.gbHowToPlay.TabIndex = 75;
            this.gbHowToPlay.TabStop = false;
            this.gbHowToPlay.Text = "How To Play";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 53);
            this.label2.TabIndex = 1;
            this.label2.Text = "Double click  - remove queen from the chessboard.";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "One click - Place queen on chessboard.";
            // 
            // MainContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 442);
            this.Controls.Add(this.gbHowToPlay);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.btnCheckSolution);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.lblQueensLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainContentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "N Queen Game";
            this.gbHowToPlay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQueensLeft;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Button btnCheckSolution;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.GroupBox gbHowToPlay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}