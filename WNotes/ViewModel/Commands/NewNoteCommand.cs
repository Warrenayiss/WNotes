﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WNotes.ViewModel.Commands
{
	public class NewNoteCommand : ICommand
	{
		public NotesVM VM { get; set; }
		public event EventHandler CanExecuteChanged;

		public NewNoteCommand(NotesVM vm)
		{
			VM = vm;
		}

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			//TODO: New note functionnality
		}
	}
}
