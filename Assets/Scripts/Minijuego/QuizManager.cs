using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour             
{
    public List<PreguntasRespuestas> QnA;  // Almacena distintos tipos de preguntas (sonido y posición del array correcto)
    public GameObject[] options;           //Almacena las notas, el array tiene que coincidir con la lista anterior.
    public int currentQuestion;           //Pregunta actual (la nota que está sonando)
    public AudioSource audioSource;       //Elemento que emite el sonido
    GameManager gm;
    public TMP_Text QuestionTxt;          //Texto de la pregunta.
    public int nAnswer=0;
    private void Start()                          //
    {
        gm = FindObjectOfType<GameManager>();
        nAnswer = gm.ActualPlayer.Level;
        generateQuestion(); 
    }
    public void incorrect()
    {
        nAnswer++;
        if (nAnswer > 10)
        {
            SceneManager.LoadScene("Inicio");
        }
        else
        {
            gm.ActualPlayer.Level = nAnswer;
            generateQuestion();
        }
    }

    public void correct()
    {

        nAnswer++;
        gm.ActualPlayer.CorrectasMManu++;
        if(nAnswer>10) {

        }
        else
        {
            gm.ActualPlayer.Level = nAnswer;
        generateQuestion();
        }
    }
    void SetAnswers()                    //Determina si la respuesta es correcta o incorrecta. (Se comunica con el botón)
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
           

            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }
    public void ReproducirSonido()            //Reproduce la nota
    {
        audioSource.Play();
    }
    void generateQuestion()                    //Genera una new pregunta, en este caso pasa a la siguiente nota
    {
        currentQuestion = Random.Range(0, QnA.Count);
        audioSource.clip = QnA[currentQuestion].Question;
        ReproducirSonido();
        SetAnswers();
    }


}
