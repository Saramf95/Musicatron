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
    QuizManager quizManager;
    private void Awake()
    {
        quizManager = FindObjectOfType<QuizManager>();
    }


    private void Update()
    {
        textoPuntuacion.text = " Pregunta N" + quizManager.nAnswer.ToString()+ "    Acertadas "+ quizManager.gm.ActualPlayer.CorrectasMManu;
    }
}
