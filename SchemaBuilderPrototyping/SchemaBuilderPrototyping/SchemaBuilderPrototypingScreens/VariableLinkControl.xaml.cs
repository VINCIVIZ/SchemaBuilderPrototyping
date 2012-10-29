using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SchemaBuilderPrototypingScreens
{
	public partial class VariableLinkControl : UserControl
	{
		public event RoutedEventHandler Checked;
		public event RoutedEventHandler Unchecked;
		
		public VariableLinkControl()
		{
			// Required to initialize variables
			InitializeComponent();
		}

		private void checkBox_Checked(object sender, System.Windows.RoutedEventArgs e)
		{
			if (Checked != null)
			{
				Checked(this, new RoutedEventArgs());
			}
		}

		private void checkBox_Unchecked(object sender, System.Windows.RoutedEventArgs e)
		{
			if (Unchecked != null)
			{
				Unchecked(this, new RoutedEventArgs());
			}
		}

	}
}