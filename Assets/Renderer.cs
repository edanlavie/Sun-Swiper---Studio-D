﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Renderer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // params: width, height, fullscreen?, framerate
        Screen.SetResolution(1080, 1920, false, 60);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
