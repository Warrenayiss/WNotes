using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WNotes.Models
{
	class Note : INotifyPropertyChanged
	{
		private int id;
		[PrimaryKey, AutoIncrement]

		public int Id
		{
			get { return id; }
			set { id = value; 
				OnPropertyChanged("Id");
			}
		}
		private int notebookId;
		[Indexed]

		public int NotebookId
		{
			get { return notebookId; }
			set { notebookId = value; 
				OnPropertyChanged("NotebookId");
			}
		}
		private string title;

		public string Title
		{
			get { return title; }
			set { title = value; 
				OnPropertyChanged("Title");
			}
		}
		private DateTime createdTime;

		public DateTime CreatedTime
		{
			get { return createdTime; }
			set { createdTime = value; 
				OnPropertyChanged("CreatedTime");
			}
		}

		private DateTime updateTime;

		public DateTime UpdatedTime
		{
			get { return updateTime; }
			set { updateTime = value; 
				OnPropertyChanged("UpdateTime");
			}
		}

		private string fileLocation;
		public string FileLocation
		{
			get { return fileLocation; }
			set { fileLocation = value; 
				OnPropertyChanged("FileLocation");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}


	}
}
