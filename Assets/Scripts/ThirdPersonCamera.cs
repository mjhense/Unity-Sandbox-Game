using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {

    private const float Y_ANGLE_MIN = -0.0f;
    private const float Y_ANGLE_MAX = 72.0f;

    public Transform lookAt;
    public Transform camTransform;

    private Camera cam;
    private float offsetY = 3.0f;
    private float offsetX = 0.0f;
    private float distance = 10.0f; //offsetZ
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensivityX = 0.0f;
    private float sensivityY = 1.0f;

    private void Start()
    {
        camTransform = transform;
        cam = Camera.main;

    }

    private void Update()
    {
        currentX += Input.GetAxis("Mouse X");
        currentY += -1*Input.GetAxis("Mouse Y");
        currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
        Debug.Log(currentY);
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(offsetX, offsetY, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
    }
}