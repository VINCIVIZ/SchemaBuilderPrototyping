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
	public partial class Screen_1 : UserControl
	{
		public Screen_1()
		{
			// Required to initialize variables
			InitializeComponent();
		}

		private void TextBox_GotFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			(sender as TextBox).SelectAll();
			customAgeRadioButton.IsChecked = true;
		}
		
		private void RelationshipTextBox_GotFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			customRelationshipRadioButton.IsChecked = true;
		}
	}
}