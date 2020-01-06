using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    private const int INVENTORY_SIZE = 50;
    private const int NUM_OF_SLOTS = 5;
    
    public ChampionInventory mainInventory;
    public ChampionInventory playerInventory;

    [Header("Temporary Databases")]
    public ChampionPool commonDatabase;
    public ChampionPool uncommonDatabase;
    public ChampionPool rareDatabase;
    public ChampionPool epicDatabase;
    public ChampionPool legendaryDatabase;
    
    // Apparently, it's not worth it to instantiate SO's at runtime since that defeats
    // the purpose of using 'ScriptableObjects'. While it does look a little ugly in
    // the editor, I suppose that doesn't matter once the game is built.
    [Header("In-Game Champion Pools")]
    public ChampionPool commonPool;
    public ChampionPool uncommonPool;
    public ChampionPool rarePool;
    public ChampionPool epicPool;
    public ChampionPool legendaryPool;
    
    [Header("")]
    public Player player;

    [Header("Champion Slots")]
    public List<TextMeshProUGUI> buttonNames;
    public List<TextMeshProUGUI> buttonCosts;
    public List<Image> buttonSplashes;

    private void Start()
    {
        // Only done for testing in-editor, not necessary for build
        mainInventory.inventory.Clear();
        playerInventory.inventory.Clear();
        commonPool.pool.Clear();
        uncommonPool.pool.Clear();
        rarePool.pool.Clear();
        epicPool.pool.Clear();
        legendaryPool.pool.Clear();

        PopulateInventory();
        PopulateShop();
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
                commonPool.pool.Add(commonDatabase.ReturnRandomObject());
            }
            else if (TestRange(choice, 36, 65))
            {
                // Return 2-cost champ
                uncommonPool.pool.Add(uncommonDatabase.ReturnRandomObject());
            }
            else if (TestRange(choice, 66, 85))
            {
                // Return 3-cost champ
                rarePool.pool.Add(rareDatabase.ReturnRandomObject());
            }
            else if (TestRange(choice, 86, 95))
            {
                // Return 4-cost champ
                epicPool.pool.Add(epicDatabase.ReturnRandomObject());
            }
            else
            {
                // Return 5 or greater cost champ
                legendaryPool.pool.Add(legendaryDatabase.ReturnRandomObject());
            }
        }
    }

    public void PopulateShop()
    {
        // Need to do this once for each champion slot in the shop
        for (var i = 0; i < 5; i++)
        {
            // Uh oh
            Champion champ;
            
            // Find a random number
            var choice = Random.Range(1, 100);

            // Choose a champ in that range
            if (TestRange(choice, 1, 35))
            {
                // Return 1-cost champ
                champ = commonPool.ReturnRandomObject();
            }
            else if (TestRange(choice, 36, 65))
            {
                // Return 2-cost champ
                champ = uncommonPool.ReturnRandomObject();
            }
            else if (TestRange(choice, 66, 85))
            {
                // Return 3-cost champ
                champ = rarePool.ReturnRandomObject();
            }
            else if (TestRange(choice, 86, 95))
            {
                // Return 4-cost champ
                champ = epicPool.ReturnRandomObject();
            }
            else
            {
                // Return 5 or greater cost champ
                champ = legendaryPool.ReturnRandomObject();
            }

            /*
             * MAKE SURE TO CHANGE THE BOOLEAN ON THE CHAMP CHOSEN!!
             *   - Pass champions by reference?
             *   - Store the index that is used to get to the originally referenced champ?
             *   - Why is passing ref's giving me so much trouble in C#??? I miss pointers...
             */

            // Change attributes of the button
            buttonNames[i].text = champ.name;
            buttonCosts[i].text = $"{champ.goldCost}";
            buttonSplashes[i].sprite = champ.splashArt;
        }
    }
}
