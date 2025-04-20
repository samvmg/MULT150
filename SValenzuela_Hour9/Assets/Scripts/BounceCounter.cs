using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    int bounceCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
                bounceCounter++;
                Debug.Log("Total bounces: " + bounceCounter);
        }
    }
}

