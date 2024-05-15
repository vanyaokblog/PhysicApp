using System.Windows;

namespace PhysicApp
{
    /// <summary>
    /// Логика взаимодействия для AddWin.xaml
    /// </summary>
    public partial class AddWin : Window
    {
        public AddWin()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            // Создаём контекст базы данных для взаимодействия с объектами
            using (var context = new ApplicationContext())
            {
                // Получаем значения из текстбоксов
                string name = nameTopic.Text;
                string text = textTopic.Text;

                // Создаём новый объект Topic
                var newTopic = new Topic
                {
                    NameTopic = name,
                    TextTopic = text
                };

                // Добавляем объект в базу данных
                context.Topics.Add(newTopic);
                context.SaveChanges();
            }

            MessageBox.Show("Тема добавлена");
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();

        }
    }
}
