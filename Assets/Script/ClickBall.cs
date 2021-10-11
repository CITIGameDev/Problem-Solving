using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBall : MonoBehaviour
{
    private Rigidbody2D ballbody;
    public float kecepatan;
    public Camera cams;
    Vector3 curs;
    Vector3 angl;
    private void Start()
    {
        ballbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        curs = cams.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        angl = curs - transform.position;
        if (Vector3.Distance(curs, transform.position) > 0.3)
        {
            transform.Translate(angl.normalized * kecepatan * Time.deltaTime);
        }


    }


}