namespace DesignPatterns.DesignPatterns.Builder;

public interface IBuilder
{
    void Reset();
    void SetAlcohol(decimal alcohol);
    void SetWater(int water);
    void SetMilk(int milk);
    void AddIngredient(string ingredient);
    void Mix();
    void Rest(int time);
}
