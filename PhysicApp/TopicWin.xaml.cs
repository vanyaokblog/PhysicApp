using System.Windows;

namespace PhysicApp
{
    /// <summary>
    /// Логика взаимодействия для TopicWin.xaml
    /// </summary>
    public partial class TopicWin : Window
    {
        ApplicationContext db = new ApplicationContext();
        public TopicWin(string topicName, string topicText)
        {
            InitializeComponent();
            TopicNameLabel.Text = topicName; // Устанавливаем имя темы
            TopicTextLabel.Text = topicText; // Устанавливаем текст темы
        }
    }
}
