using UnityEngine;

[CreateAssetMenu(fileName = "Armor", menuName = "Scriptable Objects/Armor")]
public class Armor : Item
{
    [SerializeField] protected int defense;

    public override string GetDescription()
    {
        return $"{description} \nWeight: {weight} Value: {value} \nDefense: {defense}";
    }

    public int GetDefense()
    {
        return defense;
    }
    
    
}
