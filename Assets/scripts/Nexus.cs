using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
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
        private float maxTime = .25f, currentTime = 0;
        private bool skillStarted;

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
            SlowTime(true);
            //StartCoroutine(PlayAudio(src));
        }

        public override void Update()
        {
            if(skillStarted)
            {
                currentTime += Time.deltaTime;
                if(currentTime >= maxTime)
                {
                    SlowTime(false);
                    currentTime = 0;
                }
            }
        }

        private void SlowTime(bool hasStarted)
        {
            Time.timeScale = hasStarted ? 0.25f : 1;
            skillStarted = hasStarted;
        }
    }
}
