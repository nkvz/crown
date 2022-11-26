using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeOOP : MonoBehaviour
{
    [Header("Set in Inspector")]
    public PlayerData playerData;
    public ObjectsData objectsData;

    [Header("Texts")]
    public Text NameObject;
    public Text lvlObject;

    private void Start()
    {
        UpdText();
    }

    public void Upgrade()
    {
        if(playerData.goldData.amount > objectsData.priceUpgrade)
        {
            playerData.goldData.amount -= objectsData.priceUpgrade;
            objectsData.lvlObject++;
            UpdText();
            playerData.UpdTextResources();
        }
    }

    public void UpdText()
    {
        NameObject.text = objectsData.name;
        lvlObject.text = objectsData.lvlObject.ToString();
    }
}