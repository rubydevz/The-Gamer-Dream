using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorParaTodos : MonoBehaviour
{
    public bool locked;

    private Animator anim;

    [SerializeField] GameObject player;
    [SerializeField] private string nomeDaCena;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        locked = true;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(player.transform.position, transform.position);

        if(!locked && distance < 0.5f)
        {
            SceneManager.LoadScene(nomeDaCena);

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            anim.SetTrigger("Open");
            locked = false;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        anim.SetTrigger("Closed");
        locked = true;
    }
}