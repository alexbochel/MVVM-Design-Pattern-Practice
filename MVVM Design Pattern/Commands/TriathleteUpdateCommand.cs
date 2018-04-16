
using MVVM_Design_Pattern.ViewModels;
using System;
using System.Windows.Input;

namespace MVVM_Design_Pattern.Commands
{
    class TriathleteUpdateCommand : ICommand
    {
		private TriathleteViewModel _triViewModel;

		public TriathleteUpdateCommand(TriathleteViewModel triViewModel)
		{
			_triViewModel = triViewModel;
		}

		#region ICommand members

		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		public bool CanExecute(object parameter)
		{
			return _triViewModel.CanUpdate;
		}

		public void Execute(object parameter)
		{
			_triViewModel.SaveChanges();
		}

		#endregion
	}
}
