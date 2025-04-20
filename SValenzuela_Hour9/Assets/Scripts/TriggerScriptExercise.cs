using UnityEngine;

public class TriggerScriptExercise : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
        {
            Debug.Log(other.name + " has entered the cube");
        }
        
    void OnTriggerStay (Collider other)
        {
            Debug.Log(other.name + " is still in the cube");
        }

    void OnTriggerExit (Collider other)
        {
            Debug.Log(other.name + " has left the cube");
        }
}
