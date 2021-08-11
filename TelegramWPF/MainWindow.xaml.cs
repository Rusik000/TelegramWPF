using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TelegramWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (MessageTxtBX.Text == "Write a message...")
            {
                MessageTxtBX.Text = String.Empty;
            }
            else
            {
                return;
            }
        }

        private void MessageTxtBX_MouseLeave(object sender, MouseEventArgs e)
        {
            if (MessageTxtBX.Text == String.Empty)
            {
                MessageTxtBX.Text = "Write a message...";
            }
            else
            {
                return;
            }
        }

        private void SearchTxtBx_MouseEnter(object sender, MouseEventArgs e)
        {
            if (SearchTxtBx.Text == "Search")
            {
                SearchTxtBx.Text = String.Empty;
            }
            else
            {
                return;
            }
        }

        private void SearchTxtBx_MouseLeave(object sender, MouseEventArgs e)
        {
            if (SearchTxtBx.Text == String.Empty)
            {
                SearchTxtBx.Text = "Search";
            }
            else
            {
                return;
            }
        }
    }
}
