using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public float score;
    public float pointIncreasePerSecond;
    


    // Start is called before the first frame update
    void Start()
    {
        //Initialization 
        score = 0f;
        pointIncreasePerSecond = 3f;
    }

    // Update is called once per frame
    void Update()
    {   
        //Runs formula so score increases by 3 every second and shows in game
        scoreText.text = "Score: " + (int)score;
        score += pointIncreasePerSecond * Time.deltaTime;
        
    }
}
