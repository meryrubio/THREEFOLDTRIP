using System.Collections;
using System.Collections.Generic;
using ThreefoldTrip;
using UnityEditor.Animations;
using UnityEngine;

namespace ThreefoldTrip
{
    public class Nexus : Character
    {
        //public AudioClip wicthClip;
        public float timeScale;
        private float maxTime = 4, currentTime = 0;

        public Nexus(float speed, Rigidbody2D rb) : base(speed, rb, Resources.Load<Sprite>("sprites/FichaNexus (1)"), Resources.Load<AnimatorController>("sprites/animations/nexus/FichaNexus (1)_0"))
        {

        }

        public override void Skill()
        {
            Debug.Log("soy nexus");
            IEnumerator PlayAudio(AudioSource wicthClip)
            {

                Time.timeScale = 0.25f;
                while (wicthClip && wicthClip.isPlaying)
                {
                    yield return null;
                }

                Time.timeScale = 1f;
            }
            //AudioSource src = AudioManager.instance.PlayAudio(wicthClip, "wicthSound");
        }

        //public float volume;
        //AudioSource audioSource;


        // void Start()
        // {
        //     //audioSource = GetComponent<AudioSource>();
        // }


        // Update is called once per frame
        //void Update()
       // {
                //if (Input.GetButtonDown)
               // {
                  //  AudioSource src = AudioManager.instance.PlayAudio(wicthClip, "wicthSound");
                   // StartCoroutine(PlayAudio(src));
               // }


        // }
           // IEnumerator PlayAudio(AudioSource wicthClip)
           // {
            //   Time.timeScale = 0.25f;
              // while (wicthClip && wicthClip.isPlaying)
             //  {
                //   yield return null;
              //  }

             //  Time.timeScale = 1f;
       // }
    }
}
