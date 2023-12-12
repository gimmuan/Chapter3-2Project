using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ATMManager : MonoBehaviour
{
    public int cash;
    public int wallet;

    //public string userName;
    //public string id;
    //public string password;

    
    // Start is called before the first frame update
    void Start()
    {
        cash = UserInfo.instance.userCash;
        wallet = UserInfo.instance.userWallet;
    }

    public void AddCash1()
    {
        if (UserInfo.instance.userCash < 10000)
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            UserInfo.instance.userWallet -= 10000;
            UserInfo.instance.userCash += 10000;
        }
        
    }
    public void AddCash3()
    {
        if (UserInfo.instance.userWallet < 30000)
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            UserInfo.instance.userWallet -= 30000;
            UserInfo.instance.userCash += 30000;
        }
    }
    public void AddCash5()
    {
        if (UserInfo.instance.userWallet < 50000)
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            UserInfo.instance.userWallet -= 50000;
            UserInfo.instance.userCash += 50000;
        }
    }

    public void SubtractCash1()
    {
        if (UserInfo.instance.userCash < 10000)
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            UserInfo.instance.userWallet += 10000;
            UserInfo.instance.userCash -= 10000;
        }

    }
    public void SubtractCash3()
    {
        if (UserInfo.instance.userCash < 30000)
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            UserInfo.instance.userWallet += 30000;
            UserInfo.instance.userCash -= 30000;
        }
    }
    public void SubtractCash5()
    {
        if (UserInfo.instance.userCash < 50000)
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            UserInfo.instance.userWallet += 50000;
            UserInfo.instance.userCash -= 50000;
        }
    }
    //public void AddTextNum()
    //{
        
    //}
    //public void SubtractTextNum()
    //{

    //}

}
