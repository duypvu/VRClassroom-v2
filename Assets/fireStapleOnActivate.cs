/*
* @file: fireStapleOnActivate.cs
* @brief: This file enables staples to be shot when the stapler is held and trigger is pressed.
* @author: Ethan Osorio
* @date: 3/7/2023
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class fireStapleOnActivate : MonoBehaviour
{
    public GameObject staple;
    public Transform spawnPoint;
    public float fireSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabble = GetComponent<XRGrabInteractable>();
        grabble.activated.AddListener(FireStaple);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireStaple(ActivateEventArgs arg)
    {
        GameObject spawnedStaple = Instantiate(staple);
        spawnedStaple.transform.position = spawnPoint.position;
        spawnedStaple.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        Destroy(spawnedStaple, 5);
    }
}
