/*
* @file: ActivateTeleportationRay.cs
* @brief: This file enables the teleportation ray and disables it when necessary.
* @author: Ethan Osorio
* @date: 3/7/2023
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
    public GameObject rightTeleportation;

    public InputActionProperty rightActivate;

    public InputActionProperty rightCancel;
    // Update is called once per frame
    void Update()
    {
        rightTeleportation.SetActive(rightCancel.action.ReadValue<float>() == 0 && rightActivate.action.ReadValue<float>() > 0.1f);
    }
}
