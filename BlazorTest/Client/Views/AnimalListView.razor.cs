using BlazorTest.Client.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;

namespace BlazorTest.Client.Views
{
    public partial class AnimalListView
    {
        private ObservableCollection<Animal>? animalList;
        private string? selectedAnimal;

        [Parameter]
        public ObservableCollection<Animal>? AnimalList
        {
            get { return animalList; }
            set
            {
                if (animalList == value) return;
                animalList = value;
                ViewModel.AnimalList = animalList;
                AnimalListChanged.InvokeAsync(value);
                OnPropertyChanged();
            }
        }

        [Parameter]
        public string? SelectedAnimal
        {
            get { return selectedAnimal; }
            set
            {
                if (selectedAnimal == value) return;
                selectedAnimal = value;
                ViewModel.SelectedAnimal = selectedAnimal;
                SelectedAnimalChanged.InvokeAsync(value);
                OnPropertyChanged();
            }
        }

        [Parameter]
        public EventCallback<string> SelectedAnimalChanged { get; set; }

        [Parameter]
        public EventCallback<ObservableCollection<Animal>> AnimalListChanged { get; set; }
    }
}
