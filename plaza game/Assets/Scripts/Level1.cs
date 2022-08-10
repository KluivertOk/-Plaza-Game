using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    // this will move you to the first level
    public void StartFirstLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // this will show a quit notification in the game
    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
