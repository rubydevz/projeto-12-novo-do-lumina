using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ativar : MonoBehaviour
{
    public GameObject platformToDestroy;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("botão apertado");
            Destroy(gameObject);
            print("botão destruido");            
            if (platformToDestroy != null)
            {
                Destroy(platformToDestroy);
                print("plataforma destruida"); 
            }
        }
    }
}