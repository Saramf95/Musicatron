using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntuacion : MonoBehaviour
{
    public static Puntuacion instance;

    private int puntuacion;
    [SerializeField]
    private TextMeshProUGUI textoPuntuacion;


    private void Awake()
    {
        instance = this;
    }

    public void SumarPuntos()
    {
        puntuacion++;
        textoPuntuacion.text = "Puntuación: " + puntuacion.ToString();
    }

    public int GetPuntuacion()
    {
        return puntuacion;
    }
}
