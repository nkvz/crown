using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    [Header("Set in Inspector")]
    public PlayerData playerData;

    public void ResetData()
    {
        playerData.goldData.amount = 0;
        playerData.goldData.lvlObject = 1;

        playerData.woodData.amount = 0;
        playerData.woodData.lvlObject = 0;

        playerData.stoneData.amount = 0;
        playerData.stoneData.lvlObject = 0;

        playerData.peopleData.amount = 0;
        playerData.peopleData.lvlObject = 0;

        playerData.crystalData.amount = 0;
        playerData.crystalData.lvlObject = 0;

        playerData.UpdTextResources();
    }
}
