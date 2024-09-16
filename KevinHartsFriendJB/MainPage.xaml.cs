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
            if (d4.IsChecked == true)
            {
                int dice = r.Next(1, 5);
                rollValue.Text = "Rolled Number: " + dice.ToString();
            }
            else if (d6.IsChecked == true)
            {
                int dice = r.Next(1, 7);
                rollValue.Text = "Rolled Number: " + dice.ToString();
            }
            else if (d10.IsChecked == true)
            {
                int dice = r.Next(1, 11);
                rollValue.Text = "Rolled Number: " + dice.ToString();
            }
            else if (d12.IsChecked == true)
            {
                int dice = r.Next(1, 13);
                rollValue.Text = "Rolled Number: " + dice.ToString();
            }
        }
    }

}
