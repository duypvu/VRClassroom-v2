using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{

    public Vector3 moveDirection;
    public bool isLocal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isLocal)
            transform.position += Time.deltaTime * transform.TransformDirection(moveDirection);
        else
            transform.position += Time.deltaTime * moveDirection;
    }
}
