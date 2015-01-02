using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Content;
using NativeAndXamarinFormsSwitching;
using NativeAndXamarinFormsSwitching.Droid;



[assembly:ExportRenderer (typeof(CustomButton), typeof(CustomButtonRenderer))]
namespace NativeAndXamarinFormsSwitching.Droid
{
	public class CustomButtonRenderer : ButtonRenderer
	{
		public CustomButtonRenderer ()
		{
			Console.WriteLine ("creating custom button renderer");
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Button> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {   // perform initial setup
				// do whatever you want to the UITextField here!
				Control.Click += (sender, even) => {
					Console.WriteLine ("Starting native activity.");
					global::Xamarin.Forms.Forms.Context.StartActivity (typeof(NativeActivity));
				};
			}
		}
	}
}

