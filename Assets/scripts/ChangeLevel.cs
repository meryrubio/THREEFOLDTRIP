using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevel : MonoBehaviour
{
    public string levelToLoad; //  escena que se cargar�
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
        // Verifica si la colisi�n es con el esqueleto.
        if (collision.GetComponent<CharacterManager>())
        {
            // cambia la escena
            GameManager.instance.LoadScene(levelToLoad); // carga la escena poniendo el nombre en el inspector
        }
    }
}
