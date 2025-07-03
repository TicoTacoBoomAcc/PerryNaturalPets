using UnityEngine;

public class HP : MonoBehaviour
{

    [SerializeField] GameObject health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        health.transform.localScale = new Vector3(2.5f , 5f, 5f);
    }

    public void SetHP(float hpNormalized)
    {
        health.transform.localScale = new Vector3(hpNormalized, 5f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
