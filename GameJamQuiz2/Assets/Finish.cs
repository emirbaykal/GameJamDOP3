using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

    public CollectObject co;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
    if (other.gameObject.tag == "Player")
        {
            if (co.astronaut > co.ingot)
            {
                SceneManager.LoadScene(2);
            }
            else
            {
                Debug.Log("kaynak ending");
                SceneManager.LoadScene(1);
            }
        } 
    }
}
