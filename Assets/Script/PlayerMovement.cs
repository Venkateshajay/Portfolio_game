using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;
    [SerializeField] Vector2 moveInput;
    [SerializeField] float speed;
    private Animator myAnimator;
    private void Start()
    {
        myAnimator = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
    private void Update()
    {
        flip();
        Run();
    }
    void Run()
    {
        Vector2 playerVelocity = new Vector2(moveInput.x * speed,0f);
        playerRigidbody.velocity = playerVelocity;
        bool isPlayerMoving = Mathf.Abs(playerRigidbody.velocity.x) > Mathf.Epsilon;
        myAnimator.SetBool("Walk", isPlayerMoving);
    }
    void flip()
    {
        bool isPlayerMoving = Mathf.Abs(playerRigidbody.velocity.x) > Mathf.Epsilon;
        if (isPlayerMoving)
        {
            transform.localScale = new Vector2(Mathf.Sign(playerRigidbody.velocity.x)*0.4f, 0.4f);
        }
    }
}
