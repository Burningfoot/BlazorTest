using BlazorTest.Client.Models;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Reactive;

namespace BlazorTest.Client.ViewModels
{
    public class SecondPageViewModel : BaseViewModel
    {
        private int randomeNumber;
        private string selectedAnimalName;
        private ObservableCollection<Animal> animalList;

        public int RandomNumber
        {
            get => randomeNumber;
            set => this.RaiseAndSetIfChanged(ref randomeNumber, value);
        }

        public bool? IsLoading { get; set; }

        public ObservableCollection<Animal> AnimalList
        {
            get => animalList;
            set => this.RaiseAndSetIfChanged(ref animalList, value);
        }
        public string SelectedAnimalName
        {
            get => selectedAnimalName;
            set => this.RaiseAndSetIfChanged(ref selectedAnimalName, value);
        }

        public ReactiveCommand<Unit, Unit>? diceRoleCommand { get; set; }
        public ReactiveCommand<Unit, Unit>? AddDogCommand { get; set; }
        public ReactiveCommand<Unit, Unit>? AddCatCommand { get; set; }

        public SecondPageViewModel()
        {
            RegisterCommands();
            AnimalList = new ObservableCollection<Animal>();
        }

        private void RegisterCommands()
        {
            diceRoleCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Delay(0);
                Random rand = new Random();
                RandomNumber = rand.Next();
            });
            AddDogCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Delay(0);
                AnimalList.Add(new Dog() { Name = "Dog " + RandomNumber.ToString(), BackgroundColor = "blue"});

            });
            AddCatCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Delay(0);
                AnimalList.Add(new Cat() { Name = "Cat " + RandomNumber.ToString(), BackgroundColor = "red"});
            });
        }
    }
}
