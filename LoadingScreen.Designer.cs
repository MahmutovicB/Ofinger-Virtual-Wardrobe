namespace Ofinger
{
	partial class LoadingScreen
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
			pictureBox1 = new PictureBox();
			customProgressBar1 = new CustomProgressBar();
			progressTimer = new System.Windows.Forms.Timer(components);
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(477, 305);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(987, 348);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// customProgressBar1
			// 
			customProgressBar1.ForeColor = Color.White;
			customProgressBar1.Location = new Point(682, 746);
			customProgressBar1.Maximum = 100;
			customProgressBar1.Minimum = 0;
			customProgressBar1.Name = "customProgressBar1";
			customProgressBar1.Size = new Size(580, 46);
			customProgressBar1.TabIndex = 1;
			customProgressBar1.Text = "customProgressBar1";
			customProgressBar1.Value = 100;
			// 
			// progressTimer
			// 
			progressTimer.Interval = 20;
			progressTimer.Tick += timer1_Tick;
			// 
			// LoadingScreen
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(68, 68, 68);
			ClientSize = new Size(1894, 1009);
			Controls.Add(customProgressBar1);
			Controls.Add(pictureBox1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "LoadingScreen";
			StartPosition = FormStartPosition.CenterScreen;
			Load += LoadingScreen_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pictureBox1;
		private CustomProgressBar customProgressBar1;
		private System.Windows.Forms.Timer progressTimer;
	}
}