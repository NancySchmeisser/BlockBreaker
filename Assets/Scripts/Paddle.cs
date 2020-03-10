using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthUnits = 16f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var sp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 paddlePos = new Vector2(sp.x, transform.position.y);
        transform.position = paddlePos;
    }
}
