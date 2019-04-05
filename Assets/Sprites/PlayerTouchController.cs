using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouchController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Check how many touch points
        if (Input.touchCount > 0)
        {
            // Get first touch point
            Touch touch = Input.GetTouch(0);

            // Calculate word position based on touch
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            // Move sun to the world position
            transform.position = touchPosition;
        }
    }
}
