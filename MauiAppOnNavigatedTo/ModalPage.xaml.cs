namespace MauiAppOnNavigatedTo
{
    public partial class ModalPage : ContentPage
    {
        int count = 0;
        public ModalPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);

            count++;

            await DisplayAlert(string.Empty, $"OnNavigatedTo Called {count} time(s)", "Ok");
        }
    }
}
