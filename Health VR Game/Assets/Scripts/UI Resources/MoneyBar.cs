using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoneyBar : MonoBehaviour
{
    public Image moneyBar;
    public static float money = 35;
    public static float startMoney = 35;
    public bool CantAfford = false;

    public void OnPlayerChooseOption(int cost)
    {
        Debug.Log(money);
    
        money = money - cost;
        float startTotal = 100 / startMoney;
        startTotal *= money;
        startTotal = startTotal / 100;
        moneyBar.fillAmount = startTotal;
        Debug.Log(money);


    }

    public void AddAmountSubtracted(int cost)
    {
        Debug.Log(money);

        money = money + cost;
        float startTotal = 100 / startMoney;
        startTotal *= money;
        startTotal = startTotal / 100;
        moneyBar.fillAmount = startTotal;
        Debug.Log(money);


    }
}