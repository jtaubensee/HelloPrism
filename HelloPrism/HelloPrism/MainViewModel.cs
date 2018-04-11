using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloPrism
{
    public class MainViewModel : BindableBase
    {
        public MainViewModel()
        {
            this.Title = "Main Page";
            this.TextForLabel = "This is some text";
        }

        private string title;
        public string Title
        {
            get => this.title;
            set => SetProperty(ref this.title, value);
        }

        private string textForLabel;
        public string TextForLabel
        {
            get => this.textForLabel;
            set => SetProperty(ref this.textForLabel, value);
        }
    }
}
