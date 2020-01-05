using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TFT Objects/Champion Pool")]
public class ChampionPool : ScriptableObject
{
    public List<Champion> pool;

    public Champion ReturnRandomObject()
    {
        return pool[Random.Range(0, pool.Count - 1)];
    }
}
