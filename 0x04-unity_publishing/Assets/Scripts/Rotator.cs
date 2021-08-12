using UnityEngine;

/// <summary>Handles coin rotator class</summary>
public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    /// <summary>Updates in 45° each frame the X axis</summary>
    void Update()
    {
        transform.Rotate(45 * Time.deltaTime, 0, 0);
    }
}
