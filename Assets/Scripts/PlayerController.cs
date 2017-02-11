using UnityEngine;
using System.Collections;
using System;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}
public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public Boundary boundary;
    public float speed;
    private object controller;
    private bool isDashing;
    
    
   
    
    
    Vector3 movement;
    Animator anim;


    public string JumpButton { get; private set; }

    // Use this for initialization
    void Start()
    {
        isDashing = false;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        

    }

    void FixedUpdate()
    {

        float h = Input.GetAxisRaw("Horizontal");
        Move(h);
        Animating(h);        
    }
   void Move(float h)
    {
        movement.Set(h, 0f, 0);
        movement = movement.normalized*speed * Time.deltaTime;
        rb.MovePosition(transform.position + movement);
    }


    void Animating(float h)
    {
        bool running = h == 0f;
        anim.SetBool("IsRunning", running);
    }





}
