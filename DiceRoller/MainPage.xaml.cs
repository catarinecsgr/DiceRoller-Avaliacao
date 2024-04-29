namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DiceTypePicker.SelectedIndex = 0;
        }

        private void DiceBtn_Clicked(object sender, EventArgs e)
        {
            int sides = Convert.ToInt32(DiceTypePicker.SelectedItem);
            // Instanciação de um novo objeto dice do tipo Dice através do contrutor Dice();
            Dice dice = new Dice(sides);

            DiceResult.Text = dice.Rolar().ToString();
        }

        private void DiceTypePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            DiceTypeImage.Source = $"d{DiceTypePicker.SelectedItem.ToString()}.png";
            
        }
    }

}
