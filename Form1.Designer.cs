namespace Noorani_Clock
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstHour = new System.Windows.Forms.TextBox();
            this.txtFirstMinutes = new System.Windows.Forms.TextBox();
            this.txtFirstSecond = new System.Windows.Forms.TextBox();
            this.txtSecondHour = new System.Windows.Forms.TextBox();
            this.txtSecondMinutes = new System.Windows.Forms.TextBox();
            this.txtSecondSecond = new System.Windows.Forms.TextBox();
            this.txtThridHour = new System.Windows.Forms.TextBox();
            this.txtThridMinutes = new System.Windows.Forms.TextBox();
            this.txtThridSecond = new System.Windows.Forms.TextBox();
            this.lblThridAM = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ThridChbx = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SecondChbx = new System.Windows.Forms.CheckBox();
            this.FirstChbx = new System.Windows.Forms.CheckBox();
            this.lblSecondAM = new System.Windows.Forms.Label();
            this.lblFirstAM = new System.Windows.Forms.Label();
            this.ThridChbxLS = new System.Windows.Forms.CheckBox();
            this.SecondChbxLS = new System.Windows.Forms.CheckBox();
            this.FirstChbxLS = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtHourM = new System.Windows.Forms.TextBox();
            this.txtHourH = new System.Windows.Forms.TextBox();
            this.txtHourS = new System.Windows.Forms.TextBox();
            this.txtMinutesH = new System.Windows.Forms.TextBox();
            this.txtMinutesM = new System.Windows.Forms.TextBox();
            this.txtMinutesS = new System.Windows.Forms.TextBox();
            this.txtSecondH = new System.Windows.Forms.TextBox();
            this.txtSecondM = new System.Windows.Forms.TextBox();
            this.txtSecondS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(107, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Plus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Minus";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "M";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "S";
            // 
            // txtFirstHour
            // 
            this.txtFirstHour.Location = new System.Drawing.Point(107, 64);
            this.txtFirstHour.MaxLength = 2;
            this.txtFirstHour.Name = "txtFirstHour";
            this.txtFirstHour.Size = new System.Drawing.Size(46, 22);
            this.txtFirstHour.TabIndex = 0;
            this.txtFirstHour.Text = "0";
            this.txtFirstHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstHour.TextChanged += new System.EventHandler(this.button3_Click);
            this.txtFirstHour.Enter += new System.EventHandler(this.TextBoxEnter);
            this.txtFirstHour.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // txtFirstMinutes
            // 
            this.txtFirstMinutes.Location = new System.Drawing.Point(159, 64);
            this.txtFirstMinutes.MaxLength = 2;
            this.txtFirstMinutes.Name = "txtFirstMinutes";
            this.txtFirstMinutes.Size = new System.Drawing.Size(46, 22);
            this.txtFirstMinutes.TabIndex = 1;
            this.txtFirstMinutes.Text = "0";
            this.txtFirstMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstMinutes.Enter += new System.EventHandler(this.TextBoxEnter);
            this.txtFirstMinutes.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // txtFirstSecond
            // 
            this.txtFirstSecond.Location = new System.Drawing.Point(211, 64);
            this.txtFirstSecond.MaxLength = 2;
            this.txtFirstSecond.Name = "txtFirstSecond";
            this.txtFirstSecond.Size = new System.Drawing.Size(46, 22);
            this.txtFirstSecond.TabIndex = 2;
            this.txtFirstSecond.Text = "0";
            this.txtFirstSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstSecond.Enter += new System.EventHandler(this.TextBoxEnter);
            this.txtFirstSecond.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // txtSecondHour
            // 
            this.txtSecondHour.Location = new System.Drawing.Point(107, 97);
            this.txtSecondHour.MaxLength = 2;
            this.txtSecondHour.Name = "txtSecondHour";
            this.txtSecondHour.Size = new System.Drawing.Size(46, 22);
            this.txtSecondHour.TabIndex = 3;
            this.txtSecondHour.Text = "0";
            this.txtSecondHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSecondHour.Enter += new System.EventHandler(this.TextBoxEnter);
            this.txtSecondHour.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // txtSecondMinutes
            // 
            this.txtSecondMinutes.Location = new System.Drawing.Point(159, 97);
            this.txtSecondMinutes.MaxLength = 2;
            this.txtSecondMinutes.Name = "txtSecondMinutes";
            this.txtSecondMinutes.Size = new System.Drawing.Size(46, 22);
            this.txtSecondMinutes.TabIndex = 4;
            this.txtSecondMinutes.Text = "0";
            this.txtSecondMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSecondMinutes.Enter += new System.EventHandler(this.TextBoxEnter);
            this.txtSecondMinutes.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // txtSecondSecond
            // 
            this.txtSecondSecond.Location = new System.Drawing.Point(211, 97);
            this.txtSecondSecond.MaxLength = 2;
            this.txtSecondSecond.Name = "txtSecondSecond";
            this.txtSecondSecond.Size = new System.Drawing.Size(46, 22);
            this.txtSecondSecond.TabIndex = 5;
            this.txtSecondSecond.Text = "0";
            this.txtSecondSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSecondSecond.Enter += new System.EventHandler(this.TextBoxEnter);
            this.txtSecondSecond.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // txtThridHour
            // 
            this.txtThridHour.Enabled = false;
            this.txtThridHour.Location = new System.Drawing.Point(107, 130);
            this.txtThridHour.MaxLength = 2;
            this.txtThridHour.Name = "txtThridHour";
            this.txtThridHour.Size = new System.Drawing.Size(46, 22);
            this.txtThridHour.TabIndex = 10;
            this.txtThridHour.Text = "0";
            this.txtThridHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtThridHour.Enter += new System.EventHandler(this.TextBoxEnter);
            this.txtThridHour.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // txtThridMinutes
            // 
            this.txtThridMinutes.Enabled = false;
            this.txtThridMinutes.Location = new System.Drawing.Point(159, 130);
            this.txtThridMinutes.MaxLength = 2;
            this.txtThridMinutes.Name = "txtThridMinutes";
            this.txtThridMinutes.Size = new System.Drawing.Size(46, 22);
            this.txtThridMinutes.TabIndex = 11;
            this.txtThridMinutes.Text = "0";
            this.txtThridMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtThridMinutes.Enter += new System.EventHandler(this.TextBoxEnter);
            this.txtThridMinutes.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // txtThridSecond
            // 
            this.txtThridSecond.Enabled = false;
            this.txtThridSecond.Location = new System.Drawing.Point(211, 130);
            this.txtThridSecond.MaxLength = 2;
            this.txtThridSecond.Name = "txtThridSecond";
            this.txtThridSecond.Size = new System.Drawing.Size(46, 22);
            this.txtThridSecond.TabIndex = 12;
            this.txtThridSecond.Text = "0";
            this.txtThridSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtThridSecond.Enter += new System.EventHandler(this.TextBoxEnter);
            this.txtThridSecond.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // lblThridAM
            // 
            this.lblThridAM.AutoSize = true;
            this.lblThridAM.Enabled = false;
            this.lblThridAM.Location = new System.Drawing.Point(263, 133);
            this.lblThridAM.Name = "lblThridAM";
            this.lblThridAM.Size = new System.Drawing.Size(0, 16);
            this.lblThridAM.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "First Clock ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Second Clock ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Thrid Clock ";
            // 
            // ThridChbx
            // 
            this.ThridChbx.AutoSize = true;
            this.ThridChbx.Location = new System.Drawing.Point(305, 132);
            this.ThridChbx.Name = "ThridChbx";
            this.ThridChbx.Size = new System.Drawing.Size(73, 20);
            this.ThridChbx.TabIndex = 10;
            this.ThridChbx.Text = "Am_Pm";
            this.ThridChbx.UseVisualStyleBackColor = true;
            this.ThridChbx.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.Location = new System.Drawing.Point(305, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Long";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(386, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Short time";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SecondChbx
            // 
            this.SecondChbx.AutoSize = true;
            this.SecondChbx.Location = new System.Drawing.Point(305, 99);
            this.SecondChbx.Name = "SecondChbx";
            this.SecondChbx.Size = new System.Drawing.Size(73, 20);
            this.SecondChbx.TabIndex = 9;
            this.SecondChbx.Text = "Am_Pm";
            this.SecondChbx.UseVisualStyleBackColor = true;
            this.SecondChbx.CheckedChanged += new System.EventHandler(this.SecondChbx_CheckedChanged);
            // 
            // FirstChbx
            // 
            this.FirstChbx.AutoSize = true;
            this.FirstChbx.Location = new System.Drawing.Point(305, 66);
            this.FirstChbx.Name = "FirstChbx";
            this.FirstChbx.Size = new System.Drawing.Size(73, 20);
            this.FirstChbx.TabIndex = 8;
            this.FirstChbx.Text = "Am_Pm";
            this.FirstChbx.UseVisualStyleBackColor = true;
            this.FirstChbx.CheckedChanged += new System.EventHandler(this.FirstChbx_CheckedChanged);
            // 
            // lblSecondAM
            // 
            this.lblSecondAM.AutoSize = true;
            this.lblSecondAM.Enabled = false;
            this.lblSecondAM.Location = new System.Drawing.Point(263, 100);
            this.lblSecondAM.Name = "lblSecondAM";
            this.lblSecondAM.Size = new System.Drawing.Size(0, 16);
            this.lblSecondAM.TabIndex = 4;
            // 
            // lblFirstAM
            // 
            this.lblFirstAM.AutoSize = true;
            this.lblFirstAM.Enabled = false;
            this.lblFirstAM.Location = new System.Drawing.Point(263, 67);
            this.lblFirstAM.Name = "lblFirstAM";
            this.lblFirstAM.Size = new System.Drawing.Size(0, 16);
            this.lblFirstAM.TabIndex = 4;
            // 
            // ThridChbxLS
            // 
            this.ThridChbxLS.AutoSize = true;
            this.ThridChbxLS.Location = new System.Drawing.Point(380, 132);
            this.ThridChbxLS.Name = "ThridChbxLS";
            this.ThridChbxLS.Size = new System.Drawing.Size(87, 20);
            this.ThridChbxLS.TabIndex = 13;
            this.ThridChbxLS.Text = "LongShort";
            this.ThridChbxLS.UseVisualStyleBackColor = true;
            // 
            // SecondChbxLS
            // 
            this.SecondChbxLS.AutoSize = true;
            this.SecondChbxLS.Location = new System.Drawing.Point(380, 99);
            this.SecondChbxLS.Name = "SecondChbxLS";
            this.SecondChbxLS.Size = new System.Drawing.Size(87, 20);
            this.SecondChbxLS.TabIndex = 12;
            this.SecondChbxLS.Text = "LongShort";
            this.SecondChbxLS.UseVisualStyleBackColor = true;
            // 
            // FirstChbxLS
            // 
            this.FirstChbxLS.AutoSize = true;
            this.FirstChbxLS.Location = new System.Drawing.Point(380, 66);
            this.FirstChbxLS.Name = "FirstChbxLS";
            this.FirstChbxLS.Size = new System.Drawing.Size(87, 20);
            this.FirstChbxLS.TabIndex = 11;
            this.FirstChbxLS.Text = "LongShort";
            this.FirstChbxLS.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hour ";
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(72, 221);
            this.txtHour.MaxLength = 5;
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(63, 22);
            this.txtHour.TabIndex = 19;
            this.txtHour.Text = "0";
            this.txtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHour.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtHour.Enter += new System.EventHandler(this.TextBoxEnter);
            this.txtHour.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Minutes";
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(72, 254);
            this.txtMinutes.MaxLength = 5;
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(63, 22);
            this.txtMinutes.TabIndex = 20;
            this.txtMinutes.Text = "0";
            this.txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMinutes.TextChanged += new System.EventHandler(this.txtMinutes_TextChanged);
            this.txtMinutes.Enter += new System.EventHandler(this.TextBoxEnter);
            this.txtMinutes.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Second";
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(72, 287);
            this.txtSecond.MaxLength = 5;
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(63, 22);
            this.txtSecond.TabIndex = 21;
            this.txtSecond.Text = "0";
            this.txtSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSecond.TextChanged += new System.EventHandler(this.txtSecond_TextChanged);
            this.txtSecond.Enter += new System.EventHandler(this.TextBoxEnter);
            this.txtSecond.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // txtHourM
            // 
            this.txtHourM.Enabled = false;
            this.txtHourM.Location = new System.Drawing.Point(210, 221);
            this.txtHourM.MaxLength = 11;
            this.txtHourM.Name = "txtHourM";
            this.txtHourM.Size = new System.Drawing.Size(100, 22);
            this.txtHourM.TabIndex = 25;
            this.txtHourM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHourH
            // 
            this.txtHourH.Enabled = false;
            this.txtHourH.Location = new System.Drawing.Point(141, 221);
            this.txtHourH.MaxLength = 11;
            this.txtHourH.Name = "txtHourH";
            this.txtHourH.Size = new System.Drawing.Size(63, 22);
            this.txtHourH.TabIndex = 22;
            this.txtHourH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHourS
            // 
            this.txtHourS.Enabled = false;
            this.txtHourS.Location = new System.Drawing.Point(316, 221);
            this.txtHourS.MaxLength = 11;
            this.txtHourS.Name = "txtHourS";
            this.txtHourS.Size = new System.Drawing.Size(139, 22);
            this.txtHourS.TabIndex = 28;
            this.txtHourS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinutesH
            // 
            this.txtMinutesH.Enabled = false;
            this.txtMinutesH.Location = new System.Drawing.Point(141, 254);
            this.txtMinutesH.MaxLength = 11;
            this.txtMinutesH.Name = "txtMinutesH";
            this.txtMinutesH.Size = new System.Drawing.Size(63, 22);
            this.txtMinutesH.TabIndex = 23;
            this.txtMinutesH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinutesM
            // 
            this.txtMinutesM.Enabled = false;
            this.txtMinutesM.Location = new System.Drawing.Point(210, 254);
            this.txtMinutesM.MaxLength = 11;
            this.txtMinutesM.Name = "txtMinutesM";
            this.txtMinutesM.Size = new System.Drawing.Size(100, 22);
            this.txtMinutesM.TabIndex = 26;
            this.txtMinutesM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinutesS
            // 
            this.txtMinutesS.Enabled = false;
            this.txtMinutesS.Location = new System.Drawing.Point(316, 254);
            this.txtMinutesS.MaxLength = 11;
            this.txtMinutesS.Name = "txtMinutesS";
            this.txtMinutesS.Size = new System.Drawing.Size(139, 22);
            this.txtMinutesS.TabIndex = 29;
            this.txtMinutesS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSecondH
            // 
            this.txtSecondH.Enabled = false;
            this.txtSecondH.Location = new System.Drawing.Point(141, 287);
            this.txtSecondH.MaxLength = 11;
            this.txtSecondH.Name = "txtSecondH";
            this.txtSecondH.Size = new System.Drawing.Size(63, 22);
            this.txtSecondH.TabIndex = 24;
            this.txtSecondH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSecondM
            // 
            this.txtSecondM.Enabled = false;
            this.txtSecondM.Location = new System.Drawing.Point(210, 287);
            this.txtSecondM.MaxLength = 11;
            this.txtSecondM.Name = "txtSecondM";
            this.txtSecondM.Size = new System.Drawing.Size(100, 22);
            this.txtSecondM.TabIndex = 27;
            this.txtSecondM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSecondS
            // 
            this.txtSecondS.Enabled = false;
            this.txtSecondS.Location = new System.Drawing.Point(316, 287);
            this.txtSecondS.MaxLength = 11;
            this.txtSecondS.Name = "txtSecondS";
            this.txtSecondS.Size = new System.Drawing.Size(139, 22);
            this.txtSecondS.TabIndex = 30;
            this.txtSecondS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(355, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Second";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(230, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Minutes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(152, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Hour";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(478, 339);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSecondS);
            this.Controls.Add(this.txtMinutesS);
            this.Controls.Add(this.txtHourS);
            this.Controls.Add(this.txtSecondM);
            this.Controls.Add(this.txtMinutesM);
            this.Controls.Add(this.txtHourM);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSecondH);
            this.Controls.Add(this.txtMinutesH);
            this.Controls.Add(this.txtHourH);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FirstChbxLS);
            this.Controls.Add(this.FirstChbx);
            this.Controls.Add(this.SecondChbxLS);
            this.Controls.Add(this.ThridChbxLS);
            this.Controls.Add(this.SecondChbx);
            this.Controls.Add(this.ThridChbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFirstAM);
            this.Controls.Add(this.lblSecondAM);
            this.Controls.Add(this.lblThridAM);
            this.Controls.Add(this.txtThridSecond);
            this.Controls.Add(this.txtSecondSecond);
            this.Controls.Add(this.txtFirstSecond);
            this.Controls.Add(this.txtThridMinutes);
            this.Controls.Add(this.txtSecondMinutes);
            this.Controls.Add(this.txtFirstMinutes);
            this.Controls.Add(this.txtThridHour);
            this.Controls.Add(this.txtSecondHour);
            this.Controls.Add(this.txtFirstHour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstHour;
        private System.Windows.Forms.TextBox txtFirstMinutes;
        private System.Windows.Forms.TextBox txtFirstSecond;
        private System.Windows.Forms.TextBox txtSecondHour;
        private System.Windows.Forms.TextBox txtSecondMinutes;
        private System.Windows.Forms.TextBox txtSecondSecond;
        private System.Windows.Forms.TextBox txtThridHour;
        private System.Windows.Forms.TextBox txtThridMinutes;
        private System.Windows.Forms.TextBox txtThridSecond;
        private System.Windows.Forms.Label lblThridAM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ThridChbx;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox SecondChbx;
        private System.Windows.Forms.CheckBox FirstChbx;
        private System.Windows.Forms.Label lblSecondAM;
        private System.Windows.Forms.Label lblFirstAM;
        private System.Windows.Forms.CheckBox ThridChbxLS;
        private System.Windows.Forms.CheckBox SecondChbxLS;
        private System.Windows.Forms.CheckBox FirstChbxLS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtHourM;
        private System.Windows.Forms.TextBox txtHourH;
        private System.Windows.Forms.TextBox txtHourS;
        private System.Windows.Forms.TextBox txtMinutesH;
        private System.Windows.Forms.TextBox txtMinutesM;
        private System.Windows.Forms.TextBox txtMinutesS;
        private System.Windows.Forms.TextBox txtSecondH;
        private System.Windows.Forms.TextBox txtSecondM;
        private System.Windows.Forms.TextBox txtSecondS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

