﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WNotes.View
{
	/// <summary>
	/// Interaction logic for NotesWindow.xaml
	/// </summary>
	public partial class NotesWindow : Window
	{
		public NotesWindow()
		{
			InitializeComponent();
		}

		private void Exit_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
	}
}
