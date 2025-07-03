using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public Image HPBar;
    public float maxHealth;
    public float currentHealth;
    [SerializeField] GameObject health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {

    }

    public void Damage(float damage)
    {
        currentHealth -= damage;
        SetHP(currentHealth / maxHealth);
    }

    public void SetHP(float hpNormalized)
    {
        HPBar.fillAmount = hpNormalized;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
