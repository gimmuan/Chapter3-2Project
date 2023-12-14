using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UserInfo : MonoBehaviour
{
    public static UserInfo Instance { get; private set; }

    public UserData userData;

    public Text UserWallet;
    public Text UserCash;

    private void Start()
    {
        UserCash.text = FormatNumber(userData.cash);
        UserWallet.text = FormatNumber(userData.wallet);   
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }
    
    string FormatNumber(int num)
    {
        return string.Format("{0:N0}", num);
    }
}
