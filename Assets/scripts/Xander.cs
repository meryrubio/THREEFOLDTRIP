using System.Collections;
using System.Collections.Generic;
using ThreefoldTrip;
using UnityEditor.Animations;
using UnityEngine;

namespace ThreefoldTrip
{
    public class Xander : Character
    {
        public Xander(float speed, Rigidbody2D rb) : base(speed, rb, Resources.Load<Sprite>("sprites/XanderSpriteSheet"), Resources.Load<AnimatorController>("sprites/animations/xander/XanderSpriteSheet_0"))
        {
        }

        public override void Skill()
        {
            throw new System.NotImplementedException();
        }
    }
}
