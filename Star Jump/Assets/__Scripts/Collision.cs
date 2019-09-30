using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

// Create a box sprite which falls and hits a floor sprite.  The box can be moved/animated
// with the up, left, right, and down keys.  Moving the box sprite upwards and letting it
// fall will increate the number of calls from OnCollisionEnter2D.

public class Collision : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField]
    private ParticleSystem particleSystem;
    private SpriteRenderer render;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        render = gameObject.GetComponentInChildren<SpriteRenderer>();
    }

    // called when the cube hits the floor
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Planet"){
            //Debug.Log("Planet");
            particleSystem.transform.position = rb2d.position;
            particleSystem.gameObject.SetActive(true);
            particleSystem.Play();
            StartCoroutine(delay(0.5f));
            //Time.timeScale = 0.2f;
            render.enabled = false;
        }
        Debug.Log("OnCollisionEnter2D");
    }

    IEnumerator delay(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("GameOver",  LoadSceneMode.Single);
    }
}