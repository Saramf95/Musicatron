using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerData[] playerData = new PlayerData[3];

    private void Awake()
    {
        DataManager dataManager = new DataManager();
        for (int i = 0; i < playerData.Length; i++)
        {
            playerData[i] = dataManager.getDataPlayerFile((NPlayer)Enum.GetValues(typeof(NPlayer)).GetValue(i));
        }
    }
}
