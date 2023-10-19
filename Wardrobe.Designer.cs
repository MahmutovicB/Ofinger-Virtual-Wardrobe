namespace Ofinger
{
	partial class Wardrobe
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wardrobe));
			label3 = new Label();
			pictureBox1 = new PictureBox();
			panel1 = new Panel();
			wardrobeMainMenu1 = new WardrobeMainMenu();
			tShirts1 = new TShirts();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.FromArgb(68, 68, 68);
			label3.Font = new Font("Dosis", 22.125F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = Color.White;
			label3.Location = new Point(1554, 78);
			label3.Name = "label3";
			label3.Size = new Size(257, 80);
			label3.TabIndex = 3;
			label3.Text = "Wardrobe";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(82, 72);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(200, 100);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(68, 68, 68);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(pictureBox1);
			panel1.Location = new Point(-4, -1);
			panel1.Name = "panel1";
			panel1.Size = new Size(1932, 220);
			panel1.TabIndex = 1;
			// 
			// wardrobeMainMenu1
			// 
			wardrobeMainMenu1.Location = new Point(5, 224);
			wardrobeMainMenu1.Name = "wardrobeMainMenu1";
			wardrobeMainMenu1.Size = new Size(3800, 1600);
			wardrobeMainMenu1.TabIndex = 2;
			// 
			// tShirts1
			// 
			tShirts1.Location = new Point(5, 224);
			tShirts1.Name = "tShirts1";
			tShirts1.Size = new Size(3800, 1600);
			tShirts1.TabIndex = 3;
			// 
			// Wardrobe
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1894, 1009);
			Controls.Add(wardrobeMainMenu1);
			Controls.Add(panel1);
			Controls.Add(tShirts1);
			Name = "Wardrobe";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Wardrobe";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label3;
		private PictureBox pictureBox1;
		private Panel panel1;
		private WardrobeMainMenu wardrobeMainMenu1;
		private TShirts tShirts1;
	}
}