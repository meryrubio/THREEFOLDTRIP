using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balas : MonoBehaviour
{
    
    private Rigidbody2D rb;
    public Vector2 dir; 
    public float speed;
    private float currentTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= 2f)
        {
            Destroy(gameObject);
            currentTime = 0;

        }

    }

    private void FixedUpdate()
    {
        rb.velocity = dir * speed;
    }
    //public AnimatorController GetAnimatorController()
    //{
    //    return Resources.Load<AnimatorController>("sprites/animations/Bala/shoot);
        
    //}
}
