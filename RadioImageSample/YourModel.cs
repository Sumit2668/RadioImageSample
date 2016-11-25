using System;
using System.ComponentModel;

namespace RadioImageSample
{
	public sealed class YourModel : INotifyPropertyChanged
	{
		int _selectedIndex;

		public event PropertyChangedEventHandler PropertyChanged;

		public int SelectedIndex
		{
			get { return _selectedIndex; }
			set
			{
				if (_selectedIndex == value)
					return;
				_selectedIndex = value;
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedIndex)));
			}
		}
	}
}
