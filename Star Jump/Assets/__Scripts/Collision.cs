using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

// Create a box sprite which falls and hits a floor sprite.  The box can be moved/animated
// with the up, left, right, and down keys.  Moving the box sprite upwards and letting it
// fall will increate the number of calls from OnCollisionEnter2D.

public class Collision : MonoBehaviour {
    private Rigidbody2D rb2d; //star
    [SerializeField]
    private ParticleSystem particleSystem;
    private SpriteRenderer render;
    public GameObject camera;
    public SoundEffect soundEffect;

    void Start () {
        rb2d = GetComponent<Rigidbody2D> ();
        render = gameObject.GetComponentInChildren<SpriteRenderer> ();
    }

    void OnCollisionEnter2D (Collision2D col) {
        if (col.gameObject.tag == "Planet" || col.gameObject.tag == "Ground") {
            doStuffOnCollision ();
        }
        //Debug.Log ("OnCollisionEnter2D");
    }

    public void doStuffOnCollision () {
        camera.GetComponent<ScoreManager>().SetScores();
        ScoreManager.GetScores();

        particleSystem.transform.position = rb2d.position;
        particleSystem.gameObject.SetActive (true);
        particleSystem.Play ();
        StartCoroutine (delay (2f));
        //Time.timeScale = 0.2f;//slow motion?
        render.enabled = false;
        gameObject.GetComponent<PolygonCollider2D> ().enabled = false;
        soundEffect.PlayCollision();
    }
    IEnumerator delay (float seconds) {
        yield return new WaitForSeconds (seconds);
        SceneManager.LoadScene ("GameOver", LoadSceneMode.Single);
    }
}