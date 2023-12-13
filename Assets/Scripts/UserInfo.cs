using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UserInfo : MonoBehaviour
{
    public static UserInfo Instance { get; private set; }

    public int userWallet;
    public int userCash;

    public Text UserWallet;
    public Text UserCash;

    private void Start()
    {
        UserCash.text = userCash.ToString();
        UserWallet.text = userWallet.ToString();    
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
    
}
