using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Bank : MonoBehaviour
{
    InputField deposit_text;
    InputField withdrawal_text;

    private void Start()
    {
        deposit_text = GameObject.Find("Main").transform.Find("DepositMenu").GetComponent<InputField>();
        withdrawal_text = GameObject.Find("Main").transform.Find("WithdrawalMenu").GetComponent<InputField>();
    }

    public void TextDeposit()
    {
        if (UserInfo.Instance.userWallet < int.Parse(deposit_text.text))
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            UserInfo.Instance.userCash += int.Parse(deposit_text.text);
            UserInfo.Instance.userWallet -= int.Parse(deposit_text.text);
            SetText();
        }
    }

    public void TextWithdrawal()
    {
        if (UserInfo.Instance.userCash < int.Parse(withdrawal_text.text))
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            UserInfo.Instance.userWallet += int.Parse(withdrawal_text.text);
            UserInfo.Instance.userCash -= int.Parse(withdrawal_text.text);
            SetText();
        }
    }

    public void SetText()
    {
        UserInfo.Instance.UserWallet.text = UserInfo.Instance.userWallet.ToString();
        UserInfo.Instance.UserCash.text = UserInfo.Instance.userCash.ToString();
    }

   

}
