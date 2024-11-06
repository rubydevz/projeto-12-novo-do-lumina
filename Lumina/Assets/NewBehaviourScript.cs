using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class trocaFoguete : MonoBehaviour
{
        public GameObject pontoA;
        public GameObject pontoB;
        private Rigidbody2D rb;
        private Animator anim;
        private Transform currenctPoint;
        public float speed;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            anim = GetComponent<Animator>();
            currenctPoint = pontoB.transform;
        }

        private void Update()
        {
            Vector2 point = currenctPoint.position - transform.position;
            if (currenctPoint == pontoB.transform)
            {
                rb.velocity = new Vector2(speed, 0);
            }
            else
            {
                rb.velocity = new Vector2(-speed, 0);
            }

            if (Vector2.Distance(transform.position, currenctPoint.position) < 0.5f && currenctPoint == pontoB.transform)
            {
                flip();
                currenctPoint = pontoA.transform;
            }
            if (Vector2.Distance(transform.position, currenctPoint.position) < 0.5f && currenctPoint == pontoA.transform)
            {
                flip();
                currenctPoint = pontoB.transform;
            }
        }

        private void flip()
        {
            Vector3 localScale = transform.localScale;
            localScale.y *= -1;
            transform.localScale = localScale;
        }

        private void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(pontoA.transform.position, 0.5f);
            Gizmos.DrawWireSphere(pontoB.transform.position, 0.5f);
            Gizmos.DrawLine(pontoA.transform.position, pontoB.transform.position);
        }
}
