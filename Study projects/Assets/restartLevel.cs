using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartLevel : MonoBehaviour
{
    public lineMovement moveP;
    public moveLevels moveL;
    public float levelRestartDelay = 1f;

    public void EndGame()
    {
        moveP.enabled = false;
        moveL.enabled = false;
        Invoke("RestartLevel", levelRestartDelay);
    }

    // Update is called once per frame
    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
