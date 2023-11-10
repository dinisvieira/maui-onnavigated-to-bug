namespace MauiAppOnNavigatedTo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            var page = new ModalPage();
            await Navigation.PushModalAsync(new NavigationPage(page));
        }
    }
}
