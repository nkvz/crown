using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObject : MonoBehaviour
{
    [Header("Set in Inspector")]
    public ObjectsData objectData;
    public GameObject WindowUpgrade;
    public UpgradeOOP upgradeOOP;
    public bool Selected;

    public void SelectingObject()
    {
        upgradeOOP.objectsData = objectData;
        upgradeOOP.UpdText();
    }
}
