using BlazingPizza.Model;

namespace BlazingPizza.Services;

public class PizzaService
{
    public static async Task<Pizza[]> GetPizzasAsync()
    {
        return await new Task<Pizza[]>(
            () => new[]
            {
                new Pizza
                {
                    Name = "test"
                }
            });
    }
}

public class PizzaSalesState
{
    public int PizzasSoldToday { get; set; }
}
