﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GDLauncher.Dialogs.Server.Commands
{
    /// <summary>
    /// Interaction logic for Teleport.xaml
    /// </summary>
    public partial class Teleport : UserControl
    {
        public Teleport()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Windows.ServerManager.singleton.process.StandardInput.WriteLine("/teleport " + user1.Text + " " + user2.Text);
            MaterialDesignThemes.Wpf.DialogHost.CloseDialogCommand.Execute(this, this);
        }
    }
}