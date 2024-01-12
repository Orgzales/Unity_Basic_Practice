using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Controller : MonoBehaviour
{

    public float rotate_speed;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void FixedUpdate() {
        transform.Rotate(Vector3.up, rotate_speed);
    }



}
