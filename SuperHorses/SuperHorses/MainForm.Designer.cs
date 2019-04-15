namespace SuperHorses
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox animalPIC;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button acceptBTN;
		private System.Windows.Forms.RichTextBox infoTB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown sumUD;
		private System.Windows.Forms.LinkLabel infoLINK;
		private System.Windows.Forms.TextBox moneyTB;
		private System.Windows.Forms.Label winlosesLB;
		private System.Windows.Forms.ListBox horsesLT;
		private System.Windows.Forms.Label stepLB;
		private System.Windows.Forms.Timer autoupdaterT;
		private System.Windows.Forms.LinkLabel helpLINK;
		private System.Windows.Forms.LinkLabel wordLINK;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.infoLINK = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.sumUD = new System.Windows.Forms.NumericUpDown();
            this.infoTB = new System.Windows.Forms.RichTextBox();
            this.acceptBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.animalPIC = new System.Windows.Forms.PictureBox();
            this.moneyTB = new System.Windows.Forms.TextBox();
            this.winlosesLB = new System.Windows.Forms.Label();
            this.horsesLT = new System.Windows.Forms.ListBox();
            this.stepLB = new System.Windows.Forms.Label();
            this.autoupdaterT = new System.Windows.Forms.Timer(this.components);
            this.helpLINK = new System.Windows.Forms.LinkLabel();
            this.wordLINK = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalPIC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.infoLINK);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.sumUD);
            this.panel1.Controls.Add(this.infoTB);
            this.panel1.Controls.Add(this.acceptBTN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.animalPIC);
            this.panel1.Location = new System.Drawing.Point(438, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 415);
            this.panel1.TabIndex = 0;
            // 
            // infoLINK
            // 
            this.infoLINK.Location = new System.Drawing.Point(3, 356);
            this.infoLINK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoLINK.Name = "infoLINK";
            this.infoLINK.Size = new System.Drawing.Size(120, 19);
            this.infoLINK.TabIndex = 6;
            this.infoLINK.TabStop = true;
            this.infoLINK.Text = "Забеги этой лошади";
            this.infoLINK.Visible = false;
            this.infoLINK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.InfoLINKLinkClicked);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(206, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "$";
            // 
            // sumUD
            // 
            this.sumUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sumUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumUD.Location = new System.Drawing.Point(41, 219);
            this.sumUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sumUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.sumUD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sumUD.Name = "sumUD";
            this.sumUD.Size = new System.Drawing.Size(160, 22);
            this.sumUD.TabIndex = 4;
            this.sumUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // infoTB
            // 
            this.infoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoTB.Location = new System.Drawing.Point(41, 50);
            this.infoTB.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.infoTB.Name = "infoTB";
            this.infoTB.ReadOnly = true;
            this.infoTB.Size = new System.Drawing.Size(224, 164);
            this.infoTB.TabIndex = 3;
            this.infoTB.Text = "Имя лошади\nВозраст\nВес\nВладелец";
            // 
            // acceptBTN
            // 
            this.acceptBTN.BackColor = System.Drawing.Color.GreenYellow;
            this.acceptBTN.Enabled = false;
            this.acceptBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptBTN.ForeColor = System.Drawing.Color.Navy;
            this.acceptBTN.Location = new System.Drawing.Point(3, 379);
            this.acceptBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acceptBTN.Name = "acceptBTN";
            this.acceptBTN.Size = new System.Drawing.Size(120, 31);
            this.acceptBTN.TabIndex = 2;
            this.acceptBTN.Text = "подтвердить";
            this.acceptBTN.UseVisualStyleBackColor = false;
            this.acceptBTN.Click += new System.EventHandler(this.AcceptBTNClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сделать ставку";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // animalPIC
            // 
            this.animalPIC.Image = ((System.Drawing.Image)(resources.GetObject("animalPIC.Image")));
            this.animalPIC.Location = new System.Drawing.Point(128, 277);
            this.animalPIC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.animalPIC.Name = "animalPIC";
            this.animalPIC.Size = new System.Drawing.Size(170, 133);
            this.animalPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.animalPIC.TabIndex = 0;
            this.animalPIC.TabStop = false;
            // 
            // moneyTB
            // 
            this.moneyTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moneyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyTB.ForeColor = System.Drawing.Color.Green;
            this.moneyTB.Location = new System.Drawing.Point(9, 391);
            this.moneyTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moneyTB.Name = "moneyTB";
            this.moneyTB.Size = new System.Drawing.Size(214, 39);
            this.moneyTB.TabIndex = 1;
            this.moneyTB.Text = "0$";
            // 
            // winlosesLB
            // 
            this.winlosesLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winlosesLB.ForeColor = System.Drawing.Color.Crimson;
            this.winlosesLB.Location = new System.Drawing.Point(10, 11);
            this.winlosesLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.winlosesLB.Name = "winlosesLB";
            this.winlosesLB.Size = new System.Drawing.Size(424, 56);
            this.winlosesLB.TabIndex = 2;
            this.winlosesLB.Text = "Выигрышей: 0\r\nПроигрышей: 0";
            // 
            // horsesLT
            // 
            this.horsesLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.horsesLT.FormattingEnabled = true;
            this.horsesLT.ItemHeight = 22;
            this.horsesLT.Items.AddRange(new object[] {
            "Лошадь 1",
            "Лошадь 2",
            "Лошадь 3"});
            this.horsesLT.Location = new System.Drawing.Point(10, 61);
            this.horsesLT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.horsesLT.Name = "horsesLT";
            this.horsesLT.Size = new System.Drawing.Size(399, 290);
            this.horsesLT.TabIndex = 3;
            this.horsesLT.SelectedIndexChanged += new System.EventHandler(this.HorsesLTSelectedIndexChanged);
            // 
            // stepLB
            // 
            this.stepLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepLB.Location = new System.Drawing.Point(306, 11);
            this.stepLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stepLB.Name = "stepLB";
            this.stepLB.Size = new System.Drawing.Size(102, 27);
            this.stepLB.TabIndex = 4;
            this.stepLB.Text = "1 заезд";
            // 
            // autoupdaterT
            // 
            this.autoupdaterT.Enabled = true;
            this.autoupdaterT.Interval = 1000;
            this.autoupdaterT.Tick += new System.EventHandler(this.AutoupdaterTTick);
            // 
            // helpLINK
            // 
            this.helpLINK.Location = new System.Drawing.Point(340, 409);
            this.helpLINK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helpLINK.Name = "helpLINK";
            this.helpLINK.Size = new System.Drawing.Size(75, 19);
            this.helpLINK.TabIndex = 5;
            this.helpLINK.TabStop = true;
            this.helpLINK.Text = "Помощь";
            this.helpLINK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HelpLINKLinkClicked);
            // 
            // wordLINK
            // 
            this.wordLINK.Location = new System.Drawing.Point(248, 409);
            this.wordLINK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wordLINK.Name = "wordLINK";
            this.wordLINK.Size = new System.Drawing.Size(88, 19);
            this.wordLINK.TabIndex = 6;
            this.wordLINK.TabStop = true;
            this.wordLINK.Text = "Вывести счет";
            this.wordLINK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WordLINKLinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 435);
            this.Controls.Add(this.wordLINK);
            this.Controls.Add(this.helpLINK);
            this.Controls.Add(this.stepLB);
            this.Controls.Add(this.horsesLT);
            this.Controls.Add(this.winlosesLB);
            this.Controls.Add(this.moneyTB);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Поставьте ставку на лошадь!";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalPIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
