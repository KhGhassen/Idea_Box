using Idea_Box.Models;
using Idea_Box.Services;
using Idea_Box.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Idea_Box.ViewModels
{
    public class IdeaViewModel : INotifyPropertyChanged
    {
        private readonly IideaServices _IideaServices;
        private ObservableCollection<Idea> _Ideas;
        private Idea _Idea;
        private string _teststring = "1234";
        ICommand _AddIdeaCommand;
        ICommand _GotoIdeasListCommand;
        ICommand _SaveIdeaCommand;



        public string Teststring
        {
            get => _teststring;
            set
            {
                _teststring = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Idea> Ideas
        {
            get => _Ideas;
            set
            {
                _Ideas = value;
                OnPropertyChanged();
            }
        }
        public Idea Idea
        {
            get => _Idea;
            set
            {
                _Idea = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddIdeaCommand
        {
            get { return _AddIdeaCommand; }
        }
        public ICommand GotoIdeasListCommand
        {
            get { return _GotoIdeasListCommand; }
        }
        public ICommand SaveIdeaCommand
        {
            get { return _SaveIdeaCommand; }
        }

        public IdeaViewModel(IideaServices IdeaServices )
        {
            Idea = new Idea();
            _IideaServices = IdeaServices;
            _AddIdeaCommand = new Command(OnTapped);
            _GotoIdeasListCommand = new Command(OnCancelTapped);
            _SaveIdeaCommand = new Command(OnSaveTapped);
            Downloadideas();
        }

        private void Downloadideas()
        {
          //  Ideas = _IideaServices.GetIdeas();
            Ideas = App._IdeasDatabase.GetIdeas();
        }
        public void InsertIdea()
        {
            Idea.PublishDate = DateTime.Now;
            Ideas.Add(Idea);
            App._IdeasDatabase.AddIdea(Idea);
        }


        private async Task ShowAlert()
        {
            /////
            await Application.Current.MainPage.DisplayAlert("Confirmation", "Your Idea Was Submitted , Thanks for your contribution", "Dismiss");
            InsertIdea();
            await App.NavigationService.GoBack();
        }

        async  void OnTapped(object s)
        {
            await App.NavigationService.NavigateAsync("AddIdea");
        }
        void OnSaveTapped(object s)
        {
            
             ShowAlert();
        }
        async void OnCancelTapped(object s)
        {

            await App.NavigationService.GoBack();
        }

        #region PropertyChanged Management

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        

        #endregion
    }
}
