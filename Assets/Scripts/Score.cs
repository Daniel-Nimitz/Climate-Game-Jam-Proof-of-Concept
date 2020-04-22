using UnityEngine;
using UnityEngine.UI; 
//dont forget UnityEngine.UI


public class Score : MonoBehaviour
{
    public GameObject Endtrigger;
    public static int scoreValue = 0;
    Text score;
  
    void Start()
    
    {
        score = GetComponent<Text>();
    }
    void Update()
    {
        score.text = " " + scoreValue;

        if (scoreValue >= 3f)
        {
            Endtrigger.SetActive(false);
            FindObjectOfType<Game_Manager>().EndGame();
            Debug.Log("Win");
        }
               
    }

}
