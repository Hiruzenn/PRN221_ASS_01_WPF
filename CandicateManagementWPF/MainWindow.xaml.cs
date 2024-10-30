using Candicate_Service;
using Candidate_BussinessObjects;
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

namespace CandicateManagementWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IHRAccountService hracountService;
        public MainWindow()
        {
            InitializeComponent();
            hracountService = new HRAccountService();           
        }

       

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Hraccount hraccount = hracountService.GetHraccountByEmail(txt_Email.Text);
        }

        private void LoginBTN_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}