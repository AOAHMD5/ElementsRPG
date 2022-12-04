using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Price : MonoBehaviour
{
    public Masks maskprice;
    public Weapon WeaponPrice;
    public ChangeColour ColourCost;
    public Text price;
    public float pricetotal;
    // Start is called before the first frame update
    void Update()
    {
        
        pricetotal = ColourCost.ColourCost + maskprice.maskprice + WeaponPrice.WeaponPrice;
        price.text = "Total Price:" + pricetotal.ToString();
    }

    // Update is called once per frame

}
