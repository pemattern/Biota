using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinOsc : MonoBehaviour
{

    private Vector3 startPosition;
    
    private float oscSpeed;

    private float oscDistance;

    public float oscStartAngle;

    void Start()
    {
        startPosition = transform.position;
        oscSpeed = 1.5f;
        oscDistance = 0.1f;
    }

    void Update()
    {
        transform.position = startPosition + new Vector3(0.0f, oscDistance*(Mathf.Sin((oscSpeed*Time.time)+oscStartAngle)), 0.0f);
    }
}
