using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Item")]

public class Item : ScriptableObject
{
    [SerializeField] protected string itemName;
    [SerializeField] protected string description;

    [SerializeField] protected int weight;
    [SerializeField] protected int value;
    [SerializeField] protected Sprite sprite;
    
    public string GetName() 
    {
        return itemName;
    }
    
    public virtual string GetDescription() 
    {
        return $"{description} \nWeight: {weight} Value: {value}";
    }

    public int GetWeight()
    {
        return weight;
    }

    public int GetValue()
    {
        return value;
    }

    public Sprite GetSprite()
    {
        return sprite;
    }
        
}
