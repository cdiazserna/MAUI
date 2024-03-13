namespace MAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            //Forma de definir mi página principal y navigationPage para navegar entre páginas.
            var navPage = new NavigationPage(new MainPage());

            //New Propeerties defined
            navPage.BarBackground = Colors.Chocolate;
            navPage.BarTextColor = Colors.White;   
            
            MainPage = navPage;

            //Mi nuevo Flyout
            MainPage = new FlyoutPageDemo();
        }
    }
}
