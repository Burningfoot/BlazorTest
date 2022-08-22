using BlazorTest.Client.Models;
using Microsoft.AspNetCore.Components;
using ReactiveUI;
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

        private string selectedAnimal;

        public string SelectedAnimal
        {
            get => selectedAnimal;
            set => this.RaiseAndSetIfChanged(ref selectedAnimal, value);
        }

        public AnimalListViewModel()
        {
        }

    }
}
