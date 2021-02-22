using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MoveHome : MonoBehaviour
{
    //인스펙터 창에 보여짐
    [SerializeField]
    private float speed;
    private Vector2 direction;
    public int walkCount;
    private int currentWalkCount;
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.zero;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        Move();
    }
    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
    private void GetInput()
    {
        Vector2 moveVector;

        moveVector.x = Input.GetAxisRaw("Horizontal");
        moveVector.y = Input.GetAxisRaw("Vertical");

        direction = moveVector;

        animator.SetFloat("DirX", moveVector.x);
        animator.SetFloat("DirY", moveVector.y);
        animator.SetBool("Walking", true);

        while (currentWalkCount < walkCount)
        {

        }
        currentWalkCount = 0;

        //animator.SetBool("Walking", false);
    }

}
