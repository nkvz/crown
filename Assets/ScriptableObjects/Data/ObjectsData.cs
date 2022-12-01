using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ObjectsData", menuName = "ObjectsData")]
public class ObjectsData : ScriptableObject
{
    [Header("Set in Inspector")]
    public Sprite minionImage;
    public string nameObject;
    public int amount;
    public int lvlObject;
    public int enumScale;
    public int priceUpgrade;

    public void Farm()
    {
        amount += (1 * lvlObject) * enumScale;
    }
}
