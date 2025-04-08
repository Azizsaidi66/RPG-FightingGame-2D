using UnityEngine;

public class StatsManager : MonoBehaviour
{
  public static StatsManager Instance;
  public int maxHealth;
  public int currentHealth;
  public float speed;
  public int damage;
  public float weaponRange;
  public float knockbackForce;

  private void Awake(){
    if(Instance == null){
      Instance = this;
    }
    else{
      Destroy(gameObject);
    }
  }
}
