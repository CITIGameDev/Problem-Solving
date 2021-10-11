using UnityEngine;
using System.Collections;

public class AllyMove : MonoBehaviour
{
    Transform player;
    public float speed;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }



}
