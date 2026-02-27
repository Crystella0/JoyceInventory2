using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Item item;
    private InventoryManager inventoryManager;

    public void SetInventoryManager(InventoryManager inventoryManager)
    {
        this.inventoryManager = inventoryManager;
    }

    public void Consume()
    {
        inventoryManager.ConsumeItem(this);
    }
    public void SetItem(Item item)
    {
        this.item = item;

        if (item.GetSprite() != null)
        {
            GetComponent<Button>().image.sprite = item.GetSprite();
        }
    }

    public Item GetItem()
    {
        return item;
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

    private void OnDestroy()
    {
        inventoryManager.ShowItemDescription("");
    }

}
