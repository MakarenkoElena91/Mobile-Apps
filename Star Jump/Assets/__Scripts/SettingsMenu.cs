using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour {
    public Color color;
    public float r, b, g, a;
    public float volume;

    public void SetColor (float r, float b, float g, float a) {
        //Debug.Log ("color");

        color = new Color (r, b, g, a);
        //star.material.SetColor ("_Color", Color.color);
    }

    public void SetVolume (float volume) {
        volume = volume+1.0f;
        Debug.Log (volume);

    }

    public void Update(){
        //SetVolume();
    }
}