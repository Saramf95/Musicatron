using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectLevel : MonoBehaviour
{
    public Button[] NivelBoton;
    void Start()
    {
        DesbloquearNiveles();
    }

    void DesbloquearNiveles()
    {

        if (PlayerPrefs.HasKey("Puntuacion"))
        {
            int puntuacion = PlayerPrefs.GetInt("Puntuacion");

            //Desbloquear niveles en base a la puntuacion
            for (int i = 1; i < NivelBoton.Length; i++)
            {
                if (puntuacion >= i * 5) //Desbloquear nivel si la puntuacion es igual o mayor a i*5
                {
                    NivelBoton[i].interactable = true;
                }

                else
                {
                    NivelBoton[i].interactable = false;
                }
            }
        }
        else
        {
            //si es la primera vez que juega, desbloquear solo el nivel 1
            PlayerPrefs.SetInt("Puntuacion", 0);
            NivelBoton[1].interactable = false;
        }
    }

    public void GuardarPuntuacion(int puntuacion)
    {
        PlayerPrefs.SetInt("Puntuacion", puntuacion);
        DesbloquearNiveles();
    }

    
}
