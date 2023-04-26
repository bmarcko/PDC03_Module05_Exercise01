using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CruzModule05Exercise01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void SubmitButton_Clicked(object sender, EventArgs e)
        {
            string enteredText = textInput.Text;
            TimeSpan selectedTime = timePicker.Time;

            string message = $"Entered Text: {enteredText}\nSelected Time: {selectedTime}";
            DisplayAlert("Form Data", message, "OK");
        }
    }
}
