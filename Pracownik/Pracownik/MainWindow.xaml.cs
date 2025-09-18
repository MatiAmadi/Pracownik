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

namespace Pracownik
{
    public partial class MainWindow : Window
    {
        String Lowerletter = "qwertyuiopasdfghjklzxcvbnm";
        String UpperLetter = "QWERTYUIOPASDFGHJKLZXCVBNM";
        String numbers = "1234567890";
        String specialChars = "!@#$%^&*()_+";

        public MainWindow()
        {
            Random rand = new Random();
        }
        


    }
}
