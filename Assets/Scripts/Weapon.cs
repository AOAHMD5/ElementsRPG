using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{

    public int CurWeapon = 0;
    public float WeaponPrice;
   // public List<GameObject> weapons;
    public GameObject[] weapons;
    // public Button btn;

    private void Update()
    {
        prices();
    }


    public void prices()
    {
        if (CurWeapon == 0)
        {
            WeaponPrice = 500;
        }
        if (CurWeapon == 1)
        {
            WeaponPrice = 700;
        }
        if (CurWeapon == 2)
        {
            WeaponPrice = 900;
        }
      
    }
    public void BtnClick()
    {
        weapons[CurWeapon].SetActive(false);

        CurWeapon++;

        if ((CurWeapon) >= weapons.Length)
        {
            CurWeapon = 0;
        }
        weapons[CurWeapon].SetActive(true);
    }


    public void BtnClickPrev()
    {
        weapons[CurWeapon].SetActive(false);

        CurWeapon--;

        if ((CurWeapon) <= 0)
        {
            CurWeapon = 2;
        }
        weapons[CurWeapon].SetActive(true);
    }
    

}
