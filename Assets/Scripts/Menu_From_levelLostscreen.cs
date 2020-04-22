using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_From_levelLostscreen : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
