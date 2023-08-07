using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBox_rotation : MonoBehaviour
{
    public float SkySpeed;

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * SkySpeed);
    }
}
