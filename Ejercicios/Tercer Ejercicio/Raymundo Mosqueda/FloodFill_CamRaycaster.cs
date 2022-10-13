using System;
using UnityEngine;

public class FloodFill_CamRaycaster : MonoBehaviour
{
    private bool _selected;
    private FloodFill_BoardManager _boardManager;

    [HideInInspector]public GameObject selectedTile;
    // Start is called before the first frame update
    void Start()
    {
        Prepare();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        
    }

    void CheckInput()
    {
        CheckClick();
    }

    void CheckClick()
    {
        if (!Input.GetMouseButtonDown(0)) return;
        SelectTile();
    }

    void SelectTile()
    {
        if (_selected) return;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (!Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity)) return;
        try
        {
            selectedTile = hit.collider.gameObject;
            hit.collider.gameObject.GetComponent<FloodFill_Tile>().Fill();
            _boardManager.GetId(selectedTile);
            _selected = true;
        }
        catch { Debug.LogWarning("not a tile"); }
    }
    
    // Tile Highlighting implementation left for later
    // void HighLightTile()
    // {
    //     var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //     if (!Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity)) return;
    //     try
    //     {
    //         hit.collider.gameObject.GetComponent<FloodFill_Tile>().highlighted = true;
    //     }catch { Debug.LogWarning("not a tile"); }
    //     
    // }

    void Prepare()
    {
        try
        {
            transform.position =  Camera.main.transform.position;
            transform.rotation = Camera.main.transform.rotation;
        }
        catch{ Debug.Log("Could not find Camera.main"); }

        if (_boardManager != null) return;
        try
        {
            _boardManager = GameObject.Find("BoardManager").GetComponent<FloodFill_BoardManager>();
        }
        catch { Debug.Log("Could Not Find BoardManager");}
    }
}
