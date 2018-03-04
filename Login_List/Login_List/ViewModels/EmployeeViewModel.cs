using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Login_List.Models;
using Login_List.Services;
using Xamarin.Forms;
using Login_List.Views;

namespace Login_List.ViewModels
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        //récupérer toute la liste et l'afficher
        public List<Employee> employeesList;
        public List<Employee> EmployeesList
        {
            get { return employeesList; }
            set
            {
                employeesList = value;
                OnPropertyChanged();
            }
        }
        public EmployeeViewModel()
        {
            var employeesServices = new EmployeesServices();
            EmployeesList = EmployeesServices.GetEmployee();
        }
        protected virtual void OnPropertyChanged(string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
        //récupérer le item selection de la liste
        private Employee employeeSelected;
        public Employee EmployeeSelected
        {
            get { return employeeSelected;}
            set
            {
                if (employeeSelected != value)
                {
                    employeeSelected = value;
                    EmployeeSelectedItem();
                }
            }
        }
        private void EmployeeSelectedItem()
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new PopUp(EmployeeSelected.Name, EmployeeSelected.Departement));
            Console.WriteLine("name:" + EmployeeSelected.Name + " Departement:" + EmployeeSelected.Departement);

        }

    }
}
