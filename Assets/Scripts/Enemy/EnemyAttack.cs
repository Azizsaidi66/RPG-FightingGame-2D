using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damage = 1;
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player"){
            collision.gameObject.GetComponent<PlayerHealth>().ChangeHealth(damage);
        }
    }
}
