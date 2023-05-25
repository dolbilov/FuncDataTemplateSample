using System.Collections.Generic;
using FuncDataTemplateSample.Models;

namespace FuncDataTemplateSample.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public List<Person> People { get; } = new()
    {
        new Person
        {
            FirstName = "Mr.",
            LastName = "X",
            Sex = Sex.Diverse
        },
        new Person
        {
            FirstName = "Tony",
            LastName = "Stark",
            Sex = Sex.Male
        },
        new Person
        {
            FirstName = "Natasha",
            LastName = "Romanoff",
            Sex = Sex.Female
        }
    };
}
