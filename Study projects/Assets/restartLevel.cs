using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartLevel : MonoBehaviour
{
    public lineMovement moveP;
    public destroyLevel moveL;
    public float levelRestartDelay = 1f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Wall")
        {
            EndGame();

            Debug.Log("Hit Something");
        }
    }
    public void EndGame()
    {
        moveP.enabled = false;
        moveL.sum = 0;
        moveL.moveEnabled = false;
        Invoke("RestartLevel", levelRestartDelay);
    }

    // Update is called once per frame
    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
