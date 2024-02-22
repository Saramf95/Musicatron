using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador : MonoBehaviour
{
    private int puntaje = 0;
    private int preguntasContestadas = 0;
    private const int totalPreguntas = 10;

    public void ManejarRespuesta(bool esCorrecta)
    {
        if (esCorrecta)
        {
            puntaje++;
        }

        preguntasContestadas++;

        if (preguntasContestadas >= totalPreguntas)
        {
            SceneManager.LoadScene("EscenaResultados");
        }
    }

}