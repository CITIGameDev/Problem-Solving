using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float Kecepatan;
    Rigidbody2D ballbody;
    private void Awake()
    {
        ballbody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {

    }
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        ballbody.velocity = new Vector2(Kecepatan * horizontal, ballbody.velocity.y);
        ballbody.velocity = new Vector2(ballbody.velocity.x, Kecepatan * vertical);
    }
}