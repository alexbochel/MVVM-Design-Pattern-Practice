using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_Design_Pattern.Models;

namespace MVVM_Design_Pattern.ViewModels
{
	public class TriathleteViewModel
	{
		private Triathlete _triathlete;

		public TriathleteViewModel()
		{
			_triathlete = new Triathlete("Alex Bochel", 12);
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
	}
}
