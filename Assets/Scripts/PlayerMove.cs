using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playerSpeed = 10f;  // プレイヤーの移動速度
    
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * playerSpeed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * playerSpeed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * playerSpeed * Time.deltaTime;
        }

        if(Input.GetKey (KeyCode.D))
        {
            transform.position += Vector3.right * playerSpeed * Time.deltaTime;
        }
    }
}
