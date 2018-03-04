using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using Login_List.Models;
using Login_List.Services;
using Xamarin.Forms;
using Login_List.Views;

namespace Login_List.ViewModels
{
    class AdminViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Action DisplayInvalidLoginPrompt; //pour afficher boite de dialogue invalide
        public Action DisplayValidLoginPrompt; //pour afficher boite de dialogue valide

        //récupération du premier paramètre
        private String mail;
        public String Mail
        {
            get { return mail; }
            set
            {
                mail = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Mail"));
            }
        }

        //récupération du deuxième paramètre
        private String password;
        public String Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));

            }
        }

        //Le click sur le bouton
        public ICommand SubmitCommand
        { protected set; get; }

        public AdminViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }
        public void OnSubmit()
        {
            // Loading the datas od the admin from services
            List<Admin> UserDatas = AdminsServices.GetAdmins();
            int i = 0;
            bool exist = false;

            while (exist == false && i < UserDatas.Count)
            {
                if (mail == UserDatas[i].Mail && password == UserDatas[i].Password)
                {
                    DisplayValidLoginPrompt();
                    exist = true;
                    // I should add the function to pass from page to page
                    Application.Current.MainPage.Navigation.PushModalAsync(new EmployeeView());
                }
                else
                {
                    i = i + 1;
                }
            }

            if (exist == false)
            {
                DisplayInvalidLoginPrompt();
            }
        }
       

    }
}
