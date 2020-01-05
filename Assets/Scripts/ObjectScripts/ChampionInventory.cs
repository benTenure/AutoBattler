using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TFT Objects/Champion inventory")]
public class ChampionInventory : ScriptableObject
{
    public List<Champion> inventory;

    public void AddChamp(Champion champ)
    {
        inventory.Add(champ);
        Debug.Log($"Successfully added {champ.name} to inventory.");
    }

    public void RemoveChamp(Champion champ)
    {
        if (inventory.Count > 0)
        {
            var message = inventory.Remove(champ)
                ? $"{champ.name} was removed from inventory"
                : $"{champ.name} was not removed from inventory";
            
            Debug.Log(message);
        }
    }

    public void PrintInventory()
    {
        Debug.Log($"Total number of champs in inventory is {inventory.Count}");
        
        foreach (var champ in inventory)
        {
            Debug.Log($"Champion: {champ.name}");
        }
    }
}
