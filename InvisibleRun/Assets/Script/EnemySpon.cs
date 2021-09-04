using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpon : MonoBehaviour
{
    public GameObject SearchLight;

    private float Interval;

    private float time = 0f;

    //時間をランダムにする
    public float minTime = 2f;
    public float maxTime = 5f;

    //出現位置をランダムに
    public float xMinPosition = 10f;
    public float xMaxPosition = 13f;

    public float yMinPositon = -1f;
    public float yMaxPosition = 2f;
    private void Start()
    {

        Interval = GetRandomTime();
    }

    private void Update()
    {
        time += Time.deltaTime;

        if(time > Interval)
        {
            GameObject Search = Instantiate(SearchLight);

            Search.transform.position = GetRandomPos();
            
            
            time = 0f;
            Interval = GetRandomTime();

         
        }
    }
    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }

    private Vector2 GetRandomPos()
    {
        float x = Random.Range(xMinPosition, xMaxPosition);
        float y = Random.Range(yMinPositon, yMaxPosition);
        return new Vector2(x, y);
  
    }
}
