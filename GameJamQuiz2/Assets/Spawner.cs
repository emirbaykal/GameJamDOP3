using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float Timer = 2;
    public GameObject ufo;
    public GameObject[] meteors;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            for (int i = 0; i < 12; i++)
            {
            GameObject a;
            a = Instantiate(meteors[Random.Range(0,meteors.Length)], new Vector3(transform.position.x-Random.Range(-30,+30),transform.position.y-Random.Range(-30,+30),transform.position.z), transform.rotation);
            }
            Timer = 2f;
        }
    }
}
