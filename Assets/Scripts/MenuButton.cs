using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{

    public void DespositMenu()
    {
        GameObject.Find("Main").transform.Find("Menu").gameObject.SetActive(false);
        GameObject.Find("Main").transform.Find("DespositMenu").gameObject.SetActive(true);

    }

    public void DespositMenuCancel()
    {
        GameObject.Find("Main").transform.Find("DespositMenu").gameObject.SetActive(false);
        GameObject.Find("Main").transform.Find("Menu").gameObject.SetActive(true);
    }

    public void WithDrawal()
    {
        GameObject.Find("Main").transform.Find("Menu").gameObject.SetActive(false);
        GameObject.Find("Main").transform.Find("WithdrawalMenu").gameObject.SetActive(true);
    }

    public void WithDrawalMenuCancel()
    {
        GameObject.Find("Main").transform.Find("WithdrawalMenu").gameObject.SetActive(false);
        GameObject.Find("Main").transform.Find("Menu").gameObject.SetActive(true);
    }

    public void ErrorCheck()
    {
        GameObject.Find("Main").transform.Find("Error").gameObject.SetActive(false);
    }
}
