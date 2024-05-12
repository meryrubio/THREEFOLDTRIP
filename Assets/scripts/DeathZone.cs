using System.Collections;
using System.Collections.Generic;
using ThreefoldTrip;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathzone : MonoBehaviour
{

    public AudioClip deadClip; //audio de muerte

   

    private void OnTriggerEnter2D(Collider2D collision)
    {

        //if (collision.GetComponent<NexusScript>())
        //{
        //    // reinicia y limpia la escena de objetos y audios.
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().);


        //    //audiomanager.instance.playaudio(deadclip, "deadsound"); //se reproduce sonido de muerte
        //}
    }
}

