using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager inst;

    private void Awake()
    {
        if (inst != null) Destroy(inst);
        inst = this;
        DontDestroyOnLoad(this);
    }

    // 게임이 끝났는지에 대한 값입니다.
    public bool isGameOver = false;
    // 플레이어가 잡은 적의 수입니다.
    public int score = 0;
    // 게임오버 Text 오브젝트입니다.
    public GameObject gameOverText;
    // 하이스코어 표시입니다.
    public GameObject highScoreText;
    // 최고득점의 기록입니다.
    public int highScore = 0;
    // 커서의 Texture
    public Texture2D cursorTex;
    // 공용 파티클
    public GameObject redParticle;

    private void Start()
    {
        // 로컬에 하이스코어가 저장되어있는지 확인하고, 없으면 0으로 초기화합니다.
        if (!PlayerPrefs.HasKey("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", 0);
        }
        highScore = PlayerPrefs.GetInt("HighScore");

        // 커서를 바꿉니다
        Cursor.SetCursor(cursorTex, new Vector2(15, 15), CursorMode.Auto);
    }

    // 게임오버시 할 동작들입니다.
    public void GameOver(PlayerController p)
    {
        isGameOver = true;
        // 게임오버시 하이스코어면 기록합니다.
        if (score > highScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.SetActive(true);
        }
        // 게임오버 텍스트를 켭니다.
        gameOverText.SetActive(true);

        // 시각적으로 보이지 않게하고, 컨트롤 스크립트를 끕니다.
        p.GetComponent<SpriteRenderer>().enabled = false;
        p.GetComponent<PlayerController>().enabled = false;
        p.GetComponent<BoxCollider2D>().enabled = false;

        // Log에 게임이 종료되었다고 표시합니다.
        Debug.LogError("Game Over! score is " + score);
    }

    public void Restart()
    {
        // 0번 씬(처음 시작씬)을 다시 불러와 리셋합니다.
        // 유니티에서 File-Build Settings에서 Scenes In Build에 있는것을 모두 지우고 Add Open Scene을 눌러줘야 합니다.
        SceneManager.LoadScene(0);
    }
}
