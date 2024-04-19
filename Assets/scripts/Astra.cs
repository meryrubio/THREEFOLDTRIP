using System.Collections;
using System.Collections.Generic;
using ThreefoldTrip;
using UnityEngine;
using UnityEditor.Animations;

namespace ThreefoldTrip
{
    public class Astra : Character
    {
        public Astra(float speed, Rigidbody2D rb) : base(speed, rb, Resources.Load<Sprite>("sprites/Astra andando"), Resources.Load<AnimatorController>("sprites/animations/astra/Astra andando_0"))
        {
        }

        public override void Skill()
        {
            Debug.Log("Soy astra");
        }
    }
}
