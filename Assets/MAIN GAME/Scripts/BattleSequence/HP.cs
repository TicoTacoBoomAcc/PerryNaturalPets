using UnityEngine;

public class HP : MonoBehaviour
{

    [SerializeField] GameObject health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        health.transform.localScale = new Vector3(0.5f , 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
