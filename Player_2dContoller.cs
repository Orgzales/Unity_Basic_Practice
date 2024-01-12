using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2dContoller : MonoBehaviour
{

    public float moveSpeed;
    float xInput, yInput;

    Vector2 targetPos;

    Rigidbody2D rb;

    SpriteRenderer sp;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
    }

    void Start()
    {

    }

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 10f;

        if (Input.GetMouseButtonDown(0))
        {
            targetPos = mousePos;
        }

        // transform.position = mousePos;

    }


    private void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        transform.Translate(xInput * moveSpeed, yInput * moveSpeed, 0);


        // ClickToMove();
        PlatformerMove();
        FlipPlayer();
    }

    void ClickToMove()
    {

        transform.position = Vector2.MoveTowards(transform.position, targetPos, moveSpeed);

    }

    void PlatformerMove()
    {
        rb.velocity = new Vector2(moveSpeed * xInput, rb.velocity.y);
    }

    void FlipPlayer()
    {
        if (rb.velocity.x < -0.1f)
        {
            sp.flipX = true;
        }
        else if (rb.velocity.x > 0.1f)
        {
            sp.flipX = false;
        }


    }

}
