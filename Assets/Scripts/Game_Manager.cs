using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject loseLevelUI;

    public GameObject winLevelUI;
    private AudioSource gameManagerAudio;
    public AudioClip gameOverSound;

    private void Start()
    {
        gameManagerAudio = GetComponent<AudioSource>();
    }

    public void LoseLevel ()
    {
        Score.scoreValue = 0;
        loseLevelUI.SetActive(true);
        Debug.Log("Game Lost Wall Hit");
       gameManagerAudio.PlayOneShot(gameOverSound);
            
    }

    

   public void EndGame()
    {
        if(gameHasEnded == false)
        {
            Score.scoreValue = 0;
            gameHasEnded = true;
            Debug.Log("Game Won");
            winLevelUI.SetActive(true);

        }
        
    }

}

