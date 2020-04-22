using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Behavior : MonoBehaviour
{
    public float endPoint = 8f;
    public Rigidbody rb;
    //We are letting the object know we will use audio
    private AudioSource playerAudio;
    public AudioClip crashSound;
    public bool playedAudio = false;
    private void Start()
    {
        //Then we need to connect this with the player audio
        playerAudio = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        //If they move past endPoint the Game_Manager is informed its EndGame.
        if (rb.position.x < endPoint)
        {
            FindObjectOfType<Game_Manager>().LoseLevel();
            Debug.Log("game lost");
            if (playedAudio == false)
            {
                playerAudio.PlayOneShot(crashSound, 1.0f);
                playedAudio = true;
            }
        }
    }
}
