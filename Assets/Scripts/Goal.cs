using System;
using TMPro;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private int score;

    public TextMeshProUGUI textRef;

    private void Start()
    {
        textRef.text = "0";
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        score++;
        textRef.text = score.ToString();
    }
}
