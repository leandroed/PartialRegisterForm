using config.Controller;
using config.Views.ViewsModel;
using System.Windows;

namespace config
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Main controller.
        /// </summary>
        public ControllerMain controller;

        /// <summary>
        /// Main view model.
        /// </summary>
        public ViewModelMain view;

        /// <summary>
        /// Main app window.
        /// </summary>
        public MainWindow()
        {
            controller = new ControllerMain();
            view = new ViewModelMain();
            InitializeComponent();

            this.DataContext = view;
        }

        /// <summary>
        /// Event triggered on confirm button click.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Routed event args.</param>
        private void Button_Confirm(object sender, RoutedEventArgs e)
        {
            if (controller.ConfirmReceiveData(view.Region, view.Username))
            {
                MessageBox.Show("Configurações recebidas!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Erro não foi possível configurar.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Event triggered on finish button click.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Routed event args.</param>
        private void Button_Finish(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
