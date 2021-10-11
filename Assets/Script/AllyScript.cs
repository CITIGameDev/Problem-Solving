using System.Collections.Generic;
using UnityEngine;

public class AllyScript : MonoBehaviour
{
    private List<GameObject> spawnally;
    public float delays = 15f;
    public Rigidbody2D allybody;
    public float alH = 4f;
    public float alW = 10f;
    public BallController balcon;
    private void Start()
    {
        spawnally = new List<GameObject>(0);

        while (true)
        {
            float posX = Random.Range(-alW / 2, alW / 2);
            float posY = Random.Range(-alH / 2, alH / 2);
            if (posX != 0 && posY != 0)
            {
                SpawnAllys(posX, posY);
                break;
            }
        }
    }

    private void Update()
    {
        delays -= Time.deltaTime;
        if (delays <= 0f)
        {
            delays = 15f;
            while (true)
            {
                float posX = Random.Range(-alW / 2, alW / 2);
                float posY = Random.Range(-alH / 2, alH / 2);
                if (posX != balcon.transform.position.x && posY != balcon.transform.position.y)
                {
                    SpawnAllys(posX, posY);
                    break;
                }
            }
        }
    }

    public void SpawnAllys(float posX, float posY)
    {
        GameObject newBox = Instantiate(allybody.gameObject, transform);
        newBox.transform.position = new Vector2(posX, posY);
        spawnally.Add(newBox);
    }
}