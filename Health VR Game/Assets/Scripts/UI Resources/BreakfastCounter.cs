using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BreakfastCounter : MonoBehaviour
{
    public MoneyBar moneybar;
    public int Check = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Loops" && Check == 0)
        {
            if (moneybar)
            {
                moneybar.OnPlayerChooseOption(4);
                SceneManager.LoadScene("Clean Up Task Fix");
                Check++;
            }
        }

        if (collision.gameObject.tag == "Toast")
        {
            if (moneybar)
            {
                moneybar.OnPlayerChooseOption(11);
                SceneManager.LoadScene("Walking Task");
                Check++;
            }
        }
    }
}
