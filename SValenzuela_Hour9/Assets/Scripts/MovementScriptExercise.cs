using UnityEngine;

public class MovementScriptExercise : MonoBehaviour
{

    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
           transform.Translate(Vector2.right * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
           transform.Translate(Vector2.left * Time.deltaTime);
        }
    }
}
