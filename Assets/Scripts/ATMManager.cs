using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATMManager : MonoBehaviour
{
    public int userWallet;
    public int userCash;
    
    //public string userName;
    //public string id;
    //public string password;

    
    // Start is called before the first frame update
    void Start()
    {
        userWallet = 100000;
        userCash = 50000;
    }

    public void AddCash1()
    {
        if (userWallet < 10000)
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            userWallet -= 10000;
            userCash += 10000;
        }
        
    }
    public void AddCash3()
    {
        if (userWallet < 30000)
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            userWallet -= 30000;
            userCash += 30000;
        }
    }
    public void AddCash5()
    {
        if (userWallet < 50000)
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            userWallet -= 50000;
            userCash += 50000;
        }
    }

    public void SubtractCash1()
    {
        if (userCash < 10000)
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            userWallet += 10000;
            userCash -= 10000;
        }

    }
    public void SubtractCash3()
    {
        if (userCash < 30000)
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            userWallet += 30000;
            userCash -= 30000;
        }
    }
    public void SubtractCash5()
    {
        if (userCash < 50000)
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            userWallet += 50000;
            userCash -= 50000;
        }
    }
    public void AddTextNum()
    {

    }
    public void SubtractTextNum()
    {

    }

}
