using UnityEngine;

public class End_Trigger : MonoBehaviour
{
    public Game_Manager gameManager;
    //Adding in Audio
    private AudioSource endTriggerAudio;
    public AudioClip gameOverSound;

    private void Start()
    {
        endTriggerAudio = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter()
    {
     gameManager.LoseLevel();
        endTriggerAudio.PlayOneShot(gameOverSound);
        
     
    }



}
