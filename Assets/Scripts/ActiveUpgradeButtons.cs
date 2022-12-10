using UnityEngine;

public class ActiveUpgradeButtons : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject[] upgradeButtons;

    public void ActiveFalse()
    {
        for (int i = 0; i < upgradeButtons.Length; i++)
        {
            upgradeButtons[i].SetActive(false);
        }
    }
}
