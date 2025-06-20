using System;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5;
    public Rigidbody2D rb;
    public Animator anim;
    public int facingDirection = 1;
    void Start()
    {

    }
    //Fixed update runs 50x times per sec
    void FixedUpdate()
    {
        float horizaontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizaontal > 0 && transform.localScale.x < 0 ||
            horizaontal < 0 && transform.localScale.x > 0)
        {
            Flip();
        }
        anim.SetFloat("horizontal", Math.Abs(horizaontal));
        anim.SetFloat("vertical", Math.Abs(vertical));

        rb.linearVelocity = new Vector2(horizaontal, vertical) * speed;
    }

    void Flip()
    {
        facingDirection *= -1;
        transform.localScale = new Vector3(
            transform.localScale.x * -1,
            transform.localScale.y,
            transform.localScale.z);
    }
}
