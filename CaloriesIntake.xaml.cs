namespace Eattogo;

public partial class CaloriesIntake : ContentPage
{
	int count = 0;
	public CaloriesIntake()
	{
		InitializeComponent();
	}

	private string selectedGender;
	void OnGenderChecked(object sender, EventArgs e)
	{
        var radioButton = sender as RadioButton;
        if (radioButton.IsChecked)
            selectedGender = radioButton.Content.ToString();
    }

    private void OnCalculateCalories(object sender, EventArgs e)
    {
        try
        {
            int age = int.Parse(inputAge.Text);
            int height = int.Parse(inputHeight.Text);
            int weight = int.Parse(inputWeight.Text);
            double BMR;

            if (selectedGender == "Male")
            {
                BMR = 10 * weight + 6.25 * height - 5 * age + 5;
            }
            else
            {
                BMR = 10 * weight + 6.25 * height - 5 * age - 161;
            }

            double activityFactor = GetActivityFactor(activityPicker.SelectedIndex);
            double TDEE = BMR * activityFactor;
            outputCalories.Text = $"Total Calories Needed: {TDEE:N2}";
        }
        catch (Exception ex)
        {
            outputCalories.Text = $"Error: {ex.Message}";
        }
    }

    private double GetActivityFactor(int selectedIndex)
    {
        switch (selectedIndex)
        {
            case 0: return 1.2;     // Sedentary
            case 1: return 1.375;   // Lightly active
            case 2: return 1.55;    // Moderately active
            case 3: return 1.725;   // Very active
            case 4: return 1.9;     // Super active
            default: return 1.2;    // Default to sedentary if nothing is selected
        }
    }


    private void OnClear(object sender, EventArgs e)
	{
        inputAge.Text = null;
        inputHeight.Text = null;
        inputWeight.Text = null;
        radioMale.IsChecked = false;
        radioFemale.IsChecked = false;
        activityPicker.SelectedIndex = -1;
        outputCalories.Text = "Calories needed will be displayed here";
    }
}