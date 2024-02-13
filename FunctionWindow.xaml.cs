using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;
using WpfKnygute.BL;
using WpfKnygute.DAL;
using WpfKnygute.DAL.Models;

namespace WpfKnygute
{
    /// <summary>
    /// Interaction logic for FunctionWindow.xaml
    /// </summary>
    public partial class FunctionWindow : Window
    {
        private readonly IRepository _repository;
        public FunctionWindow()
        {
            InitializeComponent();

            if (Helpers.Function == TypeOfFunction.Edit)
            {
                txtFullName.Text = Helpers.ContactModel.FullName;
                txtNumber.Text = Helpers.ContactModel.Number;
                datePicker.Text = Helpers.ContactModel.DateOfBirth.ToString();
                datePicker.DisplayDate = Helpers.ContactModel.DateOfBirth;
            }
            else
            {
                Helpers.ContactModel = new Contact();
            }

            _repository = new Repository(new RepositoryDal());
        }

        public bool Validations()
        {
            bool validation = false;
            if (String.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("The field Full Name is empty!");
                validation = true;
                errorFullName.Content = "*";
            }
            else
            {
                errorFullName.Content = "";
            }

            if (String.IsNullOrEmpty(txtNumber.Text))
            {
                MessageBox.Show("The field phone number is empty!");
                validation = true;
                errorNumber.Content = "*";
            }
            else
            {
                errorNumber.Content = "";
            }

            return validation;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (Validations())
            {
                return;
            }

            switch (Helpers.Function)
            {
                case TypeOfFunction.Edit:
                    try
                    {
                        _repository.Update(
                            new Contact(
                                txtFullName.Text,
                                Helpers.ContactModel.Id,
                                txtNumber.Text,
                                DateTime.Parse(datePicker.Text)
                            )
                        );
                        MessageBox.Show("Contact successfully was updated");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("We have some problems, try one more time");
                    }
                    finally
                    {
                        this.Close();
                    }
                    break;
                case TypeOfFunction.Add:
                    try
                    {
                        _repository.Add(
                            new Contact(
                                txtFullName.Text,
                                Helpers.ContactModel.Id,
                                txtNumber.Text, 
                                DateTime.Parse(datePicker.Text)
                            )
                        );
                        MessageBox.Show("Contact successfully was added");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("We have some problems, try one more time");
                    }
                    finally
                    {
                        this.Close();
                    }
                    break;
                default:
                    Debug.Write("Error: Function is empty");
                    break;

            }
        }

        private void btnCancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
