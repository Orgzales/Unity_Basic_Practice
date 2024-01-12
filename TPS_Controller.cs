using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPS_Controller : MonoBehaviour
{

    Rigidbody RB;

    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RB.AddForce(Vector3.up * 500);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            RB.velocity = Vector3.forward * 3f;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            RB.velocity = Vector3.back * 3f;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            RB.velocity = Vector3.left * 3f;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            RB.velocity = Vector3.right * 3f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            float RND = Random.Range(0,3);

            switch(RND){
                case 0:
                    RB.velocity = Vector3.forward * 10f;
                    break;
                case 1:
                    RB.velocity = Vector3.back * 10f;
                    break;
                case 2:
                    RB.velocity = Vector3.left * 10f;
                    break;
                case 3:
                    RB.velocity = Vector3.right * 10f;
                    break;
            }

            RB.AddForce(Vector3.up * 500);

        }
    }

}
