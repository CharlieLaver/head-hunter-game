using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    Transform PlayerTransform;
    Vector3 camOffset;
    float SmoothFactor = 1f;

    void Start()
    {
        PlayerTransform = GameObject.FindWithTag("Player").transform;
        camOffset = transform.position - PlayerTransform.position;
    }

    void Update()
    {
        Vector3 newPos = PlayerTransform.position + camOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
    }
}
