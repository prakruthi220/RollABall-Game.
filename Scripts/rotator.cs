using UnityEngine;

public class rotator : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
     transform.Rotate(new Vector3(45,45,45) * Time.deltaTime);
    }
}
