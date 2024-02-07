using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlayer : MonoBehaviour    
{
    [HideInInspector]                   //Para ocultar la información en el editor, para que no moleste
    public int playerDataCursor;        //Nos indica la posición que tiene cada jugador en el menu de perfil
    MenuManager menuManager; 
    private void Start()
    {
        menuManager = FindObjectOfType<MenuManager>();   //Busca MenuManager en la escena
    }
    public void AccionButton()
    {
        if (GetComponentInChildren<TextMeshProUGUI>().text == "Nuevo Jugador") //Busca un componente dentro dle GameObject, concretamente en el apartado de texto
        {
            menuManager.CrearNuevo(playerDataCursor);                          //Crea nuevo jugador
        }
        else
        {
            GameManager gm = FindObjectOfType<GameManager>();                  //Busca el game manager en la escena
            gm.ActualPlayer = gm.playerData[playerDataCursor];                 //Carga los datos del jugador
            SceneManager.LoadScene("MinijuegoManu");
           
        }
    }
}
