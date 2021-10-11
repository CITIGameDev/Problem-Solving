using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBall : MonoBehaviour
{
    private Rigidbody2D ballbody;
    public float kecepatan;
    public Camera cams;
    public Score score;
    Vector3 curs;
    Vector3 angl;
    public SqCon spawns;
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
    private IEnumerator delay()
    {
        yield return new WaitForSeconds(8);
        while (true)
        {
            float pqX = Random.Range(-spawns.sqW / 2, spawns.sqW / 2);
            float pqY = Random.Range(-spawns.sqH / 2, spawns.sqH / 2);
            if (pqX != transform.position.x && pqY != transform.position.y)
            {
                spawns.spawnsq(pqX, pqY);
                break;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Square")
        {
            score.upscore();
            Destroy(collision.gameObject);
            StartCoroutine(delay());
        }
    }


}