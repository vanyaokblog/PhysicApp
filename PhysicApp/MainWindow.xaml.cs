using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace PhysicApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db = new ApplicationContext(); // Создание экземпляра контекста базы данных
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddCustomTopic_Click(object sender, RoutedEventArgs e)
        {
            AddWin addWin = new AddWin();
            addWin.Show();
            Close();
        }

        private void OhmsLaw_Click(object sender, RoutedEventArgs e)
        {
            OhmsWin ohmsWin = new OhmsWin();
            ohmsWin.Show();
            Close();
        }

        private void CurrentUnitsToAmperes_Click(object sender, RoutedEventArgs e)
        {
            CurrentConverterWin currentConverterWin = new CurrentConverterWin();
            currentConverterWin.Show();
            Close();
        }

        private void ShowAllTopics(object sender, RoutedEventArgs e)
        {
            TopicListWin topicListWin = new TopicListWin();
            topicListWin.Show();
            Close();
        }

        private void ShowTopic(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                // Получаем айди темы
                string topicId = button.Tag.ToString(); // Предполагается, что айди хранится в Tag кнопки

                if (int.TryParse(topicId, out int id))
                {
                    // Находим тему по айди
                    Topic selectedTopic = db.Topics.FirstOrDefault(t => t.Id == id);

                    if (selectedTopic != null)
                    {
                        // Открывается новое окно с названием и текстом выбранной темы
                        var topicDetailsWindow = new TopicWin(selectedTopic.NameTopic, selectedTopic.TextTopic);
                        topicDetailsWindow.Show();
                    }
                }
            }
        }
    }
}
