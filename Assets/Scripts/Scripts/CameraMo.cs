using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMo : MonoBehaviour
{
     public float Velmov;

void Update()
{
    if(Velmov < 20)
    {
        transform.position += new Vector3(Velmov * Time.deltaTime, 0, 0);
    }

    }
}


