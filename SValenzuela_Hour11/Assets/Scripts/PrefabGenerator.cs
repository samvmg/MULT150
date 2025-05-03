using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{

    public GameObject prefab;

    public int count = 10;

    public float spacing = 2f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < count; i++)
        {
            Vector3 position = new Vector3(i * spacing, 0, 0);
            Instantiate(prefab, position, Quaternion.identity);
        }
    

    }

    // Update is called once per frame
    void Update()
    {
        // Whenever we hit the B key we will generate a prefab at the position of the original prefab. Whenever we hit the space key, we will generate a 
        // prefab at the position of the spawn object that this script is attached to

        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))

        {
                Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}


