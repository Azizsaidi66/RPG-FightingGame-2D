using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public StatsUi statsui;
    public CanvasGroup gameOver;
    public Slider healthSlider;

    void Start(){
        healthSlider.maxValue = StatsManager.Instance.maxHealth;
        healthSlider.value = StatsManager.Instance.currentHealth;
    }

    public void ChangeHealth(int damage){
        StatsManager.Instance.currentHealth -= damage;
        healthSlider.value = StatsManager.Instance.currentHealth;
        statsui.UpdateCurrentHealth();

        if(StatsManager.Instance.currentHealth <= 0){
            gameObject.SetActive(false);
            gameOver.alpha = 1;
            Time.timeScale = 0;
        }
    }
}
