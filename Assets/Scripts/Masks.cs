using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Masks : MonoBehaviour
{


    public int currMasks = 0;
    public float maskprice;
    public GameObject[] masks;
    // Start is called before the first frame update

    private void Update()
    {
        prices();
    }

    public void prices()
    {
        if(currMasks == 0)
        {
            maskprice = 100;
        }
        if (currMasks == 1)
        {
            maskprice = 200;
        }
        if (currMasks == 2)
        {
            maskprice = 300;
        }
        if (currMasks == 3)
        { 
            maskprice = 400;
        }
    }
    public void BtnClick()
    {
        masks[currMasks].SetActive(false);

        currMasks++;

        if ((currMasks) >= masks.Length)
        {
            currMasks = 0;
        }
        masks[currMasks].SetActive(true);
    }

    public void BtnClickPrev()
    {
        masks[currMasks].SetActive(false);

        //currMasks = currMasks + 3;

        currMasks--;
      

        if ((currMasks) <= 0)
        {
            currMasks = 3;
        }


        masks[currMasks].SetActive(true);
    }
}
