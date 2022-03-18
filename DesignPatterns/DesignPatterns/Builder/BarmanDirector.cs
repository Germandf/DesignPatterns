namespace DesignPatterns.DesignPatterns.Builder;

public class BarmanDirector
{
    private IBuilder _builder;

    public BarmanDirector(IBuilder builder) => _builder = builder;

    public void SetBuilder(IBuilder builder) => _builder = builder;

    public void PrepareMargarita()
    {
        _builder.SetAlcohol(9);
        _builder.SetWater(30);
        _builder.AddIngredient("2 lemons");
        _builder.AddIngredient("Salt");
        _builder.AddIngredient("1/2 tequila cup");
        _builder.AddIngredient("3/4 orange liquor cup");
        _builder.AddIngredient("4 ice cubes");
        _builder.Mix();
        _builder.Rest(1000);
    }
}
