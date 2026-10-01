using UnityEngine;

public class PingPongHazard : MonoBehaviour
{
    public float speed = 2f;
    float direction = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * direction * Time.deltaTime);

        if (transform.position.x > 9f)
        {
            direction = -1f;
        }
        else if (transform.position.x < -9f)
        {
            direction = 1f;
        }
        
    }
}
