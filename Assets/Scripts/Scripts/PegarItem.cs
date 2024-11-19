using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PegarItem : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI mensagemtexto;
    private bool pegar;

    // Start is called before the first frame update
    void Start()
    {
      mensagemtexto.text = "";
    }

    // Update is called once per frame
   private void Update()
    {
        if(pegar && Input.GetKeyDown(KeyCode.E))
        pegarfusivel();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("garota"))
        {
           pegar = true; 
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("garota"))
        {
            pegar = false;
        }
    }
    private void pegarfusivel()
    {
        Destroy(gameObject);
        mensagemtexto.text = "Fusível obtido";
    }

}
