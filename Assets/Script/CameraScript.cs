using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    //player position
    Transform lookAt;
    //start cam position offset
    Vector3 startOffset;
    Vector3 moveVector;


    void Start()
    {
        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
        startOffset = transform.position - lookAt.position;
    }

    void Update()
    {
        moveVector = lookAt.position + startOffset;
        moveVector.y = -0.75f;
        moveVector.z = -1;
        transform.position = moveVector;
    }
}
