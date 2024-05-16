using System.Collections;
using System.Collections.Generic;
using ThreefoldTrip;
using UnityEngine;
using UnityEditor.Animations;

namespace ThreefoldTrip
{
    public class Astra : Character
    {
        //public KeyCode up,down;
        private float maxTime = 3, currentTime;
        private float originGravity;
        private Vector2 _dir;
        
        public Astra(float speed, Rigidbody2D rb) : base(speed, rb, Resources.Load<Sprite>("sprites/Astra andando"), Resources.Load<AnimatorController>("sprites/animations/astra/Astra andando_0"))
        {
            originGravity = rb.gravityScale;
        }

        public override void Skill()
        {

            Debug.Log("Soy astra");
            _rb.gravityScale = 0f;
            currentTime = 0;

            //if (Input.GetKey(KeyCode.W))           //es para que astra pueda planear en el aire
            //{
            //_dir = new Vector2(0, -1);

            //}
            //else if (Input.GetKey(KeyCode.S))
            //{

            //_dir = new Vector2(0, -1);
            //}
        }

        public override void Update()  //no es override por ahora al no tener nada en update
        {
            if (_rb.gravityScale == 0)
                currentTime += Time.deltaTime;

            if (currentTime >= maxTime)
            {
                _rb.gravityScale = originGravity;
                currentTime = 0;
            }
        }
    }
}
