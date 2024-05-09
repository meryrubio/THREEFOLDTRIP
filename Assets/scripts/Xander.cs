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
        public float Cooldown= 4;
        public Xander(float speed, Rigidbody2D rb) : base(speed, rb, Resources.Load<Sprite>("sprites/XanderSpriteSheet"), Resources.Load<AnimatorController>("sprites/animations/xander/XanderSpriteSheet_0"))
        {

        }

        public override void Skill()
        {
            Invis(false);
            currentTime = 0;
        }

        public override void Update()
        {
            currentTime += Time.deltaTime;

            if (currentTime > maxTime)
            {
                Invis(true);
            }
        }

        private void Invis(bool hasFinished)
        {
            SpriteRenderer spriteRenderer = _rb.gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, hasFinished ? 1 : 0.5f);
            _rb.gameObject.GetComponent<Collider2D>().enabled = hasFinished;
            _rb.gravityScale = hasFinished ? 1 : 0;
        }
    }
}
