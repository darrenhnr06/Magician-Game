using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Vector3 vector3;
    float speed;

    private void Awake()
    {
        vector3 = transform.position;
        speed = 0.2f;
    }

    private void Update()
    {
        if(StaticClass.startCam == true)
        {
            vector3.z -= speed * Time.deltaTime;
            transform.position = vector3;
        }
    }
}
