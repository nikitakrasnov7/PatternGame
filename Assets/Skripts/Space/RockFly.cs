using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockFly : MonoBehaviour
{
    List<Vector3> startVectorFly = new List<Vector3>()
    {
        new Vector3(9000,900,90000),
        new Vector3(-9000,900,90000),
        new Vector3(9000,-900,-90000),
        new Vector3(9000,900,-90000),
        new Vector3(-9000,-900,90000),
        new Vector3(9000,900,-90000),
        new Vector3(-9000,-900,-90000)
    };

    Vector3 rot;

    GravityController mainPlanet;
    private void Start()
    {
        mainPlanet = FindAnyObjectByType<GravityController>();

        GetComponent<Rigidbody>().AddForce(startVectorFly[Random.Range(0,startVectorFly.Count)]);
        rot = new Vector3(Random.Range(-5, 5), Random.Range(-5,5), Random.Range(-5, 5));
    }
    private void FixedUpdate()
    {
        gameObject.transform.Rotate(rot);

        float dist = Vector3.Distance(gameObject.transform.position, mainPlanet.gameObject.transform.position);
        if(dist > 150)
        {
            
            Destroy(gameObject);

        }
    }


}
