using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//este es el script que controla al personaje (playermovement) que comunica con monobehaviour

public class CharacterManager : MonoBehaviour
{
    public float speed;
    public float RayDistance;
    public float JumpForce;
    //public AudioClip crounch;

    private bool isJumping = false;

    protected ThreefoldTrip.Character character; //variable protejida para los personajes
    protected SpriteRenderer rend;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        animator.SetBool("isCrounch", false);

        //programamos un if para elegir para la funcion del boton para elegir el personaje
        if (GameManager.instance.characterType == ThreeFoldCharacters.NEXUS)
        {
            character = new ThreefoldTrip.Nexus(speed, GetComponent<Rigidbody2D>());
        }
        else if (GameManager.instance.characterType == ThreeFoldCharacters.ASTRA)
        {
            character = new ThreefoldTrip.Astra(speed, GetComponent<Rigidbody2D>());
        }
        else if (GameManager.instance.characterType == ThreeFoldCharacters.XANDER)
        {
            character = new ThreefoldTrip.Xander(speed, GetComponent<Rigidbody2D>());

        }
        character.SetJumpForce(JumpForce);
        rend.sprite = character.GetSprite();
        animator.runtimeAnimatorController = character.GetAnimatorController();
        character.rayDistance = RayDistance;
    }
    public void Astra()
    {
        character = new ThreefoldTrip.Astra(speed, GetComponent<Rigidbody2D>());
        rend.sprite = character.GetSprite();
        animator.runtimeAnimatorController = character.GetAnimatorController();
        character.rayDistance = RayDistance;
    }
    public void Nexus()
    {
        character = new ThreefoldTrip.Nexus(speed, GetComponent<Rigidbody2D>());
    }
    //public void Xander()
    //{
    //    character = new ThreefoldTrip.Shander(speed, GetComponent<Rigidbody2D>());
    //}

    // Update is called once per frame
    void Update()
    {
        //controles
        character.Update();
        if (Input.GetKeyDown(KeyCode.E))
        {
            character.Skill();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            isJumping = true;
            
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            character.Crouch(true);
            animator.SetBool("isCrounch", true);
            //AudioManager.instance.PlayAudio(crounch, "crounchSound");
        }
        else if(Input.GetKeyUp(KeyCode.S))
        {
            character.Crouch(false);
            animator.SetBool("isCrounch", false);
        }
        
    }

    private void FixedUpdate() //salto
    {
        character.Run();

        if (isJumping)
        {
            character.Jump(transform);
            animator.Play("Jump");
        }
            

        isJumping = false;
    }
    private void OnDrawGizmos() //rayo del salto
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, Vector2.down * RayDistance);
    }
}
