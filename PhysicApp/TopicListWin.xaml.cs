using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Controls;

namespace PhysicApp
{
    /// <summary>
    /// Логика взаимодействия для TopicListWin.xaml
    /// </summary>
    public partial class TopicListWin : Window
    {
        // Создаем экземпляр контекста базы данных
        ApplicationContext db = new ApplicationContext();
        public TopicListWin()
        {
            InitializeComponent();  
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Гарантируем, что база данных создана
            db.Database.EnsureCreated(); 

            // Загружаем данные из базы
            db.Topics.Load();

            // Устанавливаем данные в качестве контекста
            DataContext = db.Topics.Local.ToObservableCollection();
        }

        // Обработчик события выбора элемента в списке
        private void TopicListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TopicListView.SelectedItem is Topic selectedTopic)
            {
                // Открываем окно с информацией по выбранной теме
                var topicDetailsWindow = new TopicWin(selectedTopic.NameTopic, selectedTopic.TextTopic);
                topicDetailsWindow.Show();
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
