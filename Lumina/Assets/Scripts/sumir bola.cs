using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sumirbola : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("DANO"))
        {
            Destroy(other.gameObject);
        }
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene("BossBattle");
        }
    }
}
