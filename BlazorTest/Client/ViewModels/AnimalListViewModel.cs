using BlazorTest.Client.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;

namespace BlazorTest.Client.ViewModels
{
    public class AnimalListViewModel : BaseViewModel
    {
        private ObservableCollection<Animal> animalList;

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

        private string selectedAnimal;

        [Parameter]
        public string SelectedAnimal
        {
            get { return selectedAnimal; }
            set 
            {
                if (selectedAnimal == value) return;
                selectedAnimal = value;
                SelectedAnimalChanged.InvokeAsync(value);
            }
        }


        public AnimalListViewModel()
        {
            AnimalList = new ObservableCollection<Animal>();
        }

        [Parameter]
        public EventCallback<ObservableCollection<Animal>> AnimalListChanged { get; set; }
        [Parameter]
        public EventCallback<string> SelectedAnimalChanged { get; set; }

    }
}
