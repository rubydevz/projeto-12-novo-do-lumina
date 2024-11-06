using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeEnemy : MonoBehaviour
{
    public int Life;
    public Image LifeBar;
    float CurrentLife; 
    private float MaxLifeBar = 90; 

    void Start()
    {
        Life = 90;
    }

    void Update()
    {
        CurrentLife = Life;
        LifeBar.fillAmount = CurrentLife / MaxLifeBar;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "DANO")
        {
            Life -= 30;

            if(Life <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}