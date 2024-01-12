using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    GameObject[] cubes;
    GameObject[] spheres;

    void Start()
    {
        // GameObject cube = GameObject.FindWithTag("Cube");
        cubes = GameObject.FindGameObjectsWithTag("Cube");
        spheres = GameObject.FindGameObjectsWithTag("Sphere");

        // foreach (GameObject x in cubes)
        // {
        //     Destroy(x.gameObject);

        // }


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (GameObject g in cubes)
            {
                Destroy(g.gameObject);
            }
        }



        if (Input.GetKeyDown(KeyCode.S))
        {
            foreach (GameObject g in spheres)
            {
                Destroy(g.gameObject);
            }
        }
    }
}
