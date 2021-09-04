using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectroWallSpon : MonoBehaviour
{
    public GameObject ElectroWall;

    private float Wallterval;

    private float WallTime = 0f;

    //ŽžŠÔ‚ðƒ‰ƒ“ƒ_ƒ€‚É‚·‚é
    public float minTime = 10f;
    public float maxTime = 30f;




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
    }
    private float GetRandomWallTime()
    {
        return Random.Range(minTime, maxTime);
    }
}
