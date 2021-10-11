using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SqCon : MonoBehaviour
{
    public Rigidbody2D sq;
    private float sqH = 6f;
    private float sqW = 12f;
    private List<GameObject> spawnQ;
    private float pX;
    private float pY;

    private void Start()
    {
        spawnQ = new List<GameObject>(0);

        //GenerateBox for Problem 6
        int boxCount = Random.Range(10, 30);
        for (int i = 0; i <= boxCount; i++)
        {
            pX = Random.Range(-sqW / 2, sqW / 2);
            pY = Random.Range(-sqH / 2, sqH / 2);
            spawnsq(pX, pY);
        }
    }

    private void spawnsq(float posX, float posY)
    {
        GameObject newBox = Instantiate(sq.gameObject, transform);
        newBox.transform.position = new Vector2(posX, posY);
        spawnQ.Add(newBox);
    }
}