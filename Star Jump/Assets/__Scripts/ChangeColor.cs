using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    private Color color = new Color(255, 218, 0, 255);
    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = PlayerPrefs.GetInt("Counter", 3);
        SetColor();
        ApplyColor();
    }

    public void CallAll(){
        SetCounter();
        SetColor();
        ApplyColor();
    }
    // Update is called once per frame
    public void SetCounter()
    {
        counter++;

        if(counter > 3){
            counter = 1;
        }

        PlayerPrefs.SetInt("Counter", counter);
    }

    public void SetColor(){
        switch (counter){
            case 1: //Red
                color.r = 255;
                color.g = 0;
                color.b = 0;
                break;
            case 2: //Green
                color.r = 0;
                color.g = 255;
                color.b = 0;
                break;
            case 3: //Yellow
                color.r = 255;
                color.g = 218;
                color.b = 0;
                break;
            default:
                color.r = 255;
                color.g = 218;
                color.b = 0;
                color.a = 255;
                break;
        }
    }

    public void ApplyColor(){
        if(gameObject.tag == "Player"){
            gameObject.GetComponent<SpriteRenderer>().color = color;
        } else if(gameObject.tag == "Button") {
            gameObject.GetComponent<Image>().color = color;
        }
    }
 
}
