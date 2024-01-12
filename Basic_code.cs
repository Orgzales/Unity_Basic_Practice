using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Basic_code : MonoBehaviour
{

    Rigidbody RB;
    public GameObject winText;
    float xInput;
    float zInput;

    public float speed;

    void Start()
    {
        //Destroy(gameObject);

        RB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // RB.AddForce(Vector3.up * 500);
        }

        // RB.velocity = Vector3.forward * 20f;
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Level1");
        }


        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        RB.AddForce(xInput * speed, 0, zInput * speed);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            // Destroy(gameObject);
            Destroy(collision.gameObject);

            winText.SetActive(true);

        }
    }


    private void OnMouseDown()
    {
        Destroy(gameObject);

    }

}
