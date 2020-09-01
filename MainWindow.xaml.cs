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

namespace TextSwapperArEn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        bool IsArToEn = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        //Ar→Er
        //Ar←Er
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IsArToEn = !IsArToEn;
            this.Button.Content = IsArToEn? "Ar→En" : "En→Ar";
            Swapper(true);
        }

        private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            Swapper();
        }


        public void Swapper(bool IsFlip=false)
        {
           
            string text = Box.Text;
            Flip(IsFlip);
            if (IsArToEn)
            {
                TextBox.Text = text.LayoutArToEn();
            }
            else
            {
                TextBox.Text = text.LayoutEnToAr();
            }


            void Flip(bool flip){ if (flip) Box.Text = TextBox.Text;}

        }


    }
}
