using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed = 5f;
    public Transform player;
    private int facingDirection = -1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.position.x > transform.position.x && facingDirection == -1 || player.position.x < transform.position.x && facingDirection == 1){
            Flip();
        }
        Vector2 direction = (player.position - transform.position).normalized;
        rb.linearVelocity = direction * speed;
    }
    void Flip(){
        facingDirection *= -1;
        transform.localScale = new Vector3(transform.localScale.x *-1, transform.localScale.y, transform.localScale.z);
    }

    public void SetPlayer(Transform playerTransform)
    {
        player = playerTransform;
    }
}
