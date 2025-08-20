using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Eattogo.Models;


namespace Eattogo;

public partial class Record : ContentPage
{
    public ObservableCollection<FoodRecord> FoodRecords { get; set; } = new ObservableCollection<FoodRecord>();

    public Record()
    {
        InitializeComponent();
        LoadRecords();
        this.BindingContext = this;
    }

    private void LoadRecords()
    {
        string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Eattogo.txt");
        if (File.Exists(fileName))
        {
            var lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length >= 5)
                {
                    FoodRecords.Add(new FoodRecord
                    {
                        Name = parts[0],
                        Calories = parts[1],
                        Protein = parts[2],
                        Carbs = parts[3],
                        Fat = parts[4]
                    });
                }
            }
        }
    }
}
