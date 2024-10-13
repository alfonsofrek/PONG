using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine...;

public class Bolanueva : MonoBehaviour
{
    private Rigidbody2D ballRb;

    [SerializeField] private float veloI = 4f;
    [SerializeField] private float MultiV = 1.1f;
    // Start is called before the first frame updaMute
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        Launch();

    }
    private void Launch()
    {
        float xVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        float yVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        ballRb.velocity = new Vector2(xVelocity, yVelocity) * veloI;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("palas"))
        {
            ballRb.velocity *= MultiV;

        }
        if (collision.gameObject.CompareTag("goal"))
        {
            transform.position = new Vector3(0, 0, 0);
            float xVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
            float yVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
            ballRb.velocity = new Vector2(xVelocity, yVelocity) * veloI;
         
            GameManger.Instance.RestartGame();
            lose();

        }
        if (collision.gameObject.CompareTag("Goal2"))
        {
           
            GameManger.Instance.palaIscored();

            
        }

    }
    public void lose()
    {
        SceneManager.LoadScene("MenuInicial");
    }

    void Update()
    {

    }
}
