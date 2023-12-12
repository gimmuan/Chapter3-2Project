using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInfo : MonoBehaviour
{
    public static UserInfo instance;

    public int userWallet;
    public int userCash;
    
    private void Awake()
    {
        instance = this;
    }
    
}
