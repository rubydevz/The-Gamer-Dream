using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    public Transform personagem;
   [SerializeField] private float velocidadeMov;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            transform.position = Vector3.Lerp (transform.position, personagem.position, velocidadeMov * Time.deltaTime);
        }
    }
}
