using System;
using System.Windows.Controls;
using Todo.Core.ViewModels.Pages;

namespace Client.Pages
{
    /// <summary>
    /// Interaction logic for WorkTaskPage.xaml
    /// </summary>
    public partial class WorkTaskPage : UserControl
    {
        public WorkTaskPage()
        {
            InitializeComponent();
            DataContext = new WorkTaskPageViewModel();
            

        }
    }
}
