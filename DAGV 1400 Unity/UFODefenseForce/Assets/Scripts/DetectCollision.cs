using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); // Destroy Bolt
        Destroy(other.gameObject); // Destroy Hit Object
    }
}
