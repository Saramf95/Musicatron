using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class MenuManager : MonoBehaviour
{
    [SerializeField]                         //Mostrar una bariable privada en inspector
    private GameObject listaJugadoresMenu;
    [SerializeField]
    private GameObject crearJugadorMenu;
    [SerializeField]
    private TMP_InputField nombreJugador;
    public Button[] PlayerButons;
    GameManager gameManager;
    int cursorToCreate;
    void Start()
    {
        listaJugadoresMenu.SetActive(true);
        crearJugadorMenu.SetActive(false);
        gameManager = FindObjectOfType<GameManager>();

        for (int i = 0; i < PlayerButons.Length; i++) {//carga los botones la información del texto que tiene que reflejar
            if (gameManager.playerData[i] != null)     //mientras no sea nulo no carga nada y cuando hay algo carga el nombre
            {
                PlayerButons[i].GetComponentInChildren<TextMeshProUGUI>().text = gameManager.playerData[i].Player;  //Carga el nombre del jugador en el boton 
                PlayerButons[i].GetComponent<ButtonPlayer>().playerDataCursor = i;  //Carga el cursor en el boton (el orden del jugadoren el menu)
            }
            else
            {
                PlayerButons[i].GetComponentInChildren<TextMeshProUGUI>().text = "Nuevo Jugador"; //Si no tiene datos se queda como nuevo jugador
                PlayerButons[i].GetComponent<ButtonPlayer>().playerDataCursor = i; //Carga el cursor en el boton
            }
        }
    }
    public void CrearNuevo(int cursor) //Cambia la vista del menu de jugadores al menu de escribir el nombre del jugador
    {
        cursorToCreate = cursor;
        listaJugadoresMenu.SetActive(false);
        crearJugadorMenu.SetActive(true);
    }

    public void confirmarNuevo()//Carga y crea el nuevo jugador. Y genera el archivo de cada jugador.
    {
        PlayerData playerData = new PlayerData();
        DataManager dataManager = new DataManager();

        playerData.Player = nombreJugador.text; 
        gameManager.playerData[cursorToCreate] = playerData; 
        gameManager.ActualPlayer = gameManager.playerData[cursorToCreate];

        dataManager.setDataPlayerFile(playerData, (NPlayer)cursorToCreate);

        //CARGAR SIGUIENTE ESCENA

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
