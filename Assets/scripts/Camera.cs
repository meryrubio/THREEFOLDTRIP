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
        //la camara es independiente 
        speed = FindObjectOfType<CharacterManager>().speed;  
        _rb = GetComponent<Rigidbody2D>();
        _dir = new Vector2(1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        _rb.velocity = new Vector2(speed, 0) * _dir;
    }

   
}


