
using MyDiet.Views.Ingredients;
using System.Windows;

namespace MyDiet.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void IngredientsButton_Click(object sender, RoutedEventArgs e)
        {
            IngredientsWindow ingredientsWindow = new IngredientsWindow();
            ingredientsWindow.ShowDialog();
        }
    }
}
