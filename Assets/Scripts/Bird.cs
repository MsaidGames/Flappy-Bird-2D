using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bird : MonoBehaviour
{
    public float force;
    Rigidbody2D rb;

    public int score;
    public Text scoreText;

    public GameObject restartButton;

    void Start()
    {
        Time.timeScale = 1;
        score = 0;
        rb = GetComponent<Rigidbody2D>();

        restartButton.SetActive(false);
    }

    void Update()
    {
        scoreText.text = score.ToString();
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * force;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pipe")
        {
            Destroy(gameObject);
            Time.timeScale = 0;

            restartButton.SetActive(true);
        }

        if(collision.tag == "Score")
        {
            score++;
        }
    }

    
}
