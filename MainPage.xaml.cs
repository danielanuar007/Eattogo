namespace Eattogo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Eattogo.txt");

        public MainPage()
        {
            InitializeComponent();
        }

       void OnCalculateFood(object sender,EventArgs e)
        {
            try
            {
                // Parsing user input
                double proteinGrams = string.IsNullOrEmpty(inputProtein.Text) ? 0 : double.Parse(inputProtein.Text);
                double carbsGrams = string.IsNullOrEmpty(inputCarbs.Text) ? 0 : double.Parse(inputCarbs.Text);
                double fatGrams = string.IsNullOrEmpty(inputFat.Text) ? 0 : double.Parse(inputFat.Text);

                // Calculating calories
                double totalCalories = (proteinGrams + carbsGrams) * 4 + fatGrams * 9;

                // Displaying the result
                outputCalories.Text = $"{totalCalories}";
            }
            catch (FormatException)
            {
                // Handle format errors if non-numeric input is provided
                outputCalories.Text = "Please enter valid numbers for Protein, Carbs, and Fat.";
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                outputCalories.Text = $"Error: {ex.Message}";
            }
        }

        void OnReset(object sender,EventArgs e)
        {
            inputName.Text = null;
            inputServingSize.Text = null;
            inputProtein.Text = null;
            inputCarbs.Text = null;
            inputFat.Text = null;
            outputCalories.Text = "Calories Output Will Be Printed Here";
        }

        void OnSaveRecord(object sender,EventArgs e)
        {
            var record = $"{inputName.Text}," +
                 $"{outputCalories.Text}," +
                 $"{inputProtein.Text}," +
                 $"{inputCarbs.Text}," +
                 $"{inputFat.Text}";

            try
            {
                File.AppendAllText(fileName, record + Environment.NewLine);
                DisplayAlert("Success", "Record saved successfully.", "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", $"Failed to save the record: {ex.Message}", "OK");
            }
        }
    }

}
