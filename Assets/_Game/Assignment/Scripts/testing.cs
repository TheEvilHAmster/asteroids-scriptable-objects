using System.Collections;
using System.Collections.Generic;
using Assignment.ScriptableObjects;
using UnityEngine;

public class testing : MonoBehaviour
{
    private Camera _camera;

    [SerializeField] private Vector3Ref playerPos;

    private Vector3 camPos;
    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main;
        Vector3 pos = _camera.WorldToViewportPoint(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
