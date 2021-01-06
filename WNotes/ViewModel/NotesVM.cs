using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WNotes.Models;

namespace WNotes.ViewModel
{
	public class NotesVM
	{
		public ObservableCollection<Notebook> Notebooks { get; set; }
		private Notebook selectedNotebook;

		public Notebook SelectedNotebook
		{
			get { return selectedNotebook; }
			set { 
				selectedNotebook = value; 
				//TODO: get the notes 
			}
		}
		public ObservableCollection<Note> Notes { get; set; }

	}
}
