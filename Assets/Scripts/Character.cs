using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    public GameObject[] helmet;
    public GameObject[] chest;
    public GameObject[] pants;
    public GameObject[] boots;
    private int currentHelmet;
    private int currentChest;
    private int currentPants;
    private int currentBoots;

    public Character instance;

    void Awake()
    {
      


    }
    private void Start()
    {
        instance = this;
        DontDestroyOnLoad(instance);
        Debug.Log("Worked");
    }

    private void OnDestroy()
    {
       /*/ if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
            Debug.Log("Worked");
        }
        else
        {
            Destroy(gameObject);
           Debug.Log("destroyed");
        } /*/

    }
    void Update()
    {
        #region customiser 
        for (int i = 0; i < helmet.Length; i++)
        {
            if (i == currentHelmet)
            {
                helmet[i].SetActive(true);
            }
            else
            {
                helmet[i].SetActive(false);
            }
        }

        for (int i = 0; i < chest.Length; i++)
        {
            if (i == currentChest)
            {
                chest[i].SetActive(true);
            }
            else
            {
                chest[i].SetActive(false);
            }
        }

        for (int i = 0; i < pants.Length; i++)
        {
            if (i == currentPants)
            {
                pants[i].SetActive(true);
            }
            else
            {
                pants[i].SetActive(false);
            }
        }

        for (int i = 0; i < boots.Length; i++)
        {
            if (i == currentBoots)
            {
                boots[i].SetActive(true);
            }
            else
            {
                boots[i].SetActive(false);
            }
        }
        #endregion

    

    }

    public void Randon()
    {
        currentHelmet = Random.Range(0, 4);
        currentChest = Random.Range(0, 4);
        currentPants = Random.Range(0, 4);
        currentBoots = Random.Range(0, 4);
        

        
    }
    public void SwitchHeads()
    {
        if (currentHelmet == helmet.Length - 1)
        {
            currentHelmet = 0;
        }
        else
        {
            currentHelmet++;
        }
    }

    public void SwitchChest()
    {
        if (currentChest == chest.Length - 1)
        {
            currentChest = 0;
        }
        else
        {
            currentChest++;
        }
    }
    
    public void Confirm()
    {
        SceneManager.LoadScene("Game Scene");
    }
    public void SwitchPants()
    {
        if (currentPants == pants.Length - 1)
        {
            currentPants = 0;
        }
        else
        {
            currentPants++;
        }
    }

    public void SwitchBoots()
    {
        if (currentBoots == boots.Length - 1)
        {
            currentBoots = 0;
        }
        else
        {
            currentBoots++;
        }
    }
}



