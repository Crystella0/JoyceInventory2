using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Item")]

public class Item : ScriptableObject
{
    [SerializeField] protected string name;
    [SerializeField] protected string description;

    [SerializeField] protected int weight;
    [SerializeField] protected int value;
    [SerializeField] protected Sprite sprite;
}
