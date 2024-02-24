
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena   : MonoBehaviour
{

    public void Escenas(string CambioEscena)
    {
        SceneManager.LoadScene(CambioEscena);
    }
}
