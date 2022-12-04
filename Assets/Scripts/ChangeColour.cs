using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColour : MonoBehaviour
{

    public GameObject armour;
    private Renderer armourRender;
    private Color newColor;
    public float ColourCost = 0;
    // Start is called before the first frame update
    void Start()
    {
        armourRender = armour.GetComponent<Renderer>();
    }
     void Update()
    {
        //BlackArmour();
    }
    public void BlackArmour()
    {
        newColor = new Color(0, 0, 0, 1);
        armourRender.material.SetColor("_Color", newColor);
        ColourCost = 500;
    }

    public void RedArmour()
    {
        newColor = new Color(1, 0, 0, 1);
        armourRender.material.SetColor("_Color", newColor);
        ColourCost = 600;
    }

    public void BlueArmour()
    {
        newColor = new Color(0, 0, 1, 1);
        armourRender.material.SetColor("_Color", newColor);
        ColourCost = 700;
    }

    public void GreenArmour()
    {
        newColor = new Color(0, 1, 0, 1);
        armourRender.material.SetColor("_Color", newColor);
        ColourCost = 800; 
    }

}
