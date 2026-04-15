using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0.5f, 4f, -6f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // offset player's view to camera starting view
        transform.position = player.transform.position + offset;
        
    }
}
