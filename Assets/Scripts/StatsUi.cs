using UnityEngine;
using TMPro;

public class StatsUi : MonoBehaviour
{
    public TMP_Text maxHealthText;
    public TMP_Text currentHealthText;
    public TMP_Text speedText;
    public TMP_Text damageText;
    public TMP_Text rangeText;
    public TMP_Text knockbackForceText;
    public CanvasGroup menu;
    private bool isOpen = false;

    private void Start(){
        UpdateMaxHealth();
        UpdateCurrentHealth();
        UpdateSpeed();
        UpdateDamage();
        UpdateRange();
        UpdateKnockbackForce();
    }

    private void Update(){
        if(isOpen == true){
            if(Input.GetButtonDown("Pause")){
                Time.timeScale = 1;
                menu.alpha = 0;
                isOpen = false;
            }
        }
        else{
            if(Input.GetButtonDown("Pause")){
                Time.timeScale = 0;
                menu.alpha = 1;
                isOpen = true;
            }
        }
    }
    public void UpdateMaxHealth()
    {
        maxHealthText.text = "Max Health : " + StatsManager.Instance.maxHealth;
    }
    public void UpdateCurrentHealth()
    {
        currentHealthText.text = "Current Health : " + StatsManager.Instance.currentHealth;
    }
    public void UpdateSpeed()
    {
        speedText.text = "Speed : " + StatsManager.Instance.speed;
    }
    public void UpdateDamage()
    {
        damageText.text = "Damage : " + StatsManager.Instance.damage;
    }
    public void UpdateRange()
    {
        rangeText.text = "Range : " + StatsManager.Instance.weaponRange;
    }
    public void UpdateKnockbackForce()
    {
        knockbackForceText.text = "Knockback Force : " + StatsManager.Instance.knockbackForce;
    }
}
