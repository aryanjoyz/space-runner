using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
     public int score;
     public Text scoreDisplay;
     public GameObject cloudBG;
     public GameObject cloudBG2;
     public GameObject cloudBG3;

     private void Update(){
         scoreDisplay.text = score.ToString();
     }

    void OnTriggerEnter2D(Collider2D other)
    {
       if (other.CompareTag("Obstacle")){
           //increase score of 1!!
           score++;
           Debug.Log(score);

            //bg change color
            if (scoreDisplay.text.Equals("10")) 
            {
                cloudBG.SetActive(false);
                cloudBG2.SetActive(true);
                cloudBG3.SetActive(false);
            }

            if (scoreDisplay.text.Equals("30")) 
            {
                cloudBG.SetActive(false);
                cloudBG2.SetActive(false);
                cloudBG3.SetActive(true);
            }
       }
    }
}
