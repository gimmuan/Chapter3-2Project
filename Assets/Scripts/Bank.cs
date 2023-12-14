using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Bank : MonoBehaviour
{
    [SerializeField] TMP_InputField deposit_text;
    [SerializeField] TMP_InputField withdrawal_text; 

    private void Start()
    {
        
    }

    public void TextDeposit()
    {
        if (UserInfo.Instance.userData.wallet < int.Parse(deposit_text.text))
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            UserInfo.Instance.userData.cash += int.Parse(deposit_text.text);
            UserInfo.Instance.userData.wallet -= int.Parse(deposit_text.text);
            SetText();
        }
    }


    public void TextWithdrawal()
    {
        if (UserInfo.Instance.userData.cash < int.Parse(withdrawal_text.text))
        {
            GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(true);
        }
        else
        {
            UserInfo.Instance.userData.wallet += int.Parse(withdrawal_text.text);
            UserInfo.Instance.userData.cash -= int.Parse(withdrawal_text.text);
            SetText();
        }
    }

    public void SetText()
    {
        UserInfo.Instance.UserWallet.text = UserInfo.Instance.userData.wallet.ToString();
        UserInfo.Instance.UserCash.text = UserInfo.Instance.userData.cash.ToString();
    }

   

}
