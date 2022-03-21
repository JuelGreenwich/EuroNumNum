using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowObject : MonoBehaviour
{
    public Material glow, noGlow;
    public bool isGLowing = true;

    public void ToggleGlow()
    {
        if (isGLowing)
        {
            gameObject.GetComponent<MeshRenderer>().material = noGlow;
            isGLowing = false;
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material = glow;
            isGLowing = true;
        }
    }
}
