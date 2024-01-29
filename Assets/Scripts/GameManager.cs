using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerData[] playerData = new PlayerData[3];
    [HideInInspector]
    public PlayerData ActualPlayer;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        DataManager dataManager = new DataManager();
        for (int i = 0; i < playerData.Length; i++)
        {
            playerData[i] = dataManager.getDataPlayerFile((NPlayer)i);
        }
    }

    
}
