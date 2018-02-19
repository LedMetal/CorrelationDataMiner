namespace CorrelationDataMiner
{
    partial class FormMain
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculateIntervals = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.gbRequirements = new System.Windows.Forms.GroupBox();
            this.nudSignalTwo = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudSignalOne = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudCorrelation = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbFilesSelection = new System.Windows.Forms.GroupBox();
            this.btnBrowseSig2 = new System.Windows.Forms.Button();
            this.tbSig2Path = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseSig1 = new System.Windows.Forms.Button();
            this.tbSig1Path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseCorr = new System.Windows.Forms.Button();
            this.tbCorrPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbRequirements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSignalTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSignalOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCorrelation)).BeginInit();
            this.gbFilesSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Salmon;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(14, 433);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 40);
            this.btnExit.TabIndex = 41;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnCalculateIntervals
            // 
            this.btnCalculateIntervals.BackColor = System.Drawing.Color.LightGreen;
            this.btnCalculateIntervals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateIntervals.Location = new System.Drawing.Point(257, 433);
            this.btnCalculateIntervals.Name = "btnCalculateIntervals";
            this.btnCalculateIntervals.Size = new System.Drawing.Size(159, 40);
            this.btnCalculateIntervals.TabIndex = 40;
            this.btnCalculateIntervals.Text = "Calculate Intervals";
            this.btnCalculateIntervals.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(11, 407);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(238, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "*Reminder: Top 100% would mean no restrictions";
            // 
            // gbRequirements
            // 
            this.gbRequirements.Controls.Add(this.nudSignalTwo);
            this.gbRequirements.Controls.Add(this.label9);
            this.gbRequirements.Controls.Add(this.label10);
            this.gbRequirements.Controls.Add(this.nudSignalOne);
            this.gbRequirements.Controls.Add(this.label7);
            this.gbRequirements.Controls.Add(this.label8);
            this.gbRequirements.Controls.Add(this.nudCorrelation);
            this.gbRequirements.Controls.Add(this.label6);
            this.gbRequirements.Controls.Add(this.label5);
            this.gbRequirements.Location = new System.Drawing.Point(14, 283);
            this.gbRequirements.Name = "gbRequirements";
            this.gbRequirements.Size = new System.Drawing.Size(400, 121);
            this.gbRequirements.TabIndex = 38;
            this.gbRequirements.TabStop = false;
            this.gbRequirements.Text = "2. Requirements";
            // 
            // nudSignalTwo
            // 
            this.nudSignalTwo.Location = new System.Drawing.Point(90, 80);
            this.nudSignalTwo.Name = "nudSignalTwo";
            this.nudSignalTwo.Size = new System.Drawing.Size(60, 20);
            this.nudSignalTwo.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Top";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(156, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Percentile of Signal 2 Data";
            // 
            // nudSignalOne
            // 
            this.nudSignalOne.Location = new System.Drawing.Point(90, 54);
            this.nudSignalOne.Name = "nudSignalOne";
            this.nudSignalOne.Size = new System.Drawing.Size(60, 20);
            this.nudSignalOne.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Top";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(156, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Percentile of Signal 1 Data";
            // 
            // nudCorrelation
            // 
            this.nudCorrelation.Location = new System.Drawing.Point(90, 28);
            this.nudCorrelation.Name = "nudCorrelation";
            this.nudCorrelation.Size = new System.Drawing.Size(60, 20);
            this.nudCorrelation.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Top";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Percentile of Correlation Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 31);
            this.label4.TabIndex = 37;
            this.label4.Text = "Correlation Data Miner";
            // 
            // gbFilesSelection
            // 
            this.gbFilesSelection.Controls.Add(this.btnBrowseSig2);
            this.gbFilesSelection.Controls.Add(this.tbSig2Path);
            this.gbFilesSelection.Controls.Add(this.label3);
            this.gbFilesSelection.Controls.Add(this.btnBrowseSig1);
            this.gbFilesSelection.Controls.Add(this.tbSig1Path);
            this.gbFilesSelection.Controls.Add(this.label2);
            this.gbFilesSelection.Controls.Add(this.btnBrowseCorr);
            this.gbFilesSelection.Controls.Add(this.tbCorrPath);
            this.gbFilesSelection.Controls.Add(this.label1);
            this.gbFilesSelection.Location = new System.Drawing.Point(14, 65);
            this.gbFilesSelection.Name = "gbFilesSelection";
            this.gbFilesSelection.Size = new System.Drawing.Size(402, 212);
            this.gbFilesSelection.TabIndex = 36;
            this.gbFilesSelection.TabStop = false;
            this.gbFilesSelection.Text = "1. Files Selection";
            // 
            // btnBrowseSig2
            // 
            this.btnBrowseSig2.Location = new System.Drawing.Point(201, 138);
            this.btnBrowseSig2.Name = "btnBrowseSig2";
            this.btnBrowseSig2.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSig2.TabIndex = 8;
            this.btnBrowseSig2.Text = "Browse";
            this.btnBrowseSig2.UseVisualStyleBackColor = true;
            // 
            // tbSig2Path
            // 
            this.tbSig2Path.Location = new System.Drawing.Point(47, 167);
            this.tbSig2Path.Name = "tbSig2Path";
            this.tbSig2Path.ReadOnly = true;
            this.tbSig2Path.Size = new System.Drawing.Size(309, 20);
            this.tbSig2Path.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Signal 2 Motion:";
            // 
            // btnBrowseSig1
            // 
            this.btnBrowseSig1.Location = new System.Drawing.Point(201, 83);
            this.btnBrowseSig1.Name = "btnBrowseSig1";
            this.btnBrowseSig1.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSig1.TabIndex = 5;
            this.btnBrowseSig1.Text = "Browse";
            this.btnBrowseSig1.UseVisualStyleBackColor = true;
            this.btnBrowseSig1.Click += new System.EventHandler(this.btnBrowseSig1_Click);
            // 
            // tbSig1Path
            // 
            this.tbSig1Path.Location = new System.Drawing.Point(47, 112);
            this.tbSig1Path.Name = "tbSig1Path";
            this.tbSig1Path.ReadOnly = true;
            this.tbSig1Path.Size = new System.Drawing.Size(309, 20);
            this.tbSig1Path.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Signal 1 Motion:";
            // 
            // btnBrowseCorr
            // 
            this.btnBrowseCorr.Location = new System.Drawing.Point(201, 28);
            this.btnBrowseCorr.Name = "btnBrowseCorr";
            this.btnBrowseCorr.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseCorr.TabIndex = 2;
            this.btnBrowseCorr.Text = "Browse";
            this.btnBrowseCorr.UseVisualStyleBackColor = true;
            this.btnBrowseCorr.Click += new System.EventHandler(this.btnBrowseCorr_Click);
            // 
            // tbCorrPath
            // 
            this.tbCorrPath.Location = new System.Drawing.Point(47, 57);
            this.tbCorrPath.Name = "tbCorrPath";
            this.tbCorrPath.ReadOnly = true;
            this.tbCorrPath.Size = new System.Drawing.Size(309, 20);
            this.tbCorrPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correlation Signal:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 489);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateIntervals);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.gbRequirements);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbFilesSelection);
            this.Name = "FormMain";
            this.Text = "Correlation Data Miner";
            this.gbRequirements.ResumeLayout(false);
            this.gbRequirements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSignalTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSignalOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCorrelation)).EndInit();
            this.gbFilesSelection.ResumeLayout(false);
            this.gbFilesSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculateIntervals;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox gbRequirements;
        private System.Windows.Forms.NumericUpDown nudSignalTwo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudSignalOne;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudCorrelation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbFilesSelection;
        private System.Windows.Forms.Button btnBrowseSig2;
        private System.Windows.Forms.TextBox tbSig2Path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseSig1;
        private System.Windows.Forms.TextBox tbSig1Path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseCorr;
        private System.Windows.Forms.TextBox tbCorrPath;
        private System.Windows.Forms.Label label1;
    }
}

