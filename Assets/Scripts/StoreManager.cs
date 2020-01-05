using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StoreManager : MonoBehaviour
{
    private const int INVENTORY_SIZE = 50;
    
    public ChampionInventory mainInventory;
    public ChampionInventory playerInventory;

    public ChampionPool commonPool;
    public ChampionPool uncommonPool;
    public ChampionPool rarePool;
    public ChampionPool epicPool;
    public ChampionPool legendaryPool;
    
    public Player player;
    
    [Header("Champion Slot 1")]
    public TextMeshPro name1;
    public TextMeshPro cost1;
    public Sprite splash1;
    
    [Header("Champion Slot 2")]
    public TextMeshPro name2;
    public TextMeshPro cost2;
    public Sprite splash2;
    
    [Header("Champion Slot 3")]
    public TextMeshPro name3;
    public TextMeshPro cost3;
    public Sprite splash3;
    
    [Header("Champion Slot 4")]
    public TextMeshPro name4;
    public TextMeshPro cost4;
    public Sprite splash4;
    
    [Header("Champion Slot 5")]
    public TextMeshPro name5;
    public TextMeshPro cost5;
    public Sprite splash5;

    private void Start()
    {
        mainInventory.inventory.Clear();
        playerInventory.inventory.Clear();
        PopulateInventory();
        //PopulateShop();
    }

    private bool TestRange(int test, int min, int max)
    {
        return test >= min && test <= max;
    }
    
    private void PopulateInventory()
    {
        for (var i = 0; i < INVENTORY_SIZE; i++)
        {
            // Find a random number
            var choice = Random.Range(1, 100);

            // Choose a champ in that range
            if (TestRange(choice, 1, 35))
            {
                // Return 1-cost champ
                mainInventory.AddChamp(commonPool.ReturnRandomObject());
            }
            else if (TestRange(choice, 36, 65))
            {
                // Return 2-cost champ
                mainInventory.AddChamp(uncommonPool.ReturnRandomObject());
            }
            else if (TestRange(choice, 66, 85))
            {
                // Return 3-cost champ
                mainInventory.AddChamp(rarePool.ReturnRandomObject());
            }
            else if (TestRange(choice, 86, 95))
            {
                // Return 4-cost champ
                mainInventory.AddChamp(epicPool.ReturnRandomObject());
            }
            else
            {
                // Return 5 or greater cost champ
                mainInventory.AddChamp(legendaryPool.ReturnRandomObject());
            }
        }
    }

    private void PopulateShop()
    {
        // Need to do this once for each champion slot in the shop
        for (var i = 0; i < 5; i++)
        {
            // Find a random number
            var choice = Random.Range(1, 100);

            // Choose a champ in that range
            if (TestRange(choice, 1, 35))
            {
                // Return 1-cost champ
                mainInventory.AddChamp(commonPool.ReturnRandomObject());
            }
            else if (TestRange(choice, 36, 65))
            {
                // Return 2-cost champ
                mainInventory.AddChamp(uncommonPool.ReturnRandomObject());
            }
            else if (TestRange(choice, 66, 85))
            {
                // Return 3-cost champ
                mainInventory.AddChamp(rarePool.ReturnRandomObject());
            }
            else if (TestRange(choice, 86, 95))
            {
                // Return 4-cost champ
                mainInventory.AddChamp(epicPool.ReturnRandomObject());
            }
            else
            {
                // Return 5 or greater cost champ
                mainInventory.AddChamp(legendaryPool.ReturnRandomObject());
            }
            
            // Choose which pool to pull from
            
            // Change appropriate aspects of the champion slot that matches the current loop index
        }
    }
}
