using UnityEngine;

public class TestAttack : MonoBehaviour
{
    public HP thingToHit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thingToHit.Damage(50);
        }
    }
}
