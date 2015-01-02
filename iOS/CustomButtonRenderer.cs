using System;
using Xamarin.Forms.Platform.iOS;
using NativeAndXamarinFormsSwitching;
using Xamarin.Forms;
using NativeAndXamarinFormsSwitching.iOS;

[assembly:ExportRenderer (typeof(CustomButton), typeof(CustomButtonRenderer))]
namespace NativeAndXamarinFormsSwitching.iOS
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
				Control.TouchUpInside += (sender, even) => {
					Console.WriteLine ("loading native UIView.");
					//global::Xamarin.Forms.Context //<!-- Why does iOS not have context?
					//global::Xamarin.Forms.Application.Current.MainPage  


				};
			}
		}
	}
}
