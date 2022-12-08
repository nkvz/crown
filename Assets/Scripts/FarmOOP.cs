using UnityEngine;

public class FarmOOP : MonoBehaviour
{
    [Header("Set in Inspector")]
    public PlayerData playerData;
    public ObjectsData objectsData;

    private void Start()
    {
        Invoke("Farming", 0.1f);
    }

    public void Farming()
    {
        objectsData.Farm();
        playerData.UpdTextResources();
        Invoke("Farming", 1f);
    }
}
