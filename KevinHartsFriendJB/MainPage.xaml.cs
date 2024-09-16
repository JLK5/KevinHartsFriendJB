namespace KevinHartsFriendJB
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Random r = new Random();
            int roll = r.Next(1, 7);
            CounterBtn.Text = "Rolled Number: " + roll.ToString();

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
