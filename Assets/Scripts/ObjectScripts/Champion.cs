using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "TFT Objects/Champion")]
public class Champion : ScriptableObject
{
    public new string name;
    public int goldCost;
    public int health;
    public int attackDamage;
    public bool inPossession;
    public Sprite splashArt;
}
