using UnityEngine;

/// <summary>Handles main camera class</summary>
public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 cameraPos = new Vector3 (0, 20, 0); 

    // Update is called once per frame
    /// <summary>Updates camera position based on player ball position</summary>
    void Update()
    {
        transform.position = player.transform.position + cameraPos;
    }
}
