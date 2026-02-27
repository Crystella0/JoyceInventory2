using UnityEngine;

[CreateAssetMenu(fileName = "Consumable", menuName = "Scriptable Objects/Consumable")]
public class Consumable : Item
{
    [SerializeField] protected int health;
    [SerializeField] protected int mana;

    public override string GetDescription()
    {
        return $"{description} \nWeight: {weight} Value: {value} \nHealth: {health} Mana: {mana}";
    }

    public int GetHealth()
    {
        return health;
    }

    public int GetMana()
    {
        return mana;
    }
}
