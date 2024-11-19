using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garota : MonoBehaviour
{
     [SerializeField] private float velocidadeMov; 
     [SerializeField] private float velocidadeEsquiv;
     [SerializeField] private float velocidadeCorrida;
    private bool correndo = false;
    private Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
private  void Mover()
{
    var vertical = Input.GetAxis("Vertical");
    if(correndo)
    {
        transform.position += transform.up * vertical * velocidadeCorrida * Time.deltaTime;
    }
    else
    {
        transform.position += transform.up * vertical * velocidadeMov * Time.deltaTime;
    }

    var horizontal = Input.GetAxis("Horizontal");
    if(correndo)
    {
        transform.position += transform.right * horizontal * velocidadeCorrida * Time.deltaTime;
    }
    else 
    {
        transform.position += transform.right * horizontal * velocidadeMov * Time.deltaTime;
    }
}

private void Esquiva()
{
    //a ideia era que ao apertar espaço o personagem desse um dash pra trás
    if(Input.GetKeyUp(KeyCode.Space))
    {
        body.AddForce(transform.right * velocidadeEsquiv, ForceMode2D.Impulse);
    }
}
private void Correr()
{
    //a ideia é que ao segurar X o personagem corresse e ao soltar ele parasse. O problema que eu 
    //to enfrentando é que ele se move em todas as direções... como fazer ele corres e continuar andando em todas as direções
    // além disso ele não está parando quando eu solto o X
    if(Input.GetKey(KeyCode.X))
    {
        // body.AddForce(transform.up * velocidadeCorrida, ForceMode2D.Force);
        correndo = true;
    }
    else 
    {
        correndo = false;
    }

   // if(correndo)
   // {
   //     Vector2 moveDirec = new Vector2(Horizontal, Vertical).normalized;
   //     transform.position += (vector3) (moveDirec * velocidadeCorrida * Time.deltaTime);
   // }
}
    // Update is called once per frame
    void Update()
    {
        Correr();
        Mover();
        Esquiva();
        
    }
}
