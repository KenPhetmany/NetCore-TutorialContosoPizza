using ContosoPizza.Models;

namespace ContosoPizza.Services;

public static class PizzaService
{
    static List<Pizza> Pizzas { get; }
    static int nextId = 3;
    static PizzaService()
    {
        //Initialize List of Pizza
        Pizzas = new List<Pizza>
        {
            new Pizza {Id = 1, Name="Classic Italian", IssGlutenFree=false},
            new Pizza { Id = 2, Name = "Veggie", IssGlutenFree = true }
        };
    }
    //Get All Pizzas
    public static List<Pizza> GetAll() => Pizzas;
    //Get A Pizza with a specified Id
    public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);
    //Add new Pizza
    public static void Add(Pizza pizza)
    {
        pizza.Id = nextId++;
        Pizzas.Add(pizza);
    }


}