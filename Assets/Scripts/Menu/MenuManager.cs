using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public Button[] PlayerButons;
    GameManager gameManager;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        for (int i = 0; i < PlayerButons.Length; i++) {
            if (gameManager.playerData[i] != null)
            {
                PlayerButons[i].GetComponentInChildren<TextMeshProUGUI>().text = gameManager.playerData[i].Player;
                PlayerButons[i].GetComponent<ButtonPlayer>().playerDataCursor = i;
            }
            else
            {
                PlayerButons[i].GetComponentInChildren<TextMeshProUGUI>().text = "Nuevo Jugador";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
