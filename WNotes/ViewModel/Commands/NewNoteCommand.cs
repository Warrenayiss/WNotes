﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WNotes.Models;

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
			Notebook selectedNotebook = parameter as Notebook;
			if (selectedNotebook != null)
			{
				return true;
			}
			return false;

		}

		public void Execute(object parameter)
		{
			Notebook selectedNotebook = parameter as Notebook;
			VM.CreateNote(selectedNotebook.Id);
			//TODO: New note functionnality
		}
	}
}
