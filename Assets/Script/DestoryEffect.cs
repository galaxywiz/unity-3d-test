using UnityEngine;

public class DestoryEffect : MonoBehaviour
{
    public float destoryTime = 1.5f;
    float curretTime = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (curretTime > destoryTime) {
            Destroy(gameObject);
        }
        curretTime += Time.deltaTime;
    }
}
