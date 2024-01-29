using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ControlVolumenGeneral : MonoBehaviour
{
    [SerializeField] private AudioMixer VolumenGeneral;

    public void ControlVolumen(float sliderVolumen)
    {
        VolumenGeneral.SetFloat("VolumenGeneral", Mathf.Log10(sliderVolumen) * 20);
    }

}
