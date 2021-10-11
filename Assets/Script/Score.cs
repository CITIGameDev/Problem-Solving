using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int scores;
    // Start is called before the first frame update
    void Start()
    {

    }
    public float curscore()
    {
        return scores;
    }
    public void upscore()
    {
        scores++;
    }
    public int Scores
    {
        get { return scores; }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
