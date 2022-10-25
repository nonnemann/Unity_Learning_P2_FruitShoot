using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    [SerializeField] private float travelSpeed = 40.0f;
    [SerializeField] private float lowerBound = -10.0f;
    
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * travelSpeed);
        
        if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
