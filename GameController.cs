using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject ball;
    public Transform spawnpoint;

    public float maxX;
    public float maxZ;

    void Start()
    {
        // SpawnBall();
        InvokeRepeating("SpawnBall", 1f, 2f); 
        //first number is when to start and second number is how often to repeat
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBall();
        }

        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;

            mousePos.z = 10f;

            Vector3 spawnPos = Camera.main.ScreenToWorldPoint(mousePos);
            Instantiate(ball, spawnPos, Quaternion.identity);
        }

    }

    void SpawnBall()
    {

        float randomX = Random.Range(-maxX, maxX);
        float randomZ = Random.Range(-maxZ, maxZ);

        Vector3 randomSpawnPos = new Vector3(randomX, 10f, randomZ);

        Instantiate(ball, randomSpawnPos, Quaternion.identity);

        // Instantiate(ball, spawnpoint.position, Quaternion.identity);
    }
}
