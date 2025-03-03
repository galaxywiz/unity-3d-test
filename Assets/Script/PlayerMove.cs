using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 7f;
    CharacterController cc;
    
    float gravify = -20f;
    float yVelocity = 0f;

    public float jumpPower = 10f;
    public bool isJump = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cc = GetComponent<CharacterController>();        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        Vector3 dir = new Vector3(h, 0, v);
        dir = dir.normalized;
        dir = Camera.main.transform.TransformDirection(dir);
        if (isJump && cc.collisionFlags == CollisionFlags.Below) {
            isJump = false;
            yVelocity = 0;
        }
        if (Input.GetButtonDown("Jump") && !isJump) {
            yVelocity = jumpPower;
            isJump = true;
        }

        yVelocity += gravify * Time.deltaTime;
        dir.y = yVelocity;

        //transform.position += dir * moveSpeed * Time.deltaTime;        
        cc.Move(dir * moveSpeed * Time.deltaTime);
    }
}
