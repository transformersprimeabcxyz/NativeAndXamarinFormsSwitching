
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Util;
using Android.Text.Format;

namespace NativeAndXamarinFormsSwitching.Droid
{
	[Activity (Label = "NativeActivity")]			
	public class NativeActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.NativeActivityLayout);
			// Create your application here

			var closeMeButton = FindViewById<Button> (Resource.Id.closeMeButton);
			closeMeButton.Click += (sender, e) => {
				this.Finish ();
			};
		}
	}
}

