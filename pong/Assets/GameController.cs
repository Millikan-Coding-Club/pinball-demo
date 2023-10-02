using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Animator leftPaddleAnimator;
    public Animator rightPaddleAnimator;
    public TextMeshProUGUI scoreText;

    private int score = 0;
    public void Update()
    {
        // Every Frame
        if ( Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
            leftPaddleAnimator.ResetTrigger("Pressed");
            leftPaddleAnimator.SetTrigger("Pressed");

        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) {
            rightPaddleAnimator.ResetTrigger("Pressed");
            rightPaddleAnimator.SetTrigger("Pressed");
        }
    }
    public void AddScore() {
        score += 10;
        scoreText.text = "Score:" + score;
    }
}
