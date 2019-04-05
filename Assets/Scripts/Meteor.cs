using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public int score = 0;
    private Vector2 targetPosition; 
    public float speed;
    public float Yincrement;
    public GameObject explodePrefab;

    void Start()
    {
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        targetPosition = new Vector2(transform.position.x, transform.position.y - Yincrement); 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject a = Instantiate(explodePrefab);
        a.transform.position = this.transform.position;

        if (other.CompareTag("Earth"))
        {
            Destroy(gameObject);
        }

        if (other.CompareTag("Meteor"))
        {
            Destroy(gameObject);
        }

        if (other.CompareTag("Sun"))
        {
            score = score + 1;
            Destroy(gameObject);
        }
    }
}
