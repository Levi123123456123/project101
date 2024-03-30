using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waves : MonoBehaviour
{
    public List<Transform> spawnpoints;
    public List<GameObject> enemy;
    public float wave1 = 0;
    public float point = 1;
    public float pointsave = 1;
    public float win = 0;
    public float time = 20;
    public GameObject boss1;
    public GameObject boss2;
    public float chance = 1;    
    public float infinite = 0;
    void Start()
    {
        Invoke("wave", 3);
        Invoke("alone", 5);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.T))
        {
            infinite = 1;
        }
    }
    void wave()
    {
        if (wave1<=10||infinite == 1)
        {
            wave1 += 1;
            point = Mathf.Round(0.2f*(point*point)+2f);
            chance = Random.Range(0,100);
            pointsave = point;
            if (point >= 10 && chance <=50)
            {
                Instantiate(boss1, spawnpoints[Random.Range(0, spawnpoints.Count)].position, spawnpoints[Random.Range(0, spawnpoints.Count)].rotation);
                point -=10;
            }
            if (point >= 20 && chance >=50)
            {
                Instantiate(boss2, spawnpoints[Random.Range(0, spawnpoints.Count)].position, spawnpoints[Random.Range(0, spawnpoints.Count)].rotation);
                point -=20;
            }
            if (point >=20)
            {
                Instantiate(boss2, spawnpoints[Random.Range(0, spawnpoints.Count)].position, spawnpoints[Random.Range(0, spawnpoints.Count)].rotation);
                point -=20;
            }
            while (point >= 0)
            {
                Instantiate(enemy[Random.Range(0, enemy.Count)], spawnpoints[Random.Range(0, spawnpoints.Count)].position, spawnpoints[Random.Range(0, spawnpoints.Count)].rotation);
                point-=1;
            }
            point = pointsave;
            Invoke("wave", time);
        }
        else
        {
            
            win = 1;
        }
    void alone()
    {
        Instantiate(enemy[Random.Range(0, enemy.Count)], spawnpoints[Random.Range(0, spawnpoints.Count)].position, spawnpoints[Random.Range(0, spawnpoints.Count)].rotation);
        Invoke("alone", 3);
    }
    }
}
