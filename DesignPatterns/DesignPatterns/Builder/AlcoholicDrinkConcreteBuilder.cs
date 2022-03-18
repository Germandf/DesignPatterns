namespace DesignPatterns.DesignPatterns.Builder;

public class AlcoholicDrinkConcreteBuilder : IBuilder
{
    private Drink _drink;

    public AlcoholicDrinkConcreteBuilder() => _drink = new();

    public Drink GetDrink() => _drink;

    public void AddIngredient(string ingredient)
    {
        if (_drink.Ingredients is null)
            _drink.Ingredients = new();
        _drink.Ingredients.Add(ingredient);
    }

    public void Mix() =>
        _drink.Result = $"Drink prepared with {_drink.Alcohol} alcohol, {_drink.Milk} milk, {_drink.Water} water and the following ingredients: " +
        $"{_drink.Ingredients.Aggregate((i, j) => $"{i}, {j}")}";

    public void Reset() => _drink = new();

    public void Rest(int time) => Thread.Sleep(time);

    public void SetAlcohol(decimal alcohol) => _drink.Alcohol = alcohol;

    public void SetMilk(int milk) => _drink.Milk = milk;

    public void SetWater(int water) => _drink.Water = water;
}
