using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [Range(-1f, 10f)]
    public float scrollspeed = 0.5f;

    private float offset;
    private Material mat;


    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    void Update()
    {
        offset += (Time.deltaTime * scrollspeed) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector3(offset, 0, 0));
    }
}
