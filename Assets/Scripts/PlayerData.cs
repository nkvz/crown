using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
    [Header("Texts Resources")]
    public Text gold;
    public Text wood;
    public Text stone;
    public Text people;
    public Text crystal;
    
    [Header("ObjectsData")]
    public ObjectsData goldData;
    public ObjectsData woodData;
    public ObjectsData stoneData;
    public ObjectsData peopleData;
    public ObjectsData crystalData;

    public void Start()
    {
        UpdTextResources();
    }

    public void UpdTextResources()
    {
        gold.text = goldData.amount.ToString();
        wood.text = woodData.amount.ToString();
        stone.text = stoneData.amount.ToString();
        people.text = peopleData.amount.ToString();
        crystal.text = crystalData.amount.ToString();
    }
}
