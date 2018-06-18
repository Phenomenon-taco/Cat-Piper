using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    public float moveSpeed = 8.5f, jumpForce=4.0f;
    float VerticalVelocity, gravity=30.0f;
    CharacterController controller;
    Vector2 moveVector;

	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	void Update () {
        moveVector = Vector2.zero;

        if (controller.isGrounded)
        {
            //VerticalVelocity = 0;
            VerticalVelocity = gravity * Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.Space))
                VerticalVelocity = jumpForce*moveSpeed;
        }
        else
            VerticalVelocity = -gravity*Time.deltaTime;

        moveVector.x = Input.GetAxisRaw("Horizontal")*moveSpeed*Time.deltaTime;
        moveVector.y = VerticalVelocity * moveSpeed * Time.deltaTime;

        controller.Move(moveVector);
	}
}
