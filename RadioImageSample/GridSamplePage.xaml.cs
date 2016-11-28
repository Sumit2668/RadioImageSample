using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RadioImageSample
{
	public partial class GridSamplePage : ContentPage
	{
		public GridSamplePage()
		{
			InitializeComponent();

		    var model = new YourModel();
		    BindingContext = model;

		    var tapRec = new TapGestureRecognizer();
		    image1.GestureRecognizers.Add(tapRec);
		    image2.GestureRecognizers.Add(tapRec);
		    image3.GestureRecognizers.Add(tapRec);

		    tapRec.Tapped += (sender, e) =>
		    {
		        // タップされた Image に応じて Model.SelectedIndex を設定
		        if (object.ReferenceEquals(sender, image1)) { model.SelectedIndex = 1; }
		        else if (object.ReferenceEquals(sender, image2)) { model.SelectedIndex = 2; }
		        else if (object.ReferenceEquals(sender, image3)) { model.SelectedIndex = 3; }
		    };
		}
	}
}
