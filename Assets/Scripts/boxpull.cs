using UnityEngine;
using System.Collections;

public class boxpull : MonoBehaviour
{
    public bool beingPushed;
    float xPos;
    //testando abaixo
    float yPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        xPos = transform.position.x;
        //testando o abaixo
        yPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (beingPushed == false)
        {
            transform.position = new Vector3 (xPos, yPos, transform.position.y);
        }
        else
        {
            xPos = transform.position.x;
            //
            yPos = transform.position.y;
        }
        
    }
}
