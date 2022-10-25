using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    [SerializeField] private float travelSpeed = 40.0f;
    [SerializeField] private float topBound = 30.0f;
    
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * travelSpeed);

        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
    }
}
