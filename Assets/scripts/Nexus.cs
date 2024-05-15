using System.Collections;
using System.Collections.Generic;
using ThreefoldTrip;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.U2D;

namespace ThreefoldTrip
{
    public class Nexus : Character
    {
        public AudioClip wicthClip;
        public float timeScale;
        private float maxTime = 4.75f, currentTime = 0;
        //public float Cooldown = 4;//tiempo que tarda en volver a poder utilizar la habilidad
        public float volume;
        AudioSource audioSource;

        public Nexus(float speed, Rigidbody2D rb) : base(speed, rb, Resources.Load<Sprite>("sprites/FichaNexus (1)"), Resources.Load<AnimatorController>("sprites/animations/nexus/FichaNexus (1)_0"))
        {

        }

        //void Start()
        //{
        //    audioSource = GetComponent<AudioSource>();
        //}

        public override void Skill()
        {
            Debug.Log("soy nexus");

            //StartCoroutine(PlayAudio(src));

            IEnumerator PlayAudio(AudioSource wicthClip)
            {

                Time.timeScale = 0.25f;
                while (wicthClip && wicthClip.isPlaying)
                {
                    yield return null;
                }

                Time.timeScale = 1f;
            }
            AudioSource src = AudioManager.instance.PlayAudio(wicthClip, "wicthSound");
        }




        //Update is called once per frame
        public override void Update()
        {
          
           


        }
       
    }
}
