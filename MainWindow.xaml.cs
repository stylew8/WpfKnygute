using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfKnygute.BL;
using WpfKnygute.DAL;
using WpfKnygute.DAL.Models;

namespace WpfKnygute
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IRepositoryDAL _repositoryDAL;
        private readonly IRepository _repository;
        public MainWindow()
        {
            _repositoryDAL = new RepositoryDal();
            _repository = new Repository(_repositoryDAL);

            InitializeComponent();

            Helpers.Contacts = _repositoryDAL.GetAllContacts();
            DtgContacts.ItemsSource = Helpers.Contacts;
        }

        private void ShowOwnDialog()
        {
            var dialog = new FunctionWindow();
            dialog.ShowDialog();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Helpers.Function = TypeOfFunction.Add;

            ShowOwnDialog();

            DtgContacts.Items.Refresh();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var currentContact = DtgContacts.SelectedItem as Contact;

            if (currentContact != null)
            {
                Helpers.Function = TypeOfFunction.Edit;
                Helpers.ContactModel = currentContact;

                ShowOwnDialog();

                DtgContacts.Items.Refresh();
            }
            else
            {
                MessageBox.Show("You need select contact for an edit");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var currentContact = DtgContacts.SelectedItem as Contact;

            if (currentContact != null)
            {
                MessageBoxResult result = MessageBox.Show($"Are you sure you want to delete the contact \"{currentContact.FullName}\"",
                    "Confirmation of deletion",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    _repository.Delete(currentContact.Id);
                    DtgContacts.Items.Refresh();
                }

            }
            else
            {
                MessageBox.Show("You need select contact for delete");
            }
        }

    }
}