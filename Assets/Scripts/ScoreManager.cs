using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public int score = 0;

    public void AddScore()
    {
        score++;
        scoreText.text =$"Score: {+ score}!";
    }

    public TextMeshProUGUI scoreText;
}
