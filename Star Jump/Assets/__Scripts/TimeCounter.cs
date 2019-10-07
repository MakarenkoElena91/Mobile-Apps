// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class TimeCounter : MonoBehaviour {
//     public Text timerText;
//     private float secondsCount;
//     public float timeLeft = 3.0f;

//     void Update () {
//         timeLeft -= Time.deltaTime;

//         UpdateTimerUI ();

//     }
//     //call this on update
//     public void UpdateTimerUI () {
//         if (timeLeft < 0) {
//             //set timer UI
//             secondsCount += Time.deltaTime;
//             timerText.text = "" + (int) secondsCount;
//         } else timerText.text = "0";

//     }
// }