using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Experimental.Audio;

public class CharacterManager : MonoBehaviour
{
    [SerializeField] private Slider healthSlider;
    [SerializeField] private Slider manaSlider;
    [SerializeField] private TMP_Text attackDamageText;
    [SerializeField] private TMP_Text defenseText;
    [SerializeField] private Image weaponImage;
    [SerializeField] private Image[] armorImages;

    private int health;
    private int mana;
    private int defense;
    private Weapon weapon;
    private List<Armor> armorSet = new List<Armor>();

    public void UseItem(Item item)
    {
        if (item is Consumable)
        {
            Consume((Consumable)item);
        }
        else if (item is Weapon)
        {
            SetWeapon((Weapon)item);
        }
        else if (item is Armor)
        {
            SetArmor((Armor)item);
        }
    }

    private void Consume(Consumable consumable)
    {
        health += consumable.GetHealth();
        healthSlider.value = health;
        mana += consumable.GetMana();
        manaSlider.value = mana;
    }

    private void SetWeapon(Weapon weapon)
    {
        this.weapon = weapon;
        attackDamageText.text = $"Attack: {weapon.GetDamage()}";
        weaponImage.sprite = weapon.GetSprite();
    }

    private void SetArmor(Armor armor)
    {
        armorSet.Add(armor);
        if (armorSet.Count > 3)
        {
            armorSet.RemoveAt(0);
        }

        defense = 0;
        for (int i = 0; i < armorSet.Count; i++)
        {
            defense += armorSet[i].GetDefense();
            armorImages[i].sprite = armorSet[i].GetSprite();
        }
        
        defenseText.text = $"Defense: {defense}";
    }

}
