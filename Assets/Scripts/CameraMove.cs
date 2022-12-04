using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;
    public float sensitivity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

   
  
    void FixedUpdate()
    {
        float rotateHorizontal = Input.GetAxis("Mouse X");
        float rotateVertical = Input.GetAxis("Mouse Y");
        transform.RotateAround(player.transform.position, Vector3.up, rotateHorizontal * sensitivity);
        transform.RotateAround(Vector3.zero, transform.right, rotateVertical * sensitivity);
    }
}
