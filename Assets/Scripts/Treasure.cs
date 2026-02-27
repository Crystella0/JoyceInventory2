using UnityEngine;

[CreateAssetMenu(fileName = "Treasure", menuName = "Scriptable Objects/Treasure")]
public class Treasure : Item
{
    [SerializeField] protected bool isUnique;
    
    public override string GetDescription()
    {
        return $"{description} \nWeight: {weight} Value: {value} \nUnique: {isUnique}";
    }
}
