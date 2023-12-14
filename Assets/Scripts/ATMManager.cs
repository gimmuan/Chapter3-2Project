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
        UserInfo.Instance.UserWallet.text = UserInfo.Instance.userData.wallet.ToString();
        UserInfo.Instance.UserCash.text = UserInfo.Instance.userData.cash.ToString();
    }

    public void AddCash(int money)
    {
        if (UserInfo.Instance.userData.wallet < money)
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            UserInfo.Instance.userData.wallet -= money;
            UserInfo.Instance.userData.cash += money;
            SetText();
        }
        
    }
    
    public void SubtractCash(int money)
    {
        if (UserInfo.Instance.userData.cash < money)
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            UserInfo.Instance.userData.wallet += money;
            UserInfo.Instance.userData.cash -= money;
            SetText();
        }

    }
}
