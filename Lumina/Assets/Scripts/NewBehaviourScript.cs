using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;


public class FlipEnemy : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rb;
    private Animator anim;
    private Transform currenctPoint;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        currenctPoint = pointB.transform;
        anim.SetBool("IsRunning", true);
    }

    private void Update()
    {
        Vector2 point = currenctPoint.position - transform.position;
        if(currenctPoint == pointB.transform)
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
        }

        if (Vector2.Distance(transform.position, currenctPoint.position) < 0.5f && currenctPoint == pointB.transform)
        {
            flip();
            currenctPoint = pointA.transform;
        }
        if (Vector2.Distance(transform.position, currenctPoint.position)< 0.5f && currenctPoint == pointA.transform)
        {
            flip();
            currenctPoint = pointB.transform;
        }
    }

    private void flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.5f);
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);
    }

   // void OnTriggerEnter2D(Collider2D other)
    //{
      //  if(other.CompareTag("Player"))
        //{
          //  SceneManager.LoadScene("BossBattle");
        //}    
   // }
}
