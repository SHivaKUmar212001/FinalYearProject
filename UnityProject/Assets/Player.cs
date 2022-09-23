using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 playerCoordinates;
    public static Player Instance;
    RectTransform rectTransform;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        rectTransform.anchoredPosition = playerCoordinates * new Vector2(1,-1);
    }
}
