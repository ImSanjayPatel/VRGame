using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyBar : MonoBehaviour
{
    public Image moneyBar;
    public int money;
    public int startMoney;

    public void OnPlayerChooseOption(int cost)
    {
        money = money - cost;
        moneyBar.fillAmount = money / startMoney;
        Debug.Log(money);
    }
}
