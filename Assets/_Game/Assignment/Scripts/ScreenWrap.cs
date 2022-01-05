using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    Camera cam;
    [SerializeField] private Transform tran;
    private Vector3 pos;
    private float hight;
    private float width;
    private Vector3 poss;
    
    private void Start()
    {
        cam = Camera.main;
        tran = this.transform;
        pos = cam.WorldToViewportPoint(transform.position);

    }

    private void Update()
    {
        transform.position = Warp(transform.position);
    }

    private Vector3 Warp(Vector3 transformPosition)
    {
        
        if (transformPosition.x > 11)
        {
            transformPosition.x = -11f;
        }
        if (transformPosition.x < -11)
        {
            transformPosition.x = 11f;
        }
        if (transformPosition.y > 6)
        {
            transformPosition.y = -6f;
        }
        if (transformPosition.y < -6)
        {
            transformPosition.y = 6f;
        }

        return transformPosition;
    }
    
}

