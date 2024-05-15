using System;
using System.Windows;

namespace PhysicApp
{
    /// <summary>
    /// Логика взаимодействия для CurrentConverterWin.xaml
    /// </summary>
    public partial class CurrentConverterWin : Window
    {
        public CurrentConverterWin()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получаем введенное пользователем значение
                double inputValue = double.Parse(InputTextBox.Text);
                double convertedValue = 0;

                // Выполняем конвертацию в амперы
                if (kAToA.IsChecked == true)
                    convertedValue = inputValue * 1000;
                else if (mAToA.IsChecked == true)
                    convertedValue = inputValue * 0.001;
                else if (mkAToA.IsChecked == true)
                    convertedValue = inputValue * 0.000001;

                // Отображаем результат
                ResultLabel.Text = $"Конвертированное значение: {convertedValue} A";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильное числовое значение.");
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
