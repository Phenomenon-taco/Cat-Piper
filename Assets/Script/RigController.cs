using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigController : MonoBehaviour {
    public float moveSpeed = 8.5f, jumpForce = 4.0f;
    public int coins = 0;
    float VerticalVelocity, gravity = 30.0f;
    Rigidbody2D rb;
    Animator anim;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	void Update () {
        float moveX = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.LoadLevel(0);

        if (moveX != 0)
        {
            anim.SetBool("Move", true);
            if (moveX < 0)
                gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
            else
                gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        else
            anim.SetBool("Move", false);

        rb.MovePosition(rb.position + Vector2.right * moveX * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 8000);
            anim.SetBool("Jump", true);
        }
        else
            anim.SetBool("Jump", false);

    }
}
