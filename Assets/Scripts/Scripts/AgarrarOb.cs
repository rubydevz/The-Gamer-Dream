using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class AgarrarOb : MonoBehaviour
{
    public Transform agarrarDet;
    public Transform seguraitem;
    public float rayDist;

    void Update()
    {
        RaycastHit2D grabCheck = Physics2D.Raycast(agarrarDet.position, UnityEngine.Vector2.left * transform.localScale, rayDist);
        Debug.Log(grabCheck.collider); 
        Debug.DrawRay(agarrarDet.position, UnityEngine.Vector2.left * transform.localScale * rayDist, Color.red);
        if(grabCheck.collider != null && grabCheck.collider.tag == "Agarravel")
        {
          
           if(Input.GetKey(KeyCode.V))
           {
             grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
             grabCheck.collider.gameObject.transform.parent = seguraitem;
             grabCheck.collider.gameObject.transform.position = seguraitem.position;
           
           }   
           else
           {
             grabCheck.collider.gameObject.transform.parent = null;
             grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
           }  
        }
        
    }
}
