using System;
namespace Xamarin.Forms.Controls.CoreGalleryPages
{
	public class OSThemesGallery : ContentPage
	{
		public OSThemesGallery()
		{
			var label = new Label
			{
				Text = Application.Current.RequestedTheme.ToString()
			};

			var stackLayout = new StackLayout
			{
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Children = { label }
			};

			Content = stackLayout;
		}
	}
}