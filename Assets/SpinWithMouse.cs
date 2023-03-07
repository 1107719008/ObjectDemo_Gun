using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinWithMouse : MonoBehaviour
{
    [SerializeField] public bool a = false;
    float rotationSpeed = 4f;
    void OnMouseDrag()
    {
        float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        float YaxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;
        if (a == true)
        {
           transform.Rotate(Vector3.right, YaxisRotation);
        }
         transform.Rotate(Vector3.down, XaxisRotation);

        
    }
}
