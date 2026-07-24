using MyToDo.Common.Models;
using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace MyToDo.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {

        public MainWindowViewModel()
        {
            MenuBars = new ObservableCollection<MenuBar>();
            CreateMenuBar();
        }
        private ObservableCollection<MenuBar> menuBars;

        public ObservableCollection<MenuBar> MenuBars
        {
            get { return menuBars; }
            set { menuBars = value;RaisePropertyChanged(); }
        }


        void CreateMenuBar()
        {
            MenuBars.Add(new MenuBar() { Icon = "Home ", Title= "首页 ", NameSpace = "IndexView" });
            MenuBars.Add(new MenuBar() { Icon = "NotebookOutline ", Title = "待办事项 ", NameSpace = "ToDoView" });
            MenuBars.Add(new MenuBar() { Icon = "NotebookPlus ", Title = "备忘录 ", NameSpace = "MoveView" });
            MenuBars.Add(new MenuBar() { Icon = "Cog ", Title = "设置 ", NameSpace = "SettingsView" });


        }




        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

       
    }
}
