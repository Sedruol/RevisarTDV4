using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform parentEnemys;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public float spawnEnemy1;
    public float spawnEnemy2;
    public float spawnEnemy3;
    float timerEnemy1;
    float timerEnemy2;
    float timerEnemy3;
    private void Awake()
    {
        //InvokeRepeating
    }
    void SpawnEnemys(GameObject e1, GameObject e2, GameObject e3, float se1, float se2, float se3)
    {
        if(timerEnemy1>= spawnEnemy1)
        {
            timerEnemy1 = 0f;
            SpawnEnemy(e1, se1);
        }
        else if (timerEnemy2 >= spawnEnemy2)
        {
            timerEnemy2 = 0f;
            SpawnEnemy(e2, se2);
        }
        else if(timerEnemy3 >= spawnEnemy3)
        {
            timerEnemy3 = 0f;
            SpawnEnemy(e3, se3);
        }
    }
    void SpawnEnemy(GameObject e, float se)
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
        SpawnEnemys(enemy1, enemy2, enemy3, spawnEnemy1, spawnEnemy2, spawnEnemy3);
    }
}