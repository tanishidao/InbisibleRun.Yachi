using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectroWallSpon : MonoBehaviour
{
    public GameObject ElectroWall;

    private float Wallterval;

    private float WallTime = 0f;

    private int LevelUp = 0;

    private bool cancel = false;
    //ŽžŠÔ‚ðƒ‰ƒ“ƒ_ƒ€‚É‚·‚é
    public float minTime;
    public float maxTime;




    private void Start()
    {

        Wallterval = GetRandomWallTime();
    }

    private void Update()
    {
        WallTime += Time.deltaTime;

        if (WallTime > Wallterval)
        {
            GameObject Search = Instantiate(ElectroWall);

            Search.transform.position = new Vector2(10f, 2f);



            WallTime = 0f;
            Wallterval = GetRandomWallTime();


        }
        if (LevelUp <=1 && Score.Instance.Scores > 15000)
        {
            LevelUp++;
            maxTime = 12f;
            minTime = 11f;
        }
        if ( Score.Instance.Scores > 20000)
        {
            Debug.Log("levelUp2");
            maxTime = 16f;
            minTime = 15f;
            LevelUp++;

        }
        if( Score.Instance.Scores > 25000)
        {
            cancel = true;
            maxTime = 21f;
            minTime = 20f;
        }
        
    }
    private float GetRandomWallTime()
    {
        return Random.Range(minTime, maxTime);
    }

}
