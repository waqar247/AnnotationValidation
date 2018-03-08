using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using validationEntries.Models;
using validationEntries.MVVM;
using Xamarin.Forms;

namespace validationEntries.ViewModels
{
    public class FirstPageViewModel :  INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        User user;
       public ICommand commandd { get; set; }
        public FirstPageViewModel()
            {
            user = new User();

            commandd = new Command(()=> 
            {

                if (user.ValidateProperties())
                {
                    Application.Current.MainPage.DisplayAlert("Success", "ObjectValidated", "Ok");
                }


            });
            }

        

        public User User
        {
            get
            { return user; }
            set
            {
                User = value;
                // SetProperty(ref user, value); 
                OnPropertyChanged("User");
            }
        }
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
