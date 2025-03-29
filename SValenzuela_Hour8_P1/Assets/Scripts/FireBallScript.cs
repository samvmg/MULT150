using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = TakeDamageFromFireball();
        print ("Player health: " + x);

        int y = TakeDamageFromFireball(25);
        print ("Player health: " + y);

        int z = TakeDamageFromFireball(30, 50);
        print ("Player health: " + z);
    }

    int TakeDamageFromFireball()
    { int playerHealth = 100;
        return playerHealth - 5;
    
    }

    int TakeDamageFromFireball(int damage)
    {
        int playerHealth = 100;
        return playerHealth - damage;

    }

    int TakeDamageFromFireball(int damage, int playerHealth)
    { 
        return playerHealth - damage;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
