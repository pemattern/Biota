using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{

    private float bgScrollSpeed;

    private Vector3 startBGPosition;

    // Start is called before the first frame update
    void Start()
    {
        bgScrollSpeed = 0.2f;
        startBGPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        startBGPosition = transform.position;

        transform.position = startBGPosition + new Vector3(bgScrollSpeed*Time.deltaTime, bgScrollSpeed*Time.deltaTime, 0);

        if (transform.position.x > 4 && transform.position.y > 4)
        {
            transform.position = new Vector3(0,0,0);
        } else {

        }

    }
}
