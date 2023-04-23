using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFogDistanceSmoothly : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.fogEndDistance = 5;
    }

    public void SetFog()
    {
        StartCoroutine(SetFogRoutine());
    }

    public IEnumerator SetFogRoutine()
    {
        while(RenderSettings.fogEndDistance < 45)
        {
            RenderSettings.fogEndDistance = Mathf.Lerp(RenderSettings.fogEndDistance, 50, 0.01f);
            yield return null;
        }
    }
}
