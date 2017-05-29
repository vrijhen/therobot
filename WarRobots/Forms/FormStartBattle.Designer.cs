namespace WarRobots
{
    partial class WarRobots
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
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRobotA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRobotB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(158, 144);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Robot A";
            // 
            // txtRobotA
            // 
            this.txtRobotA.Location = new System.Drawing.Point(158, 27);
            this.txtRobotA.Name = "txtRobotA";
            this.txtRobotA.Size = new System.Drawing.Size(459, 22);
            this.txtRobotA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Robot B";
            // 
            // txtRobotB
            // 
            this.txtRobotB.Location = new System.Drawing.Point(158, 75);
            this.txtRobotB.Name = "txtRobotB";
            this.txtRobotB.Size = new System.Drawing.Size(459, 22);
            this.txtRobotB.TabIndex = 4;
            // 
            // WarRobots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 223);
            this.Controls.Add(this.txtRobotB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRobotA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "WarRobots";
            this.Text = "FormStartBattle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRobotA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRobotB;
    }
}

