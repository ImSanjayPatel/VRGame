using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public float time = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time - 0.001f;
        Debug.Log(time);
        if (time < 1)
        {
            Debug.Log("End");
            SceneManager.LoadScene("End Scene");

        }
    }
}
