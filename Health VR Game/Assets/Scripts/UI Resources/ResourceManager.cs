using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour
{
    [SerializeField] Text TextUIMoney;

    private int _money;
    public int Money {

        get{ return _money; }
        set{
            _money = value; // Here we can set the value
            TextUIMoney.text = Money.ToString();

        }
    }


}
