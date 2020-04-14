using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float maxX = 1215;
    [SerializeField] float minX = 0;

    // cached reference
    GameSession theGamesSession;
    Ball theBall;

    void Start()
    {
        theGamesSession = FindObjectOfType<GameSession>();
        theBall = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        var paddlePosOnScreen = new Vector2(Mathf.Clamp(Input.mousePosition.x, 60, 1160), Input.mousePosition.y);
        var sp = Camera.main.ScreenToWorldPoint(paddlePosOnScreen); 
        Vector2 paddlePos = new Vector2(sp.x, transform.position.y);
        transform.position = paddlePos;
        paddlePos.x = Mathf.Clamp(GetXPos(), minX, maxX);

    }

    private float GetXPos()
    {
        if (theGamesSession.IsAutoPlayEnabled())
        {
            return theBall.transform.position.x;


        }
        else
        {
            return Input.mousePosition.x;         }
    }
}

  
