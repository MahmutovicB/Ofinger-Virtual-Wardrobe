using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ofinger
{
	using System;
	using System.Drawing;
	using System.Windows.Forms;

	public class CustomProgressBar : Control
	{
		// Constructor
		public CustomProgressBar()
		{
			this.DoubleBuffered = true;
		}

		// Override the OnPaint method to draw your custom progress bar
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			// Customize the drawing code for your progress bar here
			// Example: Fill a rectangle based on the progress value
			int progressBarWidth = (int)(this.Width * (double)Value / Maximum);
			Rectangle progressBarRect = new Rectangle(0, 0, progressBarWidth, this.Height);
			using (SolidBrush progressBarBrush = new SolidBrush(ForeColor))
			{
				e.Graphics.FillRectangle(progressBarBrush, progressBarRect);
			}
		}

		// Properties to control the progress
		private int value = 0;
		public int Value
		{
			get { return value; }
			set
			{
				this.value = Math.Max(Minimum, Math.Min(Maximum, value));
				this.Invalidate(); // Redraw the control
			}
		}

		private int minimum = 0;
		public int Minimum
		{
			get { return minimum; }
			set { minimum = value; }
		}

		private int maximum = 100;
		public int Maximum
		{
			get { return maximum; }
			set { maximum = value; }
		}
	}

}
