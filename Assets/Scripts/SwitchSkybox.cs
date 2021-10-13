using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSkybox : MonoBehaviour
{
    public Material SkyBox1;
    public Material SkyBox2;


    public void Start()
    {
        RenderSettings.skybox = SkyBox1;
    }

    public void OnSkyBoxClick()
    {

        if (RenderSettings.skybox == SkyBox1)
        {
            RenderSettings.skybox = SkyBox2;
        }
        else
        {
            RenderSettings.skybox = SkyBox1;
        }
    }
    
}
