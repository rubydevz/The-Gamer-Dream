using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movcamera : MonoBehaviour
{
     public float Velmov = 5f;

void Update()
{
    transform.position += new Vector3(Velmov + Time.deltaTime, 0, 0);
}
   
}
