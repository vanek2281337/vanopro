namespace vanopro
{
    public partial class MainPage : ContentPage
    {
        private string _phoneEntry { get; set; }

        public MainPage()
        {
            InitializeComponent();
        }
        private bool is_validPhoneNumber()
        {
            if (_phoneEntry == null && _phoneEntry.Length <18)
            {

                DisplayAlert("", "Неверный номер телефона!", "Ok");
                return false;
            }
            return true;
        }
        private void send_Clicked(object sender, EventArgs e)
        {
            _phoneEntry = PhoneEntry.Text;
            if (is_validPhoneNumber ())
            {
                CodeEntry.IsVisible = true;

            
            }
        }
    }
}