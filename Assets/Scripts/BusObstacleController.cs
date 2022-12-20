using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusObstacleController : MonoBehaviour
{
    //assigns local variables
    private float speed;
    private float turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //random speed is picked on start
        speed = Random.Range(10f, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        //turn speed is calcuated randomly so vehicle swerves
        turnSpeed = Random.Range(-1f, 1f);

        //movement for vehicle
        transform.Translate(Vector3.back * Time.deltaTime * speed);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * 15);


    }
}
