using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryAdder : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Image image;
    [SerializeField] private Item item;
    [SerializeField] private InventoryManager inventoryManager;

    private void Awake()
    {
        if (item != null && item.GetSprite() != null)
        {
            image.sprite = item.GetSprite();
        }
    }

    public void AddItemToInventory()
    {
        inventoryManager.AddItem(item);
    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (item != null)
        {
            inventoryManager.ShowItemDescription(item.GetDescription());
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        inventoryManager.ShowItemDescription("");
    }


}
