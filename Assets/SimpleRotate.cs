using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotate : MonoBehaviour
{
    public Vector3 angleSpeed;
    public Transform[] targets;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(targets.Length > 0 && targets != null)
        {
            foreach (var item in targets)
            {
                item.localEulerAngles += Time.deltaTime * angleSpeed;
            }
        }
        else
            transform.localEulerAngles += Time.deltaTime * angleSpeed;
    }
}
