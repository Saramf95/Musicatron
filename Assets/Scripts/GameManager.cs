using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerData[] playerData = new PlayerData[3];
    [HideInInspector]
    public PlayerData ActualPlayer;
    DataManager dataManager;
    public int cursorPlayer;
    private void Awake()
    {
        
        DontDestroyOnLoad(gameObject);
        dataManager = new DataManager();
        for (int i = 0; i < playerData.Length; i++)
        {
            playerData[i] = dataManager.getDataPlayerFile((NPlayer)i);
        }
    }
    public void UpdateData()
    {
        dataManager.setDataPlayerFile(ActualPlayer, (NPlayer)cursorPlayer);
    }

}
