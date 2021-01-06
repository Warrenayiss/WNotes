﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WNotes.Models;
using WNotes.ViewModel.Commands;

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

		public NewNotebookCommand NewNotebookCommand { get; set; }
		public NewNoteCommand NewNoteCommand { get; set; }

		public NotesVM()
		{
			NewNotebookCommand = new NewNotebookCommand(this);
			NewNoteCommand = new NewNoteCommand(this);
		}

		public void CreateNotebook()
		{
			Notebook notebook = new Notebook()
			{
				Name = "New Notebook"
			};

			DatabaseHelper.Insert(notebook);
		}

		public void CreateNote(int notebookId)
		{
			Note newNote = new Note()
			{
				NotebookId = notebookId,
				CreatedTime = DateTime.Now,
				UpdatedTime = DateTime.Now,
				Title = "New Note"
			};

			DatabaseHelper.Insert(newNote);
		}
	}
}
