using UnityEngine;
using UnityEngine.SceneManagement;

public class ColisorTeste : MonoBehaviour
{
    public bool locked;

    [SerializeField] GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        locked = true;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(player.transform.position, transform.position);

        if(!locked && distance < 0.5f)
        {
            SceneManager.LoadScene(5);

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            locked = false;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        locked = true;
    }
}
