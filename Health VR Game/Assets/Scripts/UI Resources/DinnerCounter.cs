using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DinnerCounter : MonoBehaviour
{
    public MoneyBar moneybar;
    public int Check = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pizza" && Check == 0)
        {
            if (moneybar)
            {
                moneybar.OnPlayerChooseOption(9);
                SceneManager.LoadScene("End Scene");
                Check++;
            }
        }

        if (collision.gameObject.tag == "Salmon" && Check == 0)
        {
            if (moneybar)
            {
                moneybar.OnPlayerChooseOption(14);
                Debug.Log(MoneyBar.money);
                if (MoneyBar.money == -1)
                {
                    Debug.Log("Cant- Afford");
                    moneybar.AddAmountSubtracted(14);
                    SceneManager.LoadScene("Dinner2");

                }
                else
                {
                    SceneManager.LoadScene("T3FF");
                }
                
                Check++;
                //Debug.Log(moneybar.money);
            }
        }
    }
}
