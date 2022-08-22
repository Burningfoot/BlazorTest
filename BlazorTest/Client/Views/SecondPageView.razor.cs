using BlazorTest.Client.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;

namespace BlazorTest.Client.Views
{
    public partial class SecondPageView
    {
        private bool isActiveChanged;
        private int randomNumber;
        private ObservableCollection<Animal> animalList = new ObservableCollection<Animal>();
        private string selectedAnimal;

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
                IsActiveChanged.InvokeAsync(value);
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
                RandomNumberChanged.InvokeAsync(value);
            }
        }
        
        public ObservableCollection<Animal> AnimalList
        {
            get { return animalList; }
            set
            {
                if(animalList == value) return;
                animalList = value;
                AnimalListChanged.InvokeAsync(value);
            }
        }

        [Parameter]
        public string SelectedAnimal
        {
            get { return selectedAnimal; }
            set
            {
                if(selectedAnimal == value) return;
                selectedAnimal = value;
                SelectedAnimalChanged.InvokeAsync(value);
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

        protected override Task OnParametersSetAsync()
        {
            ViewModel.AnimalList = AnimalList;
            ViewModel.SelectedAnimalName = SelectedAnimal;
            ViewModel.RandomNumber = RandomNumber;
            return base.OnParametersSetAsync();
        }
    }
}
