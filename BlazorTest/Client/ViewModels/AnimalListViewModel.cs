using BlazorTest.Client.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;

namespace BlazorTest.Client.ViewModels
{
    public class AnimalListViewModel : BaseViewModel
    {
        private ObservableCollection<Animal>? animalList;
        public ObservableCollection<Animal>? AnimalList
        {
            get { return animalList; }
            set 
            {
                animalList = value;
            }
        }

        private string? selectedAnimal;
        public string? SelectedAnimal
        {
            get { return selectedAnimal; }
            set 
            {
                selectedAnimal = value;
            }
        }

        public AnimalListViewModel()
        {
            AnimalList = new ObservableCollection<Animal>();
        }

    }
}
