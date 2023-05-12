using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject pickup;
    private float totalTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalTime += Time.deltaTime;//1Fの時間を加える
        if(totalTime > 1.5f)
        {
            totalTime = 0.0f;
            var random = Random.Range(-9,9);//1-4のランダム数
            var pos = new Vector3(random,1,15);//作る場所
            Instantiate(pickup, pos, Quaternion.identity);
        }
        
    }
}
