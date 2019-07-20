using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiet.ViewModels
{
    public abstract class BaseViewModel : BindableBase
    {
        private string title = "Moja dieta - zarządzanie posiłkami";
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        private string iconPath = @"/Resources/Images/logo.png";
        public string IconPath
        {
            get { return iconPath; }
            set { SetProperty(ref iconPath, value); }
        }
    }
}
