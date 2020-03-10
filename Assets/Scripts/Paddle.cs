using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // [SerializeField] float screen.width = 1215;
    [SerializeField] float maxX = 1215;
    [SerializeField] float minX = 0;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var paddlePosOnScreen = new Vector2(Mathf.Clamp(Input.mousePosition.x, 0, Screen.width), Input.mousePosition.y);
        var sp = Camera.main.ScreenToWorldPoint(paddlePosOnScreen); 
        Vector2 paddlePos = new Vector2(sp.x, transform.position.y);
        transform.position = paddlePos;
        paddlePos.x = Mathf.Clamp(sp.x, minX, maxX);

    }
}

  
