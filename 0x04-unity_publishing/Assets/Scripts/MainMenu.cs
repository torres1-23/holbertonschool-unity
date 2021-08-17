using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // ColorBlind and normal scene mode variables
    public Material trapMat;
    public Material goalMat;
    public Toggle colorblindMode;

    /// <summary>PlayButton on click loads the maze scene 
    /// if Color Blind Toggle is on game renders in colorBlind mode</summary>
    public void PlayMaze()
    {
        if (colorblindMode.isOn)
        {
            trapMat.color = new Color32(255, 112, 0, 1);
            goalMat.color = Color.blue;
        }
        else
        {
            trapMat.color = Color.red;
            goalMat.color = Color.green;
        }
      
        SceneManager.LoadScene("maze", LoadSceneMode.Single);
    }

    /// <summary>QuitButton on click quits game</summary>
    public void QuitMaze()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
