using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health = 1004f;
        float poisonDamage = 125.5f;


        while (health >= 0)
        { 
            Debug.Log(health);
            health -= poisonDamage;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//*         Debug.Log(health); health -= poisonDamage; Debug.Log(health); *//

