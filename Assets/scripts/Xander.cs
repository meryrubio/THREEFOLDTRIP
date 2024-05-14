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
        public float Cooldown= 4; //tiempo que tarda en volver a poder utilizar la habilidad
        public Xander(float speed, Rigidbody2D rb) : base(speed, rb, Resources.Load<Sprite>("sprites/XanderSpriteSheet"), Resources.Load<AnimatorController>("sprites/animations/xander/XanderSpriteSheet_0"))
        {
            //contructor de xander segun la estructura del character
        }

        public override void Skill()
        {
            Invis(false); //metodo de invisibilidad
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
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, hasFinished ? 1 : 0.5f); //reduce la gama de color del sprite
            _rb.gameObject.GetComponent<Collider2D>().enabled = hasFinished; //le quitamos el collider para que atraviese
            _rb.gravityScale = hasFinished ? 1 : 0;
        }
    }
}
