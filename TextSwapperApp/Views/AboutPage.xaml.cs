using System;
using System.ComponentModel;
using TextSwapperArEn;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TextSwapperApp.Views
{
    public partial class AboutPage : ContentPage
    {
        bool IsArToEn = false;
        public AboutPage()
        {
            InitializeComponent();
        }

        //Ar→Er
        //Ar←Er
        private void Button_Click(object sender, EventArgs e)
        {
            IsArToEn = !IsArToEn;
            this.Button.Text = IsArToEn ? "Ar→En" : "En→Ar";
            Swapper(true);
        }

        private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            Swapper();
        }


        public void Swapper(bool IsFlip = false)
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


            void Flip(bool flip) { if (flip) Box.Text = TextBox.Text; }

        }
    }
}