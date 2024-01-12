using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke_script : MonoBehaviour
{

    GameObject[] cubes;

    public float waiting_time;
    void Start()
    {
        // DestroyAllCubes();

        // Invoke("DestroyAllCubes", 2f);

        // StartCoroutine("DestroyCubes");

        StartCoroutine(DestroyCubes(waiting_time));
    }

    void Update()
    {

    }

    void DestroyAllCubes()
    {
        cubes = GameObject.FindGameObjectsWithTag("Cube");

        foreach (GameObject g in cubes)
        {
            Destroy(g);
        }

    }

    IEnumerator DestroyCubes(float waitTime)
    {

        // yield return new WaitForSeconds(2);

        cubes = GameObject.FindGameObjectsWithTag("Cube");

        foreach (GameObject g in cubes)
        {
            yield return new WaitForSeconds(waitTime);

            Destroy(g);
        }

    }

}
