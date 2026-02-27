using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Scriptable Objects/Weapon")]
public class Weapon : Item
{
    [SerializeField] protected int damage;

    public override string GetDescription()
    {
        return $"{description} \nWeight: {weight} Value: {value} \nDamage: {damage}";
    }

    public int GetDamage()
    {
        return damage;
    }
}
