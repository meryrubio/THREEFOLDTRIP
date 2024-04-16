using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed, rayDistance, jumpForce;

    private bool isJumping = false;
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
        }
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(speed, _rb.velocity.y);

        bool grnd = IsGrounded();

        if (isJumping && grnd)//hace que salte
        {
            _rb.velocity = new Vector2(_rb.velocity.x, 0);
            _rb.AddForce(Vector2.up * jumpForce * _rb.gravityScale * _rb.drag, ForceMode2D.Impulse);
        }
        isJumping = false;
    }

    private bool IsGrounded()//se pone un laser desde el personaje hacia abajo y va a detectar la mascara de colisiones que hemos establecido(suelo)
    {
        RaycastHit2D[] collisions = Physics2D.RaycastAll(transform.position, Vector2.down, rayDistance);

        foreach (RaycastHit2D raycastHit in collisions)
        {
            if (raycastHit.collider.gameObject.CompareTag("Suelo"))
            {
                // currentJumps = 0;
                return true;
            }
        }

        return false; 
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, Vector2.down * rayDistance);
    }
}
