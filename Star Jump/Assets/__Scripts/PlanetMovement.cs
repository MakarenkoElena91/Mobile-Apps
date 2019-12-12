using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlanetMovement : MonoBehaviour
{
    public float degreesPerSecond = 15.0f;
    public float amplitude = 0.5f;
    public float frequency = 1f;

    // Position Storage Variables
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();


    void Start()
    {
        // Store the starting position & rotation of the object
        posOffset = transform.position;
    }
    void FixedUpdate()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Level1")
        {
            transform.Translate(Random.Range(-1f, -9f) * Time.deltaTime, 0, 0);
        }
        else if (scene.name == "Level2")
        {
            transform.Translate(-3 * Time.deltaTime, 0, 0);
        }
        else
        {
            // Float up/down with a Sin()
            //tempPos = posOffset;
            tempPos = posOffset;
            tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

            tempPos.x = transform.position.x + (-3 * Time.deltaTime);

            transform.position = tempPos;
        }
    }
}
