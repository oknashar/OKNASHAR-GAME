using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManger : MonoBehaviour
{
    // Start is called before the first frame update
    bool gameHasEnded = false;
    public GameObject gameObjectUI;
   public void endGame()
    {
        if (gameHasEnded == false)
        {
            Debug.Log("Game over");
            gameHasEnded = true;
            // restart 
            Invoke("Restart", 1f);
        }
    }
    public void CompleteLevel()
    {
        Debug.Log("Level Won");
        gameObjectUI.SetActive(true);
    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
