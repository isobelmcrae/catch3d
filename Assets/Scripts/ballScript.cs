using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ballScript : MonoBehaviour
{
    private Rigidbody ball;
    public TextMeshProUGUI scoreText;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();

        score = 0;

        SetScoreText();
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            ball.gameObject.SetActive(false);
            ball.gameObject.transform.position = new Vector3(Random.Range(0.0f, 8f), 15, Random.Range(0.0f, -7.7f));
            ball.gameObject.SetActive(true);

            score = score + 1;

            

        } else {
            ball.gameObject.SetActive(false);
            ball.gameObject.transform.position = new Vector3(Random.Range(0.0f, 8f), 15, Random.Range(0.0f, -7.7f));
            ball.gameObject.SetActive(true);
            score = score - 1;

            if (score < 0) {
                score = 0;
            }
        }

        SetScoreText();
    }

    void SetScoreText() {
        scoreText.text = "Score: " + score.ToString();
    }

} 
