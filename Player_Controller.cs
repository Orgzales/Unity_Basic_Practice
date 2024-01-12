using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    Rigidbody rb;

    float xInput;
    float zInput;
    public float moveSpeed;

    public AudioClip coinSound;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate() {
        float xVelocity = xInput * moveSpeed;
        float zVelocity = zInput * moveSpeed;

        rb.velocity = new Vector3(xVelocity, rb.velocity.y, zVelocity);

    }

    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.tag == "Coin" ){
            Destroy(collision.gameObject);

            // GetComponent<AudioSource>().Play();
            GetComponent<AudioSource>().PlayOneShot(coinSound);
        }
    }



}
