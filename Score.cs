using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public Text scoreText;


    void Awake ()
    {
        scoreText = GetComponent<scoreText>();
        score = 0;
    }
 
    void Update()
    {
        scoreText.text = "Score: " + score;
    }
}
