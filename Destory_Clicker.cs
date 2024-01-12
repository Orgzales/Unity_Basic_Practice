using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory_Clicker : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (this.gameObject.tag == "Cube")
        {
            Destroy(gameObject);
        }
    }

}
