using UnityEngine;
using System.Collections.Generic;
using TMPro;
public class InventoryManager : MonoBehaviour
{
    private List<ItemManager> inventory = new List<ItemManager>();
    [SerializeField] private int maxItemCount;
    [SerializeField] private GameObject inventoryPanel;
    [SerializeField] private GameObject itemPrefab;
    [SerializeField] private TMP_Text inventoryStatusText;
    [SerializeField] private TMP_Text itemDescriptionText;

    [SerializeField] private CharacterManager characterManager;

    private int usedSlots;
    public void AddItem(Item item)
    {
        if (inventory.Count < maxItemCount)
        {
            GameObject itemGameObject = Instantiate(itemPrefab, inventoryPanel.transform);
            
            ItemManager itemManager = itemGameObject.GetComponent<ItemManager>();
            itemManager.SetItem(item);
            itemManager.SetInventoryManager(this);
            
            inventory.Add(itemManager);
            
            usedSlots++;
        }

        UpdateInventoryStatusText();

    }

    public void ConsumeItem(ItemManager itemManager)
    {
        characterManager.UseItem(itemManager.GetItem());
        inventory.Remove(itemManager);
        Destroy(itemManager.gameObject);
        
        usedSlots--;
        UpdateInventoryStatusText();
        
        
    }

    private void UpdateInventoryStatusText()
    {
        inventoryStatusText.text = $"Weight: {CalculateInventoryWeight()} - Value: {CalculateInventoryValue()} - {usedSlots}/20 Slots used";
    }

    private int CalculateInventoryWeight()
    {
        int weight = 0;
        foreach (ItemManager itemManager in inventory)
        {
            weight += itemManager.GetItem().GetWeight();
        }
        
        return weight;
    }

    private int CalculateInventoryValue()
    {
        int value = 0;
        foreach (ItemManager itemManager in inventory)
        {
            value += itemManager.GetItem().GetValue();
        }
        
        return value;
    }

    public void ShowItemDescription(string description)
    {
        itemDescriptionText.text = description;
    }
    
}
