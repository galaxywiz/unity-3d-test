using System;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    public float roateSpeed = 200f;
    float mx = 0, my = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        mx += mouseX * roateSpeed * Time.deltaTime;
        my += mouseY * roateSpeed * Time.deltaTime;

        my = Mathf.Clamp(my, -90f, 90f);
        transform.eulerAngles = new Vector3(-my, mx, 0);       
    }
}
