using BlazorTest.Client.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;

namespace BlazorTest.Client.Views
{
    public partial class SecondPageView
    {
        private bool isActiveChanged;
        private int randomNumber;
        private ObservableCollection<Animal>? animalList;
        private string? selectedAnimal;

        [Parameter]
        public bool IsActive
        {
            get
            {
                return isActiveChanged;
            }
            set
            {
                if (isActiveChanged == value) return;
                isActiveChanged = value;
                ViewModel.IsActive = value;
                IsActiveChanged.InvokeAsync(value);
                OnPropertyChanged();
            }
        }  

        [Parameter]
        public int RandomNumber
        {
            get
            {
                return randomNumber;
            }
            set
            {
                if (randomNumber == value) return;
                randomNumber = value;
                ViewModel.RandomNumber = value;
                RandomNumberChanged.InvokeAsync(value);
                OnPropertyChanged();
            }
        }
        
        public ObservableCollection<Animal>? AnimalList
        {
            get { return animalList; }
            set
            {
                if(animalList == value) return;
                animalList = value;
                ViewModel.AnimalList = value;
                AnimalListChanged.InvokeAsync(value);
                OnPropertyChanged();
            }
        }

        public string? SelectedAnimal
        {
            get { return selectedAnimal; }
            set
            {
                selectedAnimal = value;
            }
        }

        [Parameter]
        public EventCallback<ObservableCollection<Animal>> AnimalListChanged { get; set; }

        [Parameter]
        public EventCallback<string> SelectedAnimalChanged { get; set; }
        [Parameter]
        public EventCallback<bool> IsActiveChanged { get; set; }

        [Parameter]
        public EventCallback<int> RandomNumberChanged { get; set; }
    }
}
