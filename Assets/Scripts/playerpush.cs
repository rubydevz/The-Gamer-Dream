using UnityEngine;
using System.Collections;

public class playerpush : MonoBehaviour
{
    public float distance = 1f;
    public LayerMask boxMask;
    GameObject box;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //se nao funcionar, tentar apagar o querie, ele esta ai devido ao jogador ter 2 colisores
        Physics2D.queriesStartInColliders = false;
        RaycastHit2D hitDireita = Physics2D.Raycast (transform.position, Vector2.right * transform.localScale.x, distance, boxMask);
        //
        RaycastHit2D hitEsquerda = Physics2D.Raycast (transform.position, Vector2.left * transform.localScale.x, distance, boxMask);
        RaycastHit2D hitCima = Physics2D.Raycast (transform.position, Vector2.up * transform.localScale.y, distance, boxMask);
        RaycastHit2D hitBaixo = Physics2D.Raycast (transform.position, Vector2.down * transform.localScale.y, distance, boxMask);
        //////////
        ///

        if (hitDireita.collider != null && hitDireita.collider.gameObject.tag=="pushable" && Input.GetKeyDown(KeyCode.E)) 
        {
            box = hitDireita.collider.gameObject;
            box.GetComponent<FixedJoint2D> ().enabled = true;
            box.GetComponent <boxpull> ().beingPushed = true;
            box.GetComponent<FixedJoint2D> ().connectedBody=this.GetComponent<Rigidbody2D> ();
        }
        else if (Input.GetKeyUp (KeyCode.E))
        {
            box.GetComponent<FixedJoint2D> ().enabled = false;
            box.GetComponent<boxpull> ().beingPushed = false;
        }

        ///////////
        ///
         if (hitEsquerda.collider != null && hitEsquerda.collider.gameObject.tag=="pushable" && Input.GetKeyDown(KeyCode.E)) 
        {
            box = hitEsquerda.collider.gameObject;
            box.GetComponent<FixedJoint2D> ().enabled = true;
            box.GetComponent <boxpull> ().beingPushed = true;
            box.GetComponent<FixedJoint2D> ().connectedBody=this.GetComponent<Rigidbody2D> ();
        }
        else if (Input.GetKeyUp (KeyCode.E))
        {
            box.GetComponent<FixedJoint2D> ().enabled = false;
            box.GetComponent<boxpull> ().beingPushed = false;
        }

        /////////////
        ///
        if (hitCima.collider != null && hitCima.collider.gameObject.tag=="pushable" && Input.GetKeyDown(KeyCode.E)) 
        {
            box = hitCima.collider.gameObject;
            box.GetComponent<FixedJoint2D> ().enabled = true;
            box.GetComponent <boxpull> ().beingPushed = true;
            box.GetComponent<FixedJoint2D> ().connectedBody=this.GetComponent<Rigidbody2D> ();
        }
        else if (Input.GetKeyUp (KeyCode.E))
        {
            box.GetComponent<FixedJoint2D> ().enabled = false;
            box.GetComponent<boxpull> ().beingPushed = false;
        }

        ////////////////
        ///
        if (hitBaixo.collider != null && hitBaixo.collider.gameObject.tag=="pushable" && Input.GetKeyDown(KeyCode.E)) 
        {
            box = hitBaixo.collider.gameObject;
            box.GetComponent<FixedJoint2D> ().enabled = true;
            box.GetComponent <boxpull> ().beingPushed = true;
            box.GetComponent<FixedJoint2D> ().connectedBody=this.GetComponent<Rigidbody2D> ();
        }
        else if (Input.GetKeyUp (KeyCode.E))
        {
            box.GetComponent<FixedJoint2D> ().enabled = false;
            box.GetComponent<boxpull> ().beingPushed = false;
        }
        /////////////////////
        ///


    void OnDrawGizmos()
     {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position,(Vector2)transform.position + Vector2.right * transform.localScale.x * distance);

     }
    }
}
