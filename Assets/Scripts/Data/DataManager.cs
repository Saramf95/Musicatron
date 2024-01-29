using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

public class DataManager 
{
   
    public PlayerData getDataPlayerFile(NPlayer nPlayer)    //Busca el fichero del jugador con el identificador NPlayer
    {
        PlayerData data = new PlayerData();                 //Guarda los datos del player            
        string saveFile = Application.persistentDataPath + "/"+ nPlayer.ToString()+".json";// Genera la ruta donde están los datos y abance de cada usuario
        if (File.Exists(saveFile))                              //Compreueba si el archivo existe
        {
            string dataJson = File.ReadAllText(saveFile);        //Lee el archivo y lo carga en un string        
            data = JsonUtility.FromJson<PlayerData>(dataJson);   //Interpreta el string como un Json y lo convierte en PlayerData (No cambiar NUNCA nada del PlayerData)
        }
        else
        {
            data = null;                                         //cuando el archivo no existe...
        }
        return data;                                             
    }
    public void setDataPlayerFile(PlayerData data, NPlayer nPlayer)    //Para guardar los datos
    {
        string saveFile = Application.persistentDataPath + "/" + nPlayer.ToString() + ".json";  //Convierte una clase a Json
        string jsonData = JsonUtility.ToJson(data);                                             //
        File.WriteAllText(saveFile, jsonData);                                                  //Guarda el archivo
    }
    public void deletePlayerFile(NPlayer nPlayer)    //Para borrar un archivo
    {
        string saveFile = Application.persistentDataPath + "/" + nPlayer.ToString() + ".json";//Convierte una clase a Json
        File.Delete(saveFile);
    }
}
public enum NPlayer   //Lista de Players
{
    Player1, 
    Player2, 
    Player3,
}