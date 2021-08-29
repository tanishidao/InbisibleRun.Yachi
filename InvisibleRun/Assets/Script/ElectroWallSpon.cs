using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWallSpon : MonoBehaviour
{
    public GameObject SearchLight;

    private float Wallterval;

    private float WallTime = 0f;

    //���Ԃ������_���ɂ���
    public float minTime = 10f;
    public float maxTime = 30f;




    private void Start()
    {

        WallTime = GetRandomWallTime();
    }

    private void Update()
    {
        WallTime += Time.deltaTime;

        if (WallTime > Wallterval)
        {
            GameObject Search = Instantiate(SearchLight);

            Search.transform.position = new Vector2(10f, 0f);
            Debug.Log(Search.transform.position + "���W�ŏo��");
            Debug.Log(WallTime + "�b�ŏo��");


            WallTime = 0f;
            Wallterval = GetRandomWallTime();


        }
    }
    private float GetRandomWallTime()
    {
        return Random.Range(minTime, maxTime);
    }
}
