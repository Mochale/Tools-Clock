namespace Noorani_Clock
{
    partial class SpecialyForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMinues = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnCache = new System.Windows.Forms.Button();
            this.btnMoveToList = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtResultM = new System.Windows.Forms.TextBox();
            this.txtResultH = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSecoundM = new System.Windows.Forms.TextBox();
            this.txtSecoundH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lstCache = new System.Windows.Forms.ListBox();
            this.btnClearCache = new System.Windows.Forms.Button();
            this.btnCalculateCache = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lstTimesList = new System.Windows.Forms.ListBox();
            this.btnCalculateList = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstH = new System.Windows.Forms.TextBox();
            this.txtFirstM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lstTimesList);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(576, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel1.Size = new System.Drawing.Size(230, 466);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time list";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lstCache);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel2.Size = new System.Drawing.Size(229, 466);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cache list";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(229, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.panel3.Size = new System.Drawing.Size(347, 466);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnMinues);
            this.panel4.Controls.Add(this.btnPlus);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(8, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(329, 176);
            this.panel4.TabIndex = 0;
            // 
            // btnMinues
            // 
            this.btnMinues.Location = new System.Drawing.Point(172, 144);
            this.btnMinues.Name = "btnMinues";
            this.btnMinues.Size = new System.Drawing.Size(75, 23);
            this.btnMinues.TabIndex = 2;
            this.btnMinues.Text = "Minues";
            this.btnMinues.UseVisualStyleBackColor = true;
            this.btnMinues.Click += new System.EventHandler(this.btnMinues_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(91, 144);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "Plus";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnCache);
            this.panel8.Controls.Add(this.btnMoveToList);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.txtResultM);
            this.panel8.Controls.Add(this.txtResultH);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 95);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(327, 41);
            this.panel8.TabIndex = 2;
            // 
            // btnCache
            // 
            this.btnCache.Location = new System.Drawing.Point(229, 6);
            this.btnCache.Name = "btnCache";
            this.btnCache.Size = new System.Drawing.Size(39, 23);
            this.btnCache.TabIndex = 0;
            this.btnCache.Text = "<<";
            this.btnCache.UseVisualStyleBackColor = true;
            this.btnCache.Click += new System.EventHandler(this.btnCache_Click);
            // 
            // btnMoveToList
            // 
            this.btnMoveToList.Location = new System.Drawing.Point(274, 6);
            this.btnMoveToList.Name = "btnMoveToList";
            this.btnMoveToList.Size = new System.Drawing.Size(39, 23);
            this.btnMoveToList.TabIndex = 1;
            this.btnMoveToList.Text = ">>";
            this.btnMoveToList.UseVisualStyleBackColor = true;
            this.btnMoveToList.Click += new System.EventHandler(this.btnMoveToList_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Result";
            // 
            // txtResultM
            // 
            this.txtResultM.Location = new System.Drawing.Point(172, 6);
            this.txtResultM.MaxLength = 2;
            this.txtResultM.Name = "txtResultM";
            this.txtResultM.Size = new System.Drawing.Size(46, 22);
            this.txtResultM.TabIndex = 3;
            this.txtResultM.Text = "0";
            this.txtResultM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResultM.Enter += new System.EventHandler(this.TextBoxEnter);
            this.txtResultM.Leave += new System.EventHandler(this.TextLeave);
            // 
            // txtResultH
            // 
            this.txtResultH.Location = new System.Drawing.Point(120, 6);
            this.txtResultH.MaxLength = 2;
            this.txtResultH.Name = "txtResultH";
            this.txtResultH.Size = new System.Drawing.Size(46, 22);
            this.txtResultH.TabIndex = 2;
            this.txtResultH.Text = "0";
            this.txtResultH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResultH.Enter += new System.EventHandler(this.TextBoxEnter);
            this.txtResultH.Leave += new System.EventHandler(this.TextLeave);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.txtSecoundM);
            this.panel7.Controls.Add(this.txtSecoundH);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 61);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(327, 34);
            this.panel7.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Secound Clock ";
            // 
            // txtSecoundM
            // 
            this.txtSecoundM.Location = new System.Drawing.Point(172, 6);
            this.txtSecoundM.MaxLength = 2;
            this.txtSecoundM.Name = "txtSecoundM";
            this.txtSecoundM.Size = new System.Drawing.Size(46, 22);
            this.txtSecoundM.TabIndex = 1;
            this.txtSecoundM.Text = "0";
            this.txtSecoundM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSecoundM.Enter += new System.EventHandler(this.TextBoxEnter);
            this.txtSecoundM.Leave += new System.EventHandler(this.TextLeave);
            // 
            // txtSecoundH
            // 
            this.txtSecoundH.Location = new System.Drawing.Point(120, 6);
            this.txtSecoundH.MaxLength = 2;
            this.txtSecoundH.Name = "txtSecoundH";
            this.txtSecoundH.Size = new System.Drawing.Size(46, 22);
            this.txtSecoundH.TabIndex = 0;
            this.txtSecoundH.Text = "0";
            this.txtSecoundH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSecoundH.Enter += new System.EventHandler(this.TextBoxEnter);
            this.txtSecoundH.Leave += new System.EventHandler(this.TextLeave);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(8, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Calculate times";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnCalculateCache);
            this.panel9.Controls.Add(this.btnClearCache);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(4, 425);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(219, 33);
            this.panel9.TabIndex = 4;
            // 
            // lstCache
            // 
            this.lstCache.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCache.FormattingEnabled = true;
            this.lstCache.ItemHeight = 16;
            this.lstCache.Location = new System.Drawing.Point(4, 36);
            this.lstCache.Name = "lstCache";
            this.lstCache.Size = new System.Drawing.Size(219, 389);
            this.lstCache.TabIndex = 0;
            // 
            // btnClearCache
            // 
            this.btnClearCache.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClearCache.Location = new System.Drawing.Point(0, 0);
            this.btnClearCache.Name = "btnClearCache";
            this.btnClearCache.Size = new System.Drawing.Size(110, 33);
            this.btnClearCache.TabIndex = 1;
            this.btnClearCache.Text = "Clear";
            this.btnClearCache.UseVisualStyleBackColor = true;
            this.btnClearCache.Click += new System.EventHandler(this.btnClearCache_Click);
            // 
            // btnCalculateCache
            // 
            this.btnCalculateCache.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCalculateCache.Location = new System.Drawing.Point(109, 0);
            this.btnCalculateCache.Name = "btnCalculateCache";
            this.btnCalculateCache.Size = new System.Drawing.Size(110, 33);
            this.btnCalculateCache.TabIndex = 0;
            this.btnCalculateCache.Text = "Calculate";
            this.btnCalculateCache.UseVisualStyleBackColor = true;
            this.btnCalculateCache.Click += new System.EventHandler(this.btnCalculateCache_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnCalculateList);
            this.panel10.Controls.Add(this.btnClearList);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(4, 426);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(220, 32);
            this.panel10.TabIndex = 1;
            // 
            // lstTimesList
            // 
            this.lstTimesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTimesList.FormattingEnabled = true;
            this.lstTimesList.ItemHeight = 16;
            this.lstTimesList.Location = new System.Drawing.Point(4, 36);
            this.lstTimesList.Name = "lstTimesList";
            this.lstTimesList.Size = new System.Drawing.Size(220, 390);
            this.lstTimesList.TabIndex = 2;
            // 
            // btnCalculateList
            // 
            this.btnCalculateList.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCalculateList.Location = new System.Drawing.Point(110, 0);
            this.btnCalculateList.Name = "btnCalculateList";
            this.btnCalculateList.Size = new System.Drawing.Size(110, 32);
            this.btnCalculateList.TabIndex = 0;
            this.btnCalculateList.Text = "Calculate";
            this.btnCalculateList.UseVisualStyleBackColor = true;
            this.btnCalculateList.Click += new System.EventHandler(this.btnCalculateList_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClearList.Location = new System.Drawing.Point(0, 0);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(110, 32);
            this.btnClearList.TabIndex = 1;
            this.btnClearList.Text = "Clear";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "H";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "M";
            // 
            // txtFirstH
            // 
            this.txtFirstH.Location = new System.Drawing.Point(120, 32);
            this.txtFirstH.MaxLength = 2;
            this.txtFirstH.Name = "txtFirstH";
            this.txtFirstH.Size = new System.Drawing.Size(46, 22);
            this.txtFirstH.TabIndex = 0;
            this.txtFirstH.Text = "0";
            this.txtFirstH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstH.Enter += new System.EventHandler(this.TextBoxEnter);
            this.txtFirstH.Leave += new System.EventHandler(this.TextLeave);
            // 
            // txtFirstM
            // 
            this.txtFirstM.Location = new System.Drawing.Point(172, 32);
            this.txtFirstM.MaxLength = 2;
            this.txtFirstM.Name = "txtFirstM";
            this.txtFirstM.Size = new System.Drawing.Size(46, 22);
            this.txtFirstM.TabIndex = 1;
            this.txtFirstM.Text = "0";
            this.txtFirstM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstM.Enter += new System.EventHandler(this.TextBoxEnter);
            this.txtFirstM.Leave += new System.EventHandler(this.TextLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "First Clock ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtFirstM);
            this.panel5.Controls.Add(this.txtFirstH);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(327, 61);
            this.panel5.TabIndex = 0;
            // 
            // SpecialyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 466);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SpecialyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpecialyForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSecoundM;
        private System.Windows.Forms.TextBox txtSecoundH;
        private System.Windows.Forms.Button btnMinues;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtResultM;
        private System.Windows.Forms.TextBox txtResultH;
        private System.Windows.Forms.Button btnCache;
        private System.Windows.Forms.Button btnMoveToList;
        private System.Windows.Forms.ListBox lstTimesList;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnCalculateList;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.ListBox lstCache;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnCalculateCache;
        private System.Windows.Forms.Button btnClearCache;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstM;
        private System.Windows.Forms.TextBox txtFirstH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}