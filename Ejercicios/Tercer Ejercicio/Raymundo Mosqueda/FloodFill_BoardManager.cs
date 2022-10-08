using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FloodFill_BoardManager : MonoBehaviour
{
    public int width = 1;
    public int height = 1;
    [SerializeField] private float tileOffset = 1f;
    [SerializeField] private GameObject tile;
    private GameObject[,] _tiles;

    private bool _hasSeed;
    private Vector2Int _seed;
    [SerializeField]private float delay = .5f;
    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        Centering();
        MakeTiles();    
    }

    private void Update()
    {
        CheckInput();
    }

    private void Centering()
    {
        transform.position = Vector3.zero;
        
        Vector3 center = new Vector3(width *-.5f, height*.5f, 0);
        transform.position += (center);

    }

    private IEnumerator CorFlood(Vector2Int seed)
    {
        Queue<Vector2Int> fill = new Queue<Vector2Int>();
        fill.Enqueue(seed);
        while (fill.Count > 0)
        {
            seed = fill.Dequeue();
            if (seed.x <= 0 && seed.x >= height || seed.y <= 0 && seed.y >= width) yield break;
            
            _tiles[seed.x, seed.y].GetComponent<FloodFill_Tile>().Fill();
            
            if(!fill.Contains(new Vector2Int((seed.x + 1), seed.y)))fill.Enqueue(new Vector2Int((seed.x + 1), seed.y));
            if(!fill.Contains(new Vector2Int(seed.x, (seed.y + 1))))fill.Enqueue(new Vector2Int(seed.x, (seed.y + 1)));
            if(!fill.Contains(new Vector2Int((seed.x - 1), seed.y)))fill.Enqueue(new Vector2Int((seed.x - 1), seed.y));
            if(!fill.Contains(new Vector2Int(seed.x, (seed.y - 1))))fill.Enqueue(new Vector2Int(seed.x, (seed.y - 1)));
            yield return new WaitForSeconds(delay);
        }
    }
    
    private void CheckInput()
    {
        if (! Input.GetKeyDown (KeyCode.Space)) return;
        if (!_hasSeed) return;
        StartCoroutine(CorFlood(_seed));
    }

    public void GetId(GameObject obj)
    {
        string[] n = obj.name.Split(",", 2);
        _seed.x = int.Parse(n[0]);
        _seed.y = int.Parse(n[1]);
        _hasSeed = true;
        Debug.Log("Seed is: "+_seed.x + ", "+ _seed.y);
    }
    
    private void MakeTiles()
    {
        _tiles = new GameObject[width,height];
        for (int i = 0; i < height; i++)
        {
            GameObject cellX = Instantiate(tile);
            _tiles[0, i] = cellX;
            cellX.name = "0," + i;
            cellX.transform.position = transform.position + Vector3.down * i * tileOffset;
            
            for (int j = 1; j < width; j++)
            {
                
                GameObject cellY = Instantiate(tile);
                _tiles[j, i] = cellY;
                cellY.transform.position = transform.position  + Vector3.right  * j * tileOffset;
                cellY.transform.position += Vector3.down * i * tileOffset; 
                cellY.name = j +"," + i;
            }
        }
    }
}
