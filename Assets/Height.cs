using UnityEngine;

public class AutoScaler : MonoBehaviour
{
    [SerializeField]
    private float defaultHeight = 3f;
    [SerializeField]
    private Camera camera;

    private void Resize()
    {
        float headHeight = camera.transform.localPosition.y;
        float scale = defaultHeight / headHeight;
        transform.localScale = Vector3.one * scale;
    }

    void OnEnable()
    {
        Resize();
    }
}