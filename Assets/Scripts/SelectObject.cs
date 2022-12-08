using UnityEngine;

public class SelectObject : MonoBehaviour
{
    [Header("Set in Inspector")]
    public ObjectsData objectData;
    public GameObject windowUpgrade;
    public UpgradeOOP upgradeOOP;
    public ButtonExitWIndow exitWindow;

    public void SelectingObject()
    {
        upgradeOOP.objectsData = objectData;
        upgradeOOP.UpdText();
        exitWindow.thisWindow.SetActive(true);
        exitWindow.exitWindow.SetActive(true);
    }
}
