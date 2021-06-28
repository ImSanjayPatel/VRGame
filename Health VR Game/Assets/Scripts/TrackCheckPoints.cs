using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrackCheckPoints : MonoBehaviour
{

    public event EventHandler OnPlayerCorrectCheckpoint;
    public event EventHandler OnPlayerWrongCheckpoint;

    private List<CheckpointSingle> checkpointSingleList;
    private int nextCheckpointSingleIndex;


    private void Awake()
    {
        Transform checkpointsTransform = transform.Find("Checkpoints");

        checkpointSingleList = new List<CheckpointSingle>();
        foreach (Transform checkpointSingleTransform in checkpointsTransform)
        {
            CheckpointSingle checkpointSingle = checkpointSingleTransform.GetComponent<CheckpointSingle>();

            checkpointSingle.SetTrackCheckpoint(this);

            checkpointSingleList.Add(checkpointSingle);

        }

        nextCheckpointSingleIndex = 0;

    }

    public void PlayerThroughCheckpoint(CheckpointSingle checkpointSingle)
    {
        if (checkpointSingleList.IndexOf(checkpointSingle) == nextCheckpointSingleIndex)
        {
            // Correct checkpoint
            Debug.Log("Correct");
            nextCheckpointSingleIndex++;
            OnPlayerCorrectCheckpoint?.Invoke(this, EventArgs.Empty);

            if (checkpointSingleList.IndexOf(checkpointSingle) == 3)  //21
            {
                Debug.Log("End Point");
                SceneManager.LoadScene("Dinner2");
            }
        }
        else
        {
            // Incorrect checkpoints
            Debug.Log("Incorrect");
            OnPlayerWrongCheckpoint?.Invoke(this, EventArgs.Empty);
            
        }

        if (checkpointSingleList.IndexOf(checkpointSingle) == 3)
        {
            Debug.Log("End Point");
            SceneManager.LoadScene("Dinner2");
        }

    }
}
