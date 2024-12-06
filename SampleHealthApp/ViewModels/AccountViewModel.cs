using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SampleHealthApp.Pages;
using System.Collections.ObjectModel;

namespace SampleHealthApp.ViewModels
{
    public partial class AccountViewModel : ObservableObject
    {

        public AccountViewModel()
        {
            workoutName = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> workoutName;

        [ObservableProperty]
        string text;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;

            workoutName.Add(Text);
            //add our item
            Text = string.Empty;
        }
        [RelayCommand]
        void Remove(string s)
        {
            if (workoutName.Contains(s))
            {
                workoutName.Remove(s);
            }

        }
        [RelayCommand]
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}?Text={s}");
        }
    }
}
