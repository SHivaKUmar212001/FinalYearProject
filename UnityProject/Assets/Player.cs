using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public Vector2 playerCoordinates;
    public static Player Instance;
    [SerializeField] TextMeshProUGUI scoreText;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width - playerCoordinates.x, Screen.height - playerCoordinates.y, Camera.main.nearClipPlane));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        count += collision.gameObject.GetComponent<Score>().scorePoints;
        UpdateScore();
        Destroy(collision.gameObject);
    }

    void UpdateScore()
    {
        scoreText.text = $"Score: {count}";
    }
}
