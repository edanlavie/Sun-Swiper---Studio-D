using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject meteor; 

    void Start ()
    {
        Instantiate(meteor, transform.position, Quaternion.identity); 
    }
}
