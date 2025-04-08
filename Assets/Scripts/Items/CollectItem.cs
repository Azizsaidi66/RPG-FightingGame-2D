using UnityEngine;
using UnityEngine.UI;


public class CollectItem : MonoBehaviour{

    private StatsUi stats;
    private Slider healthSlider;

    void Start(){

        stats = FindObjectOfType<StatsUi>();
        healthSlider = FindObjectOfType<Slider>();

    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Player")){
            addEffect();
            Destroy(gameObject);
        }
    }

    void addEffect(){
        switch (gameObject.tag){

        case "maxHealth":
            StatsManager.Instance.maxHealth += 10;
            stats.UpdateMaxHealth();
            break;

        case "health":
            StatsManager.Instance.currentHealth += 10;
            if (StatsManager.Instance.currentHealth > StatsManager.Instance.maxHealth){
                StatsManager.Instance.currentHealth = StatsManager.Instance.maxHealth;
            }
            healthSlider.value = StatsManager.Instance.currentHealth;
            stats.UpdateCurrentHealth();
            break;

        case "speed":
            StatsManager.Instance.speed += 1f;
            stats.UpdateSpeed();
            break;

        case "damage":
            StatsManager.Instance.damage += 5;
            stats.UpdateDamage();
            break;

        case "range":
            StatsManager.Instance.weaponRange += 1.5f;
            stats.UpdateRange();
            break;
        }
    }
}
