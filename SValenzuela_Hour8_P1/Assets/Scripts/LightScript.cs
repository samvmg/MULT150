using UnityEngine;

public class LightScript : MonoBehaviour
{

    Light lightComponent;

    // Start is called before the first frame update
    void Start()
    {
        lightComponent = GetComponent<Light>();
    }


    // Update is called once per frame
    void Update()
    {  
       if(Input.GetKeyDown(KeyCode.L))

       {
        lightComponent.enabled = !lightComponent.enabled;
       }

    }
}

