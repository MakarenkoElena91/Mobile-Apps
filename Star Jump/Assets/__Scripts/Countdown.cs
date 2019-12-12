using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    public float timeLeft = 3.0f;
    public TMP_Text startText; // used for showing countdown from 3, 2, 1 
    // public TMP_Text score;
    public GameObject player;
    public GameObject pauseMenu;
    void Start () {
        player.GetComponent<Rigidbody2D> ().bodyType = RigidbodyType2D.Static;
       // pauseMenu.SetActive(false);
    }

    void Update () {
        timeLeft -= Time.deltaTime;
        startText.text = "Tap to Jump in " + Mathf.Ceil(timeLeft);//start countdown from 3
        
        if (timeLeft <= 0) {
            player.GetComponent<Rigidbody2D> ().bodyType = RigidbodyType2D.Dynamic;
            startText.enabled = false;
            gameObject.GetComponent<Countdown> ().enabled = false;
        }
    }
}