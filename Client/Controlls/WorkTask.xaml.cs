using System;
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
using Todo.Core.ViewModels.Controlls;

namespace Client.Controlls
{
    /// <summary>
    /// Interaction logic for WorkTask.xaml
    /// </summary>
    public partial class WorkTask : UserControl
    {
        public WorkTask()
        {
            InitializeComponent();
            DataContext = new WorkTaskViewModel();
            Console.WriteLine(DataContext);
        }

        
    }
}
