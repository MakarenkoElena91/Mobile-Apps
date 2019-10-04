using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
    [SerializeField]
    private float speed = 0; //Floating point variable to store the player's movement speed.
    private Rigidbody2D rb2d; //Store a reference to the Rigidbody2D component required to use 2D Physics.

    // Use this for initialization
    void Start () {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D> ();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate () {
        //Store the current vertical input in the float moveVertical.

        if (Input.GetKeyDown (KeyCode.Space)) {
            GetComponent<Rigidbody2D> ().velocity = Vector3.up * speed;
        }

//touch tap on mobile phone
        if (Input.touchCount > 0){//detects if the screen was touched
            Touch touch = Input.GetTouch(0);//detect just the 1st touch
            if(touch.phase.Equals(TouchPhase.Began)){//when the current touch began, when I touched the screen, only then jump
                GetComponent<Rigidbody2D> ().velocity = Vector3.up * speed;
            }     
        }    
    }
    void JumpMovement () {
            GetComponent<Rigidbody2D> ().velocity = Vector3.up * speed;
        }
}