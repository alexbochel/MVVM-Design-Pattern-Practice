using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Design_Pattern.Models
{
	public class Triathlete : INotifyPropertyChanged
	{

		private string _triathleteName;
		private int _ironmanRaceTime;

		public Triathlete(String name, int ironmanTime)
		{
			TriathleteName = name;
			IronmanRaceTime = ironmanTime;
		}

		#region Property Getters/Setters

		public String TriathleteName
		{
			get
			{
				return _triathleteName;
			}
			set
			{
				_triathleteName = value;
				OnPropertyChanged("triathleteName");
			}
		}

		public int IronmanRaceTime
		{
			get
			{
				return _ironmanRaceTime;
			}
			set
			{
				_ironmanRaceTime = value;
				OnPropertyChanged("ironmanRaceTime");
			}
		}

		#endregion

		#region INotifyPropertyChanged

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler handler = PropertyChanged;

			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion
	}
}
