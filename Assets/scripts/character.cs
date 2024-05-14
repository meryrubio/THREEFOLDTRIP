using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

namespace ThreefoldTrip
{
    public abstract class Character
    {
        public float speed, rayDistance, jumpForce;
        public int maxJump = 2;
        public KeyCode downKey;

        private bool isJumping = false;
        private AnimatorController _controller;
        private int currentJumps = 0;
        private Animator _animator;
        //private BoxCollider2D bc;

        protected Sprite _sprite;
        protected Rigidbody2D _rb;
        protected Color color;
        //protected Vector2 _dir;
        

        public Character(float speed, Rigidbody2D rb, Sprite sprite, AnimatorController cont)
        {
            this.speed = speed;
            _rb = rb;
            _sprite = sprite;
            _controller = cont;

        }

        // this method should be called in FixedUpdate
        public void Run()
        {
            _rb.velocity = new Vector2(speed, _rb.velocity.y);
        }

        public void Jump(UnityEngine.Transform transform)
        {
            bool grnd = IsGrounded(transform);

            if (grnd)//hace que salte
            {
                _rb.velocity = new Vector2(_rb.velocity.x, 0);
                _rb.AddForce(Vector2.up * jumpForce * _rb.gravityScale * _rb.drag, ForceMode2D.Impulse);
                currentJumps++;
            }
        }
        private bool IsGrounded(UnityEngine.Transform transform)//se pone un laser desde el personaje hacia abajo y va a detectar la mascara de colisiones que hemos establecido(suelo)
        {
            RaycastHit2D[] collisions = Physics2D.RaycastAll(transform.position, Vector2.down, rayDistance);

            foreach (RaycastHit2D raycastHit in collisions)
            {
                if (raycastHit.collider.gameObject.CompareTag("Suelo"))
                {
                    currentJumps = 0;
                    return true;
                }
            }

            return false;
        }
        public  virtual void Update()
        {

        }
        public Sprite GetSprite() { return _sprite; }

        public void SetJumpForce(float value) { jumpForce = value; }

        public AnimatorController GetAnimatorController() { return _controller; }

        public abstract void Skill();

        public void Crouch(bool isCrouching)
        {
            
            BoxCollider2D bc = _rb.GetComponent<BoxCollider2D>();
            bc.size = new Vector2(bc.size.x, isCrouching ? bc.size.y / 2 : bc.size.y * 2);
            //  _animator.SetBool("agachar", true);
            

        }
    }

}
