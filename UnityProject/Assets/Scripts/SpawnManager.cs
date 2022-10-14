using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject prefabScore, screen;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomly(Random.Range(3, 5));
    }
    void SpawnRandomly(int count)
    {
        for (int i = 0; i < count; i++)
        {
            float Xrange = 1 - screen.transform.localScale.x;
            Vector3 spawnPos = new Vector2(Random.Range(-Xrange, Xrange), Random.Range(-0.4f, 0.4f));
            GameObject score = Instantiate(prefabScore);
            score.transform.position = spawnPos;
        }
    }
}
