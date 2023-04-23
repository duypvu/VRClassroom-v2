using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public VelocityEstimator head;
    public VelocityEstimator leftHand;
    public VelocityEstimator rightHand;

    public float sensitivity = 0.8f;
    public float minTimeScale = 0.05f;

    private float initialFixedDeltaTime;

    // Start is called before the first frame update
    void Start()
    {
        initialFixedDeltaTime = Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        float velocityMagnitude = head.GetVelocityEstimate().magnitude + leftHand.GetVelocityEstimate().magnitude + rightHand.GetVelocityEstimate().magnitude;

        Time.timeScale = Mathf.Clamp01(minTimeScale + velocityMagnitude * sensitivity);

        Time.fixedDeltaTime = initialFixedDeltaTime * Time.timeScale;
    }
}
