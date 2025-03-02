using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public float roateSpeed = 200f;
    float mx = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        
        mx += mouseX * roateSpeed * Time.deltaTime;
        
        transform.eulerAngles = new Vector3(0, mx, 0);     
    }
}
