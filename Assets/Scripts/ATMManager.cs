using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class ATMManager : MonoBehaviour
{
    
    public void SetText()
    {
        UserInfo.Instance.UserWallet.text = UserInfo.Instance.userWallet.ToString();
        UserInfo.Instance.UserCash.text = UserInfo.Instance.userCash.ToString();
    }

    public void AddCash1()
    {
        if (UserInfo.Instance.userWallet < 10000)
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            UserInfo.Instance.userWallet -= 10000;
            UserInfo.Instance.userCash += 10000;
            SetText();
        }
        
    }
    public void AddCash3()
    {
        if (UserInfo.Instance.userWallet < 30000)
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            UserInfo.Instance.userWallet -= 30000;
            UserInfo.Instance.userCash += 30000;
            SetText();
        }
    }
    public void AddCash5()
    {
        if (UserInfo.Instance.userWallet < 50000)
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            UserInfo.Instance.userWallet -= 50000;
            UserInfo.Instance.userCash += 50000;
            SetText();
        }
    }

    public void SubtractCash1()
    {
        if (UserInfo.Instance.userCash < 10000)
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            UserInfo.Instance.userWallet += 10000;
            UserInfo.Instance.userCash -= 10000;
            SetText();
        }

    }
    public void SubtractCash3()
    {
        if (UserInfo.Instance.userCash < 30000)
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            UserInfo.Instance.userWallet += 30000;
            UserInfo.Instance.userCash -= 30000;
            SetText();
        }
    }
    public void SubtractCash5()
    {
        if (UserInfo.Instance.userCash < 50000)
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            UserInfo.Instance.userWallet += 50000;
            UserInfo.Instance.userCash -= 50000;
            SetText();
        }
    }

  
}
