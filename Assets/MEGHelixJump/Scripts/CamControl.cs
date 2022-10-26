using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public Transform Ball;
    private Vector3 offset;
    public float smoothSpeed;

    void Start()
    {
        offset = transform.position - Ball.position;
    }

    void LateUpdate()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, offset + Ball.position, smoothSpeed);
        transform.position = newPos;
    }
}
