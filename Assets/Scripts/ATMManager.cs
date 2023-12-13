using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class ATMManager : MonoBehaviour
{
    //public Text textDesposit;
    //public Text textWithdrawal;
    //public InputField InputText_Desposit;
    //public InputField InputText_Withdrawal;
    

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

    //public void Input()
    //{
    //    if (UserInfo.Instance.userWallet > int.Parse(textDesposit.text))
    //    {
    //        UserInfo.Instance.userCash += int.Parse(textDesposit.text);
    //        UserInfo.Instance.userWallet -= int.Parse(textDesposit.text);
    //        SetText();
    //    }
    //    else
    //    {
    //        GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
    //    }
    //}
    //public void Output()
    //{
    //    if (UserInfo.Instance.userCash > int.Parse(textWithdrawal.text))
    //    {
    //        UserInfo.Instance.userCash -= int.Parse(textWithdrawal.text);
    //        UserInfo.Instance.userWallet += int.Parse(textWithdrawal.text);
    //        SetText();
    //    }
    //    else
    //    {
    //        GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
    //    }
    //}
}
