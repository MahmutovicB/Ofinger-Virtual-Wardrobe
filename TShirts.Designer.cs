namespace Ofinger
{
	partial class TShirts
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TShirts));
			flowLayoutPanel1 = new FlowLayoutPanel();
			pictureBox5 = new PictureBox();
			label1 = new Label();
			pictureBox2 = new PictureBox();
			flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(pictureBox5);
			flowLayoutPanel1.Controls.Add(label1);
			flowLayoutPanel1.Controls.Add(pictureBox2);
			flowLayoutPanel1.Dock = DockStyle.Fill;
			flowLayoutPanel1.Location = new Point(0, 0);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(1900, 800);
			flowLayoutPanel1.TabIndex = 0;
			// 
			// pictureBox5
			// 
			pictureBox5.BackColor = Color.FromArgb(68, 68, 68);
			pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
			pictureBox5.Location = new Point(3, 3);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(159, 145);
			pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox5.TabIndex = 15;
			pictureBox5.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.FromArgb(68, 68, 68);
			label1.Font = new Font("Dosis", 16.1249981F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(168, 0);
			label1.Name = "label1";
			label1.Size = new Size(157, 58);
			label1.TabIndex = 14;
			label1.Text = "T-Shirts";
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(331, 3);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(276, 288);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 13;
			pictureBox2.TabStop = false;
			// 
			// TShirts
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(flowLayoutPanel1);
			Name = "TShirts";
			Size = new Size(1900, 800);
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel1;
		private PictureBox pictureBox5;
		private Label label1;
		private PictureBox pictureBox2;
	}
}
