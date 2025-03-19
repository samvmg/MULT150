using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
        for (int count = 1; count <= 31; count ++)
        if (count==21)
        Debug.Log("it's my bday ^_^!");
        else if (count==31)
        Debug.Log("happy halloween! :)");
        else
        Debug.Log(count);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
