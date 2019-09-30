using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlanetMovement : MonoBehaviour
{
    void FixedUpdate()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Level3"){
            transform.Translate(Random.Range(-2f, -9f) * Time.deltaTime, 0, 0);
        }else
        {
            transform.Translate(-3 * Time.deltaTime, 0, 0);
        }
    }
}
