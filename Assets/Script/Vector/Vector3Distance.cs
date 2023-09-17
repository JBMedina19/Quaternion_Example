using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Distance : MonoBehaviour
{
    public Transform other;

    //checks the distance the transform position and the targetA
    void Update()
    {
        if (other)
        {
            float dist = Vector3.Distance(other.position, transform.position);
            print("Distance to other: " + dist);
        }
    }
}
