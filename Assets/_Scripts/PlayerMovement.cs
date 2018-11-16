using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerMovement : MonoBehaviour
{
    public Animator Anim;
    float dodgeStep = 10;
    float dodgeProgress = 0;
    Vector2 playerPos;
    Vector2 playerPos2;
    Vector3 velocity;
    public float speed;
    public static bool resetPlayerPos = false;
    public Rigidbody2D rb;
    
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            velocity = transform.position;
            velocity.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
            velocity.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            rb.MovePosition(velocity);
        }

        //Primary Functions
        Attack();


        //Rotates Player to look in direction of mouse(Probably wont be used)
        //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
    }

    void Attack()
    {

    }
    
}
