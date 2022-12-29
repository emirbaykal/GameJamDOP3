using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.DORotate(new Vector3(0,360,0),1).SetLoops(-1,LoopType.Yoyo);
    }
}
