using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //Configuaration Parameters

    [SerializeField] float screenWidthInUnits = 16f; //f for float
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;


    // cached references
    GameSession theGameSession;
    Ball theBall;

    // Start is called before the first frame update
    void Start()
    {
        theGameSession = FindObjectOfType<GameSession>();
        theBall = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y); // Vector2's hold x,y positions
        if (!Options.mouse)
        {
            paddlePos.x = Mathf.Clamp(GetXPos() + paddlePos.x, minX, maxX); // needed to move with controller
        }
        else
        {
            paddlePos.x = Mathf.Clamp(GetXPos(), minX, maxX); // keeps it from going off left and right of screen
        }
            transform.position = paddlePos;
        
    }

    private float GetXPos()
    {
        if (theGameSession.IsAutoPlayEnabled())
        {
            return theBall.transform.position.x;
        }
        else if (!Options.mouse)
        {
            return Input.GetAxis("Horizontal") * Time.deltaTime * 15;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * screenWidthInUnits;
        }
    }
}
