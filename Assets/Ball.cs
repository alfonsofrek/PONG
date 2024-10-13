using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine...;

public class Ball : MonoBehaviour
{
    private Rigidbody2D ballRb;
    public AudioClip tone;
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
        ballRb.velocity =new Vector2 (xVelocity, yVelocity) * veloI;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("palas"))
        {
            AudioSource.PlayClipAtPoint(tone, transform.position);
            ballRb.velocity *=MultiV;

        }
        if (collision.gameObject.CompareTag("goal"))
        {
            transform.position = new Vector3(0, 0, 0);
            float xVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
            float yVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
            ballRb.velocity = new Vector2(xVelocity, yVelocity) * veloI;
            GameManger.Instance.palaDscored();
            int res1 = 0;
            res1++;
            if (res1 == 10)
            {
                GameManger.Instance.RestartGame();
            }

        }
        if (collision.gameObject.CompareTag("Goal2"))
        {
            transform.position = new Vector3(0, 0, 0);
            float xVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
            float yVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
            ballRb.velocity = new Vector2(xVelocity, yVelocity) * veloI;
            GameManger.Instance.palaIscored();
            int res2=0;
            res2++;
            if (res2 == 10)
            {
                GameManger.Instance.RestartGame();
            }

           
        }

    }
    
    void Update()
    {
        
    }
}
