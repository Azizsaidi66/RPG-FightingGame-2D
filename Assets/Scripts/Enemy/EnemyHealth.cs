using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    public int currentHealth;
    public AudioSource enemyVanish;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        currentHealth = health;
        enemyVanish = GetComponent<AudioSource>();
    }

    public void ChangeHealth(int damage){
        currentHealth -= damage;

        if(currentHealth <= 0){
            enemyVanish.Play();
            Destroy(gameObject);
        }
    }
}
