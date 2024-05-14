using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class Camera : MonoBehaviour
{
    public float speed;
    protected Camera _camera;
    private Rigidbody2D _rb;
    private Vector2 _dir ;

   /* public Transform player;*/ // Referencia al transform del personaje


    // Start is called before the first frame update
    void Start()
    {
        speed = FindObjectOfType<CharacterManager>().speed; 
        _rb = GetComponent<Rigidbody2D>();
        _dir = new Vector2(1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        _rb.velocity = new Vector2(speed, 0) * _dir;
    }

    void LateUpdate()
    {
        //// la camara se centrara automaticamente en el personaje (a 5 de velocidad) y si no esta centrada lo hara en el reinicio de la partida y siga al personaje en x
        //transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.position.x, transform.position.y, -3f), 3f * Time.deltaTime);
    }
}


