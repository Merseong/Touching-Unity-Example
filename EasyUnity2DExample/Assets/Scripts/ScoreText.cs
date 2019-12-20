using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UI에 접근하기 위해 필요합니다.
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        // Score Text를 갱신합니다.
        if (!GameManager.inst.isGameOver) text.text = "Score: " + GameManager.inst.score;

        // 하이스코어에 가까워질수록 글자의 색이 초록색이 됩니다.
        if (GameManager.inst.highScore != 0) text.color = Color.Lerp(Color.white, Color.green, GameManager.inst.score / (float)GameManager.inst.highScore);
        else text.color = Color.green;
    }
}
