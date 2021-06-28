using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnergyBar1 : MonoBehaviour
{
    public Image energyBar;
    public float energy = 5.5f;
    public float startenergy = 5.5f;
    public bool CantAfford = false;

    public void OnPlayerChooseOption(float cost)
    {
        Debug.Log(energy);

        energy = energy - cost;
        float startTotal = 100 / startenergy;
        startTotal *= energy;
        startTotal = startTotal / 100;
        energyBar.fillAmount = startTotal;
        Debug.Log(energy);


    }

  
}