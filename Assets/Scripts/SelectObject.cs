using UnityEngine;

public class SelectObject : MonoBehaviour
{
    [Header("Set in Inspector")]
    public ObjectsData objectData;
    public GameObject goUpgrade;
    public UpgradeOOP upgradeOOP;

    public GameObject[] goUpgradess;

    public void SelectingObject()
    {
        for (int i = 0; i < goUpgradess.Length; i++)
        {
            goUpgradess[i].SetActive(false);
        }

        upgradeOOP.objectsData = objectData;
        goUpgrade.SetActive(true);
    }
}
