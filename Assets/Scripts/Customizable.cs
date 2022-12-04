using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customizable : MonoBehaviour
{
    public GameObject player;
    public GameObject Camera2;
    public GameObject playerobject;
    public  ThirdPersonController thirdPersonController;
    public GameObject Canvas;
    void Start()
    {
        
    }
    public void Button()
    {
        player.SetActive(false);
        Camera2.SetActive(true);
        thirdPersonController.gameObject.SetActive(true);
        Canvas.SetActive(false);
    }

    void Update()
    {
        
    }
}
