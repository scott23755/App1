using Android.App;
using Android.Widget;
using Android.OS;

namespace Bored
{
	[Activity (Label = "Bored", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			//Button button = FindViewById<Button> (Resource.Id.myButton);
			Button speedBtn = FindViewById<Button> (Resource.Id.speedLabel);
			Button hdgBtn = FindViewById<Button> (Resource.Id.headingLabel);
			Button distBtn = FindViewById<Button> (Resource.Id.distLabel);

			TextView speedText = FindViewById<TextView> (Resource.Id.speedText);
			TextView distText = FindViewById<TextView> (Resource.Id.distText);
			
			//button.Click += delegate {
			//	button.Text = string.Format ("{0} clicks!", count++);
			//};

			speedBtn.Click += delegate(object sender, System.EventArgs e) {
				if(speedText.Text.Equals("Speed (mph)"))
					speedText.Text = "Speed (kts)";
				else
					speedText.Text = "Speed (mph)";
			};

			//hdgBtn.lickable (false);

			distBtn.Click += delegate {
				if(distText.Text.Equals("Dist. To Next:"))
					distText.Text = "Time To Next:";
				else
					distText.Text = "Dist. To Next:";
			};
		}
	}
}


