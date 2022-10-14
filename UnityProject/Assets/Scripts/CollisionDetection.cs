using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class CollisionDetection : MonoBehaviour
{
    public static CollisionDetection Instance;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject restartText;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        UpdateScore();
    }

    private void Update()
    {

        if (FindObjectsOfType<Score>().Length == 0 && restartText)
            restartText.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score score = collision.gameObject.GetComponent<Score>();

        if (score)
        {
            if (Player.Instance)
                Player.Instance.count += score.scorePoints;
            UpdateScore();
        }
        if (collision.CompareTag("Restart"))
            RestartGame();
        Destroy(collision.gameObject);
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void UpdateScore()
    {
        if (Player.Instance)
            scoreText.text = $"Score: {Player.Instance.count}";
    }
}
