using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    private float SW;
    private Vector3 PressPoint;
    private Quaternion SR;
    public GameObject canvas;



    private void Start()
    {
        SW = Screen.width;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            PressPoint = Input.mousePosition;
            SR = transform.rotation;
            canvas.SetActive(false);
        }

        else if (Input.GetMouseButton(1))
        {
            float CD = (Input.mousePosition - PressPoint).x;
            transform.rotation = SR * Quaternion.Euler(Vector3.up * (CD / SW) * 360);
            // canvas.SetActive(true);
        }
        else if(Input.GetMouseButtonUp(1))
        {
            canvas.SetActive(true);
        }
    }
}


