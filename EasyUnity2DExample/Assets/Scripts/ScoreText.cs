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
    }
}
