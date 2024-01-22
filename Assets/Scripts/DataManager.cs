using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

public class DataManager 
{
   
    public PlayerData getDataPlayerFile(NPlayer nPlayer)
    {
        PlayerData data = new PlayerData();
        string saveFile = Application.persistentDataPath + "/"+ nPlayer.ToString()+".json";// Guarda los datos y abance de cada usuario
        if (File.Exists(saveFile))
        {
            string dataJson = File.ReadAllText(saveFile);
            data = JsonUtility.FromJson<PlayerData>(dataJson);
        }
        else
        {
            data = null;
        }
        return data;
    }
    public void setDataPlayerFile(PlayerData data, NPlayer nPlayer)
    {
        string saveFile = Application.persistentDataPath + "/" + nPlayer.ToString() + ".json";
        string jsonData = JsonUtility.ToJson(data);
        File.WriteAllText(saveFile, jsonData);
    }
    public void deletePlayerFile(NPlayer nPlayer)
    {
        string saveFile = Application.persistentDataPath + "/" + nPlayer.ToString() + ".json";
        File.Delete(saveFile);
    }
}
public enum NPlayer
{
    Player1, 
    Player2, 
    Player3,
}