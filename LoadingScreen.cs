namespace Ofinger
{
	public partial class LoadingScreen : Form
	{
		public LoadingScreen()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (customProgressBar1.Value < customProgressBar1.Maximum)
			{
				// Increment the progress value gradually
				customProgressBar1.Value++;
			}
			else
			{
				// Stop the timer when the progress reaches 100
				progressTimer.Stop();
				this.Hide();
				new MainMenu().ShowDialog();
				this.Close();
			}
		}

		private void LoadingScreen_Load(object sender, EventArgs e)
		{
			// Reset the progress bar to 0
			customProgressBar1.Value = 0;

			// Set the maximum value (100)
			customProgressBar1.Maximum = 100;

			// Start the timer
			progressTimer.Start();
		}
	}
}