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
        float mousePosUnits = Input.mousePosition.x/ Screen.width * screenWidthUnits;
        Vector2 paddlePos = new Vector2(mousePosUnits, transform.position.y);
        transform.position = paddlePos;
    }
}
