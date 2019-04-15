namespace SuperHorses
{
	partial class AnimalEventsLog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox infoTB;
		private System.Windows.Forms.Button clearBTN;
		
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
			this.infoTB = new System.Windows.Forms.RichTextBox();
			this.clearBTN = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// infoTB
			// 
			this.infoTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.infoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.infoTB.Location = new System.Drawing.Point(13, 13);
			this.infoTB.Name = "infoTB";
			this.infoTB.Size = new System.Drawing.Size(695, 329);
			this.infoTB.TabIndex = 0;
			this.infoTB.Text = "";
			// 
			// clearBTN
			// 
			this.clearBTN.Location = new System.Drawing.Point(547, 348);
			this.clearBTN.Name = "clearBTN";
			this.clearBTN.Size = new System.Drawing.Size(161, 36);
			this.clearBTN.TabIndex = 1;
			this.clearBTN.Text = "очистить список";
			this.clearBTN.UseVisualStyleBackColor = true;
			this.clearBTN.Click += new System.EventHandler(this.ClearBTNClick);
			// 
			// AnimalEventsLog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(720, 395);
			this.Controls.Add(this.clearBTN);
			this.Controls.Add(this.infoTB);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "AnimalEventsLog";
			this.Text = "События лошади";
			this.Load += new System.EventHandler(this.AnimalEventsLogLoad);
			this.ResumeLayout(false);

		}
	}
}
