using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    public int lives = 5; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Earth"))
        {

        }

        if (other.CompareTag("Meteor"))
        {
            lives = lives - 1; 
            Destroy(gameObject);
        }
    }
}

