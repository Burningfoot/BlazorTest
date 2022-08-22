using BlazorTest.Client.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;

namespace BlazorTest.Client.Views
{
    public partial class AnimalListView
    {
        private ObservableCollection<Animal> animalList = new ObservableCollection<Animal>();
        private string selectedAnimal;

        [Parameter]
        public ObservableCollection<Animal> AnimalList
        {
            get { return animalList; }
            set
            {
                if (animalList == value) return;
                animalList = value;
                AnimalListChanged.InvokeAsync(value);
            }
        }

        [Parameter]
        public string SelectedAnimal 
        {
            get => selectedAnimal;
            set
            {
                if (selectedAnimal == value) return;
                selectedAnimal = value;
                SelectedAnimalChanged.InvokeAsync(value);
            } 
        }

        [Parameter]
        public EventCallback<string> SelectedAnimalChanged { get; set; }

        [Parameter]
        public EventCallback<ObservableCollection<Animal>> AnimalListChanged { get; set; }

        protected override Task OnParametersSetAsync()
        {
            ViewModel.AnimalList = AnimalList;
            ViewModel.SelectedAnimal = SelectedAnimal;
            return base.OnParametersSetAsync();
        }
    }
}
