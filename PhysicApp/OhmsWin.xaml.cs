using System;
using System.Windows;

namespace PhysicApp
{
    /// <summary>
    /// Логика взаимодействия для OhmsWin.xaml
    /// </summary>
    public partial class OhmsWin : Window
    {
        public OhmsWin()
        {
            InitializeComponent();
        }

        private void CalculateCurrent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получаем значения напряжения и сопротивления из текстбоксов
                double voltage = double.Parse(VoltageTextBox.Text);
                double resistance = double.Parse(ResistanceTextBox.Text);

                // Вычисляем ток по закону Ома: I = U / R
                double current = voltage / resistance;

                // Выводим результат
                CurrentResultLabel.Text = $"I = {current:F2} A";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные значения напряжения и сопротивления.");
            }
        }

        private void CalculateVoltage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получаем значения тока и сопротивления из текстбоксов
                double current = double.Parse(CurrentTextBox.Text);
                double resistance = double.Parse(ResistanceTextBox.Text);

                // Вычисляем напряжение по закону Ома: U = I * R
                double voltage = current * resistance;

                // Выводим результат
                VoltageResultLabel.Text = $"U = {voltage:F2} V";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные значения тока и сопротивления.");
            }
        }

        private void CalculateResistance_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получаем значения напряжения и тока из текстбоксов
                double voltage = double.Parse(VoltageTextBox.Text);
                double current = double.Parse(CurrentTextBox.Text);

                // Вычисляем сопротивление по закону Ома: R = U / I
                double resistance = voltage / current;

                // Выводим результат
                ResistanceResultLabel.Text = $"R = {resistance:F2} Ω";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные значения напряжения и тока.");
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
