using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevel : MonoBehaviour
{
    public string levelToLoad; //  escena que se cargará
    public AudioClip deadClip; //audio de muerte
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica si la colisión es con el esqueleto.
        if (collision.GetComponent<CharacterManager>())
        {
            // cambia la escena
            GameManager.instance.LoadScene(levelToLoad); // carga la escena poniendo el nombre en el inspector
            AudioManager.instance.PlayAudio(deadClip, "deadSound"); //se reproduce sonido de muerte
        }
    }
}
