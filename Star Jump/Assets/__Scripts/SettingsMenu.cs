using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour {
    public Color color;
    public float r, b, g, a;
    public float volume;

    public AudioMixer mixer;

    // //Called when Slider is moved
    public void SetVolume(float sliderValue)
    {
        mixer.SetFloat("Music", Mathf.Log10(sliderValue) * 20);
        //Debug.Log (sliderValue);
    }
   
    public void SetColor (float r, float b, float g, float a) {
        //Debug.Log ("color");
        color = new Color (r, b, g, a);
        //star.material.SetColor ("_Color", Color.color);
    }

}