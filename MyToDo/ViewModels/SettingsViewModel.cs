using MyToDo.Common.Models;
using MyToDo.Extensions;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MyToDo.ViewModels
{
    public class SettingsViewModel : BindableBase
    {
      
        //
        public SettingsViewModel(IRegionManager regionManager) 
        {
            MenuBars= new ObservableCollection<MenuBar>();

            this.regionManager= regionManager;

            NavigateCommand = new DelegateCommand<MenuBar>(Navigate);

            CreateMenuBar();
        }


        //

        public DelegateCommand<MenuBar> NavigateCommand { get; private set; }

        private readonly IRegionManager regionManager;

        private ObservableCollection<MenuBar> menuBars;

        public ObservableCollection<MenuBar> MenuBars
        {
            get { return menuBars; }
            set { menuBars = value; RaisePropertyChanged(); }
        }


        //
        private void Navigate(MenuBar obj)
        {
            if (obj == null || string.IsNullOrWhiteSpace(obj.NameSpace))
                return;
            regionManager.Regions[PrismManager.SettingsViewRegionName].RequestNavigate(obj.NameSpace);
        }


        void CreateMenuBar()
        {
            MenuBars.Add(new MenuBar() { Icon = "Home ", Title = "个性化 ", NameSpace = "SkinView" });
            MenuBars.Add(new MenuBar() { Icon = "NotebookOutline ", Title = "系统设置 ", NameSpace = "ToDoView" });
            MenuBars.Add(new MenuBar() { Icon = "NotebookPlus ", Title = "关于更多 ", NameSpace = "AboutView" });
            
        }


    }
}
