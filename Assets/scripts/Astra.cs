using System.Collections;
using System.Collections.Generic;
using ThreefoldTrip;
using UnityEngine;
using UnityEditor.Animations;

namespace ThreefoldTrip
{
    public class Astra : Character
    {
        public KeyCode up,down;
        private float maxTime = 4, currentTime = 0;
        
        public Astra(float speed, Rigidbody2D rb) : base(speed, rb, Resources.Load<Sprite>("sprites/Astra andando"), Resources.Load<AnimatorController>("sprites/animations/astra/Astra andando_0"))
        {
        }

        public override void Skill()
        {
            Debug.Log("Soy astra");
            _rb.gravityScale = 0f;
            
            //if (Input.GetKey(up))           //es para que astra pueda planear en el aire
            //{
                //_dir = new Vector2(0, -1);
            
            //}
            //else if (Input.GetKey(down))
            //{

                //_dir = new Vector2(0, -1);
            //}
        }

        public void Update(Rigidbody2D rb)  //no es override por ahora al no tener nada en update
        {
            if (rb.gravityScale == 0)
                currentTime += Time.deltaTime;

            if (currentTime >= maxTime)
            {
                rb.gravityScale = 1;
                currentTime = 0;
            }
        }
    }
}
