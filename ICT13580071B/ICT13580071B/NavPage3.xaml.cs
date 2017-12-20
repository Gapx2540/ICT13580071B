using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ICT13580071B
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavPage3 : ContentPage
    {
        public NavPage3()
        {
            InitializeComponent();
            backButton.Clicked += BackButton_Clicked;
            BackToRootButton.Clicked += BackToRootButton_Clicked;
        }

        private void BackToRootButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}