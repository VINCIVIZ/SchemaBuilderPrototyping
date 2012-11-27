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
	public partial class Relationship : UserControl
	{
		public Relationship()
		{
			// Required to initialize variables
			InitializeComponent();
		}

		private void TextBox_GotFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
		}
		
		private void uncheckGroup(HeaderedItemsControl parent)
		{
			foreach (var elem in parent.Items)
			{
				if (elem is RadioButton)
				{
					(elem as RadioButton).IsChecked = false;
				}
			}
		}

		private void TextBox_TextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
		{

		}

		private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
		{
			if (customTextBox.Text.Length > 0)
			{
				uncheckGroup(temporalGroup);
				uncheckGroup(certaintyGroup);
				uncheckGroup(descGroup);
			}
		}
	}
}