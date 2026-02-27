using UnityEngine;

[CreateAssetMenu(fileName = "Material", menuName = "Scriptable Objects/Material")]
public class Material : Item
{
    [SerializeField] protected string materialType;
        
    public override string GetDescription()
    {
        return $"{description} \nWeight: {weight} Value: {value} \nType: {materialType}";
    }
}
