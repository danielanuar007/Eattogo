# Eattogo - Food Calorie Tracking Application

A cross-platform mobile application built with .NET MAUI for tracking food calories and calculating daily caloric needs.

## 📱 Features

### Food Calories Calculator
- Calculate total calories from macronutrients (protein, carbohydrates, and fat)
- Input serving size and nutritional information
- Save food records for future reference
- Real-time calorie calculation using standard formulas

### Calories Intake Calculator (BMR/TDEE)
- Calculate Basal Metabolic Rate (BMR) based on personal metrics
- Support for both male and female calculations
- Activity level selection (sedentary to super active)
- Total Daily Energy Expenditure (TDEE) calculation

### Record Management
- View saved food records with complete nutritional breakdown
- Organized display of food name, calories, and macronutrients
- Persistent data storage using local file system

### Information Screen
- Application information and details
- Developer credits and version information

## 🛠️ Technical Stack

- **Framework**: .NET MAUI (.NET 8)
- **UI Framework**: XAML
- **Target Platforms**: 
  - Android (API 21+)
  - iOS (11.0+)
  - Windows (10.0.17763.0+)
  - macOS Catalyst (13.1+)
- **Data Storage**: Local file system
- **Architecture**: MVVM pattern with code-behind

## 📋 Prerequisites

- Visual Studio 2022 (17.8 or later) with MAUI workload
- .NET 8 SDK
- Platform-specific SDKs:
  - Android SDK (for Android development)
  - Xcode (for iOS/macOS development)
  - Windows SDK (for Windows development)

## 🚀 Getting Started

### Installation

1. **Clone the repository**
   ```bash
   git clone [your-repository-url]
   cd Eattogo
   ```

2. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

3. **Build the solution**
   ```bash
   dotnet build
   ```

### Running the Application

#### Android
```bash
dotnet build -f net8.0-android
```

#### iOS
```bash
dotnet build -f net8.0-ios
```

#### Windows
```bash
dotnet build -f net8.0-windows10.0.19041.0
```

#### macOS Catalyst
```bash
dotnet build -f net8.0-maccatalyst
```

## 📁 Project Structure

```
Eattogo/
├── Models/
│   └── FoodRecords.cs          # Data models
├── Platforms/
│   ├── Android/                # Android-specific code
│   ├── iOS/                    # iOS-specific code
│   ├── MacCatalyst/           # macOS-specific code
│   ├── Tizen/                 # Tizen-specific code
│   └── Windows/               # Windows-specific code
├── Resources/
│   ├── AppIcon/               # App icons
│   ├── Fonts/                 # Custom fonts
│   ├── Images/                # Image resources
│   ├── Raw/                   # Raw assets
│   ├── Splash/                # Splash screen
│   └── Styles/                # XAML styles and themes
├── App.xaml                   # Application-level resources
├── AppShell.xaml             # Shell navigation structure
├── MainPage.xaml             # Food calorie calculator
├── CaloriesIntake.xaml       # BMR/TDEE calculator
├── Record.xaml               # Saved records display
├── Information.xaml          # App information
└── MauiProgram.cs           # App configuration
```

## 🔧 Key Components

### MainPage - Food Calorie Calculator
- Input fields for food name, serving size, protein, carbs, and fat
- Automatic calorie calculation using the formula: `(Protein + Carbs) × 4 + Fat × 9`
- Save functionality to store food records locally

### CaloriesIntake - BMR/TDEE Calculator
- BMR calculation using Mifflin-St Jeor equation
- Activity multipliers for TDEE calculation
- Gender-specific calculations
- Age, height, weight, and activity level inputs

### Record Display
- CollectionView-based list of saved food records
- Detailed breakdown showing all nutritional information
- Data loaded from local storage file

### Data Storage
- Records saved to local application data folder
- CSV-format file storage (`Eattogo.txt`)
- Automatic file creation and management

## 🎨 UI/UX Features

- **Shell Navigation**: Modern flyout navigation pattern
- **Responsive Design**: Adapts to different screen sizes
- **Platform-Specific Styling**: Native look and feel on each platform
- **Color Themes**: Support for light and dark themes
- **Accessibility**: XAML semantic properties for screen readers

## 📊 Calculation Formulas

### Calorie Calculation
```
Total Calories = (Protein grams + Carbohydrate grams) × 4 + Fat grams × 9
```

### BMR Calculation (Mifflin-St Jeor Equation)
**For Males:**
```
BMR = 10 × weight(kg) + 6.25 × height(cm) - 5 × age(years) + 5
```

**For Females:**
```
BMR = 10 × weight(kg) + 6.25 × height(cm) - 5 × age(years) - 161
```

### Activity Multipliers
- Sedentary: 1.2
- Lightly active: 1.375
- Moderately active: 1.55
- Very active: 1.725
- Super active: 1.9

## 🔒 Data Privacy

- All data is stored locally on the device
- No cloud synchronization or external data transmission
- User privacy is maintained with offline-only storage

## 🐛 Known Issues

- Large datasets may impact performance on older devices
- File I/O operations are synchronous and may cause brief UI freezes

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 🆘 Support

For support, bug reports, or feature requests, please open an issue in the repository.

## 📱 Screenshots

*Screenshots would be added here showing the main features of the application*

---

**Note**: This application is designed for educational and personal use. For medical or professional dietary advice, consult with qualified healthcare professionals.