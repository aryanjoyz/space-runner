using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Update is called once per frame
    private Vector2 targetPos;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;

    public Text healthDisplay;

    public int health = 1; 

    public GameObject gameOver;

    private void Update()
    {
        healthDisplay.text = health.ToString();

        if (health <= 0) {

            gameOver.SetActive(true);
            Destroy(gameObject); //destroy player character
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed* Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight){
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        }else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight){
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }
    }
}
