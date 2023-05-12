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
        totalTime += Time.deltaTime;//1F�̎��Ԃ�������
        if(totalTime > 1.5f)
        {
            totalTime = 0.0f;
            var random = Random.Range(-9,9);//1-4�̃����_����
            var pos = new Vector3(random,1,15);//���ꏊ
            Instantiate(pickup, pos, Quaternion.identity);
        }
        
    }
}
