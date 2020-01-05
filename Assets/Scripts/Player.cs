using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const int MAX_NUM_OF_CHAMPS = 10;
    
    public IntegerVariable playerGold;
    public IntegerVariable playerXP;
    public IntegerVariable playerLevel;
    public ChampionInventory playerInventory;

    private void Start()
    {
        // Initialize everything for start of the game. (Object doesn't disappear until game is over)
        playerGold.value = 0;
        playerXP.value = 0;
        playerLevel.value = 1;
        playerInventory.inventory.Clear();
    }

    public void BuyExperience(int expAmount)
    {

    }
    
    
}
