using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D rigidBody;
    private Vector2 moveAmount;
    private Animator aminator;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        aminator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveAmount = moveInput.normalized * Speed;

        //Changing the MotionState on Key held down
        if (moveInput != Vector2.zero)
        {
            aminator.SetInteger("MotionState", (int)PlayMotionState.Run);
        }
        else
        {
            aminator.SetInteger("MotionState", (int)PlayMotionState.Idle);
        }

    }
    void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + moveAmount * Time.fixedDeltaTime);
    }
}
