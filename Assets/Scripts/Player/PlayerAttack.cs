using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform attackpoint;
    public LayerMask enemyLayer;
    public Animator anim;

    public void attack(){
        anim.SetBool("isAttacking", true);
    }
    
    public void dealDamage(){
        Collider2D[] enemies = Physics2D.OverlapCircleAll(attackpoint.position, StatsManager.Instance.weaponRange, enemyLayer);

        if(enemies.Length > 0){
            enemies[0].GetComponent<EnemyHealth>().ChangeHealth(StatsManager.Instance.damage);
            enemies[0].GetComponent<EnemyKnockback>().Knockback(transform, StatsManager.Instance.knockbackForce);
        }
    }

    public void finishattack(){
        anim.SetBool("isAttacking", false);
    }
}
