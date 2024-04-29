using System.Collections;
using System.Collections.Generic;
using ThreefoldTrip;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.U2D;

namespace ThreefoldTrip
{
    public class Xander : Character
    {
        private Color colors;
        private float maxTime = 4, currentTime = 0;
        private GameObject muroOff;
        public float Cooldown = 4;

        public Xander(float speed, Rigidbody2D rb) : base(speed, rb, Resources.Load<Sprite>("sprites/XanderSpriteSheet"), Resources.Load<AnimatorController>("sprites/animations/xander/XanderSpriteSheet_0"))
        {

        }

        public override void Skill()
        {
            SpriteRenderer spriteRenderer = _rb.gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 0.5f);
            _rb.gameObject.GetComponent<Collider2D>().enabled = false;
            _rb.gravityScale = 0;
        }
        public void Update(Rigidbody2D rb)  //no es override por ahora al no tener nada en update
        {
            //if (color.a == 0)
            //    currentTime += Time.deltaTime;

            //if (currentTime >= maxTime)
            //{
            //    colors.a = 1f;
            //    muroOff.GetComponent<muros>().enabled = true;
            //    currentTime = 0;
            //}
        }


    }
}
