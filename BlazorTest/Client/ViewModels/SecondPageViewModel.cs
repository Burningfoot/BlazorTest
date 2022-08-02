using BlazorTest.Client.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Toolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace BlazorTest.Client.ViewModels
{
    public class SecondPageViewModel : BaseViewModel
    {

        private bool isActive;
        private int randomeNumber;

        [Parameter]
        public bool IsActive
        {
            get { return isActive; }
            set 
            {
                if (isActive == value) return;
                isActive = value; 
                IsActiveChanged.InvokeAsync(value);
            }
        }

        [Parameter]
        public int RandomNumber
        {
            get { return randomeNumber; }
            set 
            { 
                if (randomeNumber == value) return;
                randomeNumber = value; 
                RandomNumberChanged.InvokeAsync(value);
            }
        }

        public bool IsLoading { get; set; }

        private ObservableCollection<Animal> animalList;

        public ObservableCollection<Animal> AnimalList
        {
            get { return animalList; }
            set { animalList = value; }
        }
        public string SelectedAnimalName { get; set; }


        public RelayCommand com { get; set; }
        public RelayCommand diceRoleCommand { get; set; }
        public RelayCommand AddDogCommand { get; set; }
        public RelayCommand AddCatCommand { get; set; }

        public SecondPageViewModel()
        {
            RegisterCommands();
            AnimalList = new ObservableCollection<Animal>();
        }

        private void RegisterCommands()
        {
            com = new RelayCommand(() => { IsActive = !IsActive; });
            diceRoleCommand = new RelayCommand(async () =>
            {
                await Task.Delay(0);
                Random rand = new Random();
                RandomNumber = rand.Next();
            }, () => IsActive);
            AddDogCommand = new RelayCommand(async () => 
            {
                await Task.Delay(0);
                AnimalList.Add(new Dog() { Name = "Dog " + RandomNumber.ToString(), BackgroundColor = "blue"});

            });
            AddCatCommand = new RelayCommand(async () => 
            {
                await Task.Delay(0);
                AnimalList.Add(new Cat() { Name = "Cat " + RandomNumber.ToString(), BackgroundColor = "red"});
            });
        }

        [Parameter]
        public EventCallback<bool> IsActiveChanged { get; set; }
        [Parameter]
        public EventCallback<int> RandomNumberChanged { get; set; }
    }
}
