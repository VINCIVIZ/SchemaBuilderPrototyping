﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.SynonymSampleData
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class SynonymSampleData { }
#else

	public class SynonymSampleData : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public SynonymSampleData()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/SchemaBuilderPrototyping.Screens;component/SampleData/SynonymSampleData/SynonymSampleData.xaml", System.UriKind.Relative);
				if (System.Windows.Application.GetResourceStream(resourceUri) != null)
				{
					System.Windows.Application.LoadComponent(this, resourceUri);
				}
			}
			catch (System.Exception)
			{
			}
		}

		private ItemCollection _Collection = new ItemCollection();

		public ItemCollection Collection
		{
			get
			{
				return this._Collection;
			}
		}
	}

	public class Item : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Synonym = string.Empty;

		public string Synonym
		{
			get
			{
				return this._Synonym;
			}

			set
			{
				if (this._Synonym != value)
				{
					this._Synonym = value;
					this.OnPropertyChanged("Synonym");
				}
			}
		}

		private string _Source = string.Empty;

		public string Source
		{
			get
			{
				return this._Source;
			}

			set
			{
				if (this._Source != value)
				{
					this._Source = value;
					this.OnPropertyChanged("Source");
				}
			}
		}

		private string _URL = string.Empty;

		public string URL
		{
			get
			{
				return this._URL;
			}

			set
			{
				if (this._URL != value)
				{
					this._URL = value;
					this.OnPropertyChanged("URL");
				}
			}
		}

		private bool _Checked = false;

		public bool Checked
		{
			get
			{
				return this._Checked;
			}

			set
			{
				if (this._Checked != value)
				{
					this._Checked = value;
					this.OnPropertyChanged("Checked");
				}
			}
		}
	}

	public class ItemCollection : System.Collections.ObjectModel.ObservableCollection<Item>
	{ 
	}
#endif
}
