using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBG : MonoBehaviour
{
    Material material;
    Vector2 movment;

    public Vector2 speed; 
    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        movment += speed*Time.deltaTime;
        material.mainTextureOffset = movment;
    }
}
