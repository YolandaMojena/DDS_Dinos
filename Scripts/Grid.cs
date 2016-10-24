using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Grid : MonoBehaviour {

    [SerializeField]
    private int gridID;
    [SerializeField]
    private GameObject gridPanel;

    private int _gridResX;
    private int _gridResY;
    private GridTile[,] _gridMatrix;

    private const int _GRID_SIZE = 400;

	// Use this for initialization
	void Start () {

        LoadGrid(1);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void LoadGrid(int gridID)
    {
        int[,] targetGrid = GridDescriptor.GetGridFromID(gridID);

        _gridResX = targetGrid.GetLength(0);
        _gridResY = targetGrid.GetLength(1);
        _gridMatrix = new GridTile[_gridResX, _gridResY];

        RectTransform parent = gridPanel.GetComponent<RectTransform>();
        GridLayoutGroup group = gridPanel.GetComponent<GridLayoutGroup>();
        int sizeX = _GRID_SIZE / _gridResX;
        int sizeY = _GRID_SIZE / _gridResY;
        group.cellSize = new Vector2(sizeX, sizeY);

        for (int i = 0; i < _gridResX; i++)
        {
            for(int j = 0; j < _gridResY; j++)
            {
                _gridMatrix[i, j] = new GridTile(targetGrid[i, j], 100, targetGrid[i, j] == 2 ? false : true);

                //float posX = basePos.y + size * -(-(_gridResX - 1) / 2 + i);
                //float posY = basePos.x + size * (-(_gridResY - 1) / 2 + j);
                LoadTile(targetGrid[i, j], parent);
            }
        }
    }

    private void LoadTile(int type, RectTransform parent)
    {
        Sprite spriteToLoad = Resources.Load<Sprite>("Tiles/" + type);
        GameObject tile = Instantiate(Resources.Load("Prefabs/Tile") as GameObject);

        tile.GetComponent<Image>().sprite = spriteToLoad;
        tile.transform.parent = parent;
    }
}
