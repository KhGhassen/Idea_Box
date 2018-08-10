using CommonServiceLocator;
using Idea_Box.Data;
using Idea_Box.Services;
using Idea_Box.ViewModels;
using Idea_Box.Views;
using Unity;
using Unity.ServiceLocation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace Idea_Box
{
    public partial class App : Application
    {
        public static INavigationService NavigationService { get; } = new ViewNavigationService();
        public static IdeaDatabase _IdeasDatabase;
        public App()
        {
            InitializeComponent();
            CreateDB();
            #region DI Initialization

            UnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IideaServices, IdeaServices>();
            unityContainer.RegisterInstance(new IdeaViewModel(new IdeaServices()));
            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(unityContainer));

            #endregion DI Initialization

            #region Navigation service initialization

          //  NavigationService.Configure("SplashScreen", typeof(SplashScreen));
            NavigationService.Configure("MainPage", typeof(MainPage));
            NavigationService.Configure("AddIdea", typeof(AddIdea));
            NavigationService.Configure("IdeaList", typeof(IdeaList));
            var mainPage = ((ViewNavigationService)NavigationService).SetRootPage("IdeaList");
            MainPage = mainPage;

            #endregion Navigation service initialization

         
        }

        private void CreateDB()
        {
            _IdeasDatabase = new IdeaDatabase();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}