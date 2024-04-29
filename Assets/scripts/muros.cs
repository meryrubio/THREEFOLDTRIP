using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class muros : MonoBehaviour
{
    private bool muroOn;
    //public float Cooldown = 4;          no hagais caso a lo comentado 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Character personajeComponent = collision.gameObject.GetComponent<Character>();
        if (!muroOn) return;
        //muroOn = false;
        if (collision.gameObject.GetComponent<Character>() != null)
        {
            //AudioManager.instance.PlayAudio(marioClip, "MarioMuereSound");
            Destroy(gameObject);
        }
        //Invoke("Muro",Cooldown);
    }
    //public void Muro()
    //{
    //    muroOn = true;
    //}
}
