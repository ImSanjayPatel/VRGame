using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LunchCounter1 : MonoBehaviour
{
    public MoneyBar moneybar;
    public int Check = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Burger" && Check == 0)
        {
            Debug.Log("Detected");
            if (moneybar)
            {
                moneybar.OnPlayerChooseOption(7);
                SceneManager.LoadScene("WalkingTaskFF");
                Check++;
            }
        }

        if (collision.gameObject.tag == "Salad" && Check == 0)
        {
            Debug.Log("Detected");
            if (moneybar)
            {
                moneybar.OnPlayerChooseOption(13);
                SceneManager.LoadScene("WalkingTaskHF");
                Check++;
                Debug.Log("Detected");
            }
        }
    }
}
