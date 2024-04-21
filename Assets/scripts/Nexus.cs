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

        public Nexus(float speed, Rigidbody2D rb) : base(speed, rb, Resources.Load<Sprite>("sprites/FichaNexus (1)"), Resources.Load<AnimatorController>("sprites/animations/nexus/Idlenexus_0"))
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

    }
}
