using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform parentEnemys;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public float spawnEnemy1 = 2f;
    public float spawnEnemy2 = 4f;
    public float spawnEnemy3 = 6f;
    float timerEnemy1;
    float timerEnemy2;
    float timerEnemy3;
    void SpawnEnemys(GameObject e, float se, ref float te)
    {
        if (te >= se)
        {
            te = 0f;
            SpawnEnemy(e);
        }
    }
    void SpawnEnemy(GameObject e)
    {
        float tempX = Random.Range(ScalerAndMovBG.minX, ScalerAndMovBG.maxX);
        float tempY = ScalerAndMovBG.maxY + 1.5f;
        Instantiate(e, new Vector3(tempX, tempY, 0f), Quaternion.Euler(0f, 0f, 180f), parentEnemys);
    }
    private void Update()
    {
        timerEnemy1 += Time.deltaTime;
        timerEnemy2 += Time.deltaTime;
        timerEnemy3 += Time.deltaTime;
        SpawnEnemys(enemy1, spawnEnemy1, ref timerEnemy1);
        SpawnEnemys(enemy2, spawnEnemy2, ref timerEnemy2);
        SpawnEnemys(enemy3, spawnEnemy3, ref timerEnemy3);
    }
}