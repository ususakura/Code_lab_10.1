using UnityEngine;

public class ChaserController : MonoBehaviour
{
    public Transform player;
    public float speed = 3f;
    public float chaseDistance = 4f;
    public float escapeDistance = 6f;
    bool isChasing = false;

    public void PlayerReachedGoal()
    {
       if (isChasing)
       {
           isChasing = false;
           RandomPosition();
       }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        if (distanceToPlayer < chaseDistance)
        {
            isChasing = true;
        }
        
        if (isChasing && distanceToPlayer > escapeDistance)
        {
            isChasing = false;
            RandomPosition();
    }
        
        if (isChasing)
        {
           transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }

    void RandomPosition()
{
    float randomX = Random.Range(-7f, 7f);
    float randomY = Random.Range(-3.5f, 3.5f);

    transform.position = new Vector3(randomX, randomY, transform.position.z);
}

}
