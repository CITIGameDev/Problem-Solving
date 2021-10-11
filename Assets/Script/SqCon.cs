using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SqCon : MonoBehaviour
{
    public Rigidbody2D sq;
    public float sqH = 6f;
    public float sqW = 12f;
    private List<GameObject> spawnQ;
    private void Start()
    {
        spawnQ = new List<GameObject>(0);
        int boxCount = Random.Range(5, 10);
        for (int i = 0; i <= boxCount; i++)
        {
        float pX = Random.Range(-sqW / 2, sqW / 2);
        float pY = Random.Range(-sqH / 2, sqH / 2);
        spawnsq(pX, pY);
        }
    }

    public void spawnsq(float pX, float pY)
    {
        GameObject newBox = Instantiate(sq.gameObject, transform);
        newBox.transform.position = new Vector2(pX, pY);
        spawnQ.Add(newBox);
    }
}