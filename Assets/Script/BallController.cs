using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Besaran gaya awal untuk mendorong ball
    public float xInitialForce;
    public float yInitialForce;
    // Rigidbody2D Ball
    private Rigidbody2D rigidBody2D;
    private Vector2 trajectoryOrigin;

    void PushBall()
    {
        float randomDirection = Random.Range(0, 2);
        if (randomDirection < 1.0f)
        {
            rigidBody2D.AddForce(new Vector2(-xInitialForce, yInitialForce));
        }
        else
        {
            rigidBody2D.AddForce(new Vector2(xInitialForce, yInitialForce));
        }

    }
    void ResetBall()
    {
        // Mereset posisi Ball menjadi (0,0)
        transform.position = Vector2.zero;
        // Mereset kecepatan Ball menjadi (0,0)
        rigidBody2D.velocity = Vector2.zero;
    }

    void RestartGame()
    {
        ResetBall();
        Invoke("PushBall", 3);
    }

    void Start()
    {
        trajectoryOrigin = transform.position;
        rigidBody2D = GetComponent<Rigidbody2D>();
        // Memulai game
        RestartGame();
    }
    void Update()
    {

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        trajectoryOrigin = transform.position;
    }
    public Vector2 TrajectoryOrigin
    {
        get { return trajectoryOrigin; }
    }
    
}