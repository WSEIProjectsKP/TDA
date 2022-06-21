using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Todo.Core.Helpers;
using Todo.Core.ViewModels.Controlls;

namespace Todo.Core.ViewModels.Pages
{
    public class WorkTaskPageViewModel
    {

        public ObservableCollection<WorkTaskViewModel> WorkTaskList { get; set; } = new ObservableCollection<WorkTaskViewModel>();
        public string NewWorkTaskTitle { get; set; }
        public string NewWorkTaskDescription { get; set; }

        public ICommand AddTaskCommand { get; set; }
        
        
        public WorkTaskPageViewModel()
        {
            AddTaskCommand = new RelayCommand(AddNewTak);
        }
        private void AddNewTak()
        {
            WorkTaskViewModel newTask = new WorkTaskViewModel()
            {
                Title = NewWorkTaskTitle,
                Description = NewWorkTaskDescription,
                CreateDate = DateTime.UtcNow

            };
            WorkTaskList.Add(newTask);
        }
    }
}
