using UnityEngine;

public class HazardController : MonoBehaviour
{
    public float speed = 2f;
    Vector3 startPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (transform.position.x > 9f)
        {
            transform.position = startPosition;
        }
    }
}
