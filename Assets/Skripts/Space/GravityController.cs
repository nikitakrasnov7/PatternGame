using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    List<Rigidbody> objectInsideGravity = new List<Rigidbody>();
    Rigidbody rigidbodyPlanet;

    private void Start()
    {
        rigidbodyPlanet = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody != null) 
        {
            objectInsideGravity.Add(other.attachedRigidbody);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.attachedRigidbody != null) 
        {
            objectInsideGravity.Remove(other.attachedRigidbody);
        }
    }

    private void FixedUpdate()
    {
        foreach (Rigidbody rigObject in objectInsideGravity) 
        {
            Vector3 directionToPlanet = (transform.position - rigObject.transform.position).normalized;

            float distation = (transform.position - rigObject.transform.position).magnitude;
            float strenght = 10 * rigObject.mass * rigidbodyPlanet.mass / (distation * distation);
            rigObject.AddForce(directionToPlanet * strenght);



            if (distation < 80)
                rigObject.drag = 5 / distation;
        }

        
    }
}


