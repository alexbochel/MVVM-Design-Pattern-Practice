using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM_Design_Pattern.Commands;
using MVVM_Design_Pattern.Models;

namespace MVVM_Design_Pattern.ViewModels
{
	public class TriathleteViewModel
	{
		private Triathlete _triathlete;

		public ICommand UpdateCommand { get; private set; }
		public bool CanUpdate
		{
			get
			{
				if (Triathlete == null)
				{
					return false;
				}
				return !String.IsNullOrWhiteSpace(Triathlete.TriathleteName);
			}
		}

		public TriathleteViewModel()
		{
			_triathlete = new Triathlete("Alex Bochel", 12);
			UpdateCommand = new TriathleteUpdateCommand(this);
		}

		public Triathlete Triathlete
		{
			get
			{
				return _triathlete;
			}
			set
			{
				_triathlete = value;
			}
		}

		public void SaveChanges()
		{
			//Triathlete.TriathleteName = updatedTriathleteName; TODO: Why do I not need this?
			Debug.WriteLine("Updating name to: " + Triathlete.TriathleteName);
		}

	}
}
