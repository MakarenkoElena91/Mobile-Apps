﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour {
    public Text timerText;
    private float secondsCount;
   
    void Update () {
        UpdateTimerUI ();
    }
    //call this on update
    public void UpdateTimerUI () {
        //set timer UI
        secondsCount += Time.deltaTime;
        timerText.text = "" + (int) secondsCount;
    }
}