using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit Game");
    }
    public void Playgame()
    {
        SceneManager.LoadScene("Level 1");
    }
}
