using UnityEngine;


public class FloodFill_Tile : MonoBehaviour
{

    [HideInInspector]public MeshRenderer meshRenderer;
    [HideInInspector] public bool filled;
    // [HideInInspector] public bool highlighted;
    
    private void Start()
    {
        Prepare();
        meshRenderer.material.color = Color.white;
        
    }

    public void Fill()
    {
        if (filled) return;
        meshRenderer.material.color = Color.black;
        filled = true;

    }
    
    // Tile Highlighting implementation left for later
    // public void HighLight()
    // {
    //     if (filled) return;
    //     if (highlighted)
    //     {
    //         meshRenderer.material.color = Color.yellow;
    //     }
    //
    //     if (!highlighted)
    //     {
    //         meshRenderer.material.color = Color.white;
    //     }
    // }

    void Prepare()
    {
        if (meshRenderer != null) return;
        try
        {
            meshRenderer = GetComponent<MeshRenderer>();
        }
        catch { Debug.LogWarning("Could not find meshRenderer"); }
    }
}
