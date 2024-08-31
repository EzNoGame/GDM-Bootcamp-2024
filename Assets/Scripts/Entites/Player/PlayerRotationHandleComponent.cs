using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotationHandleComponent : MonoBehaviour
{
    [SerializeField]
    private Camera _camera;

    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, _camera.transform.rotation.eulerAngles.y, 0);        
    }
}
