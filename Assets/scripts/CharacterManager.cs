using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public float speed;
    public float RayDistance;
    public float JumpForce;
    private bool isJumping = false;

    protected ThreefoldTrip.Character character;
    protected SpriteRenderer rend;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

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
    //public void Shander()
    //{
    //    character = new ThreefoldTrip.Shander(speed, GetComponent<Rigidbody2D>());
    //}

    // Update is called once per frame
    void Update()
    {
        character.Update();
        if (Input.GetKeyDown(KeyCode.E))
        {
            character.Skill();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            isJumping = true;
        }

    }

    private void FixedUpdate()
    {
        character.Run();

        if (isJumping)
            character.Jump(transform);
        isJumping = false;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, Vector2.down * RayDistance);
    }
}
//