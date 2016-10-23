using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

    private int _gridID;
    private int _gridSize;
    private GridTile[,] _gridMatrix;

    [SerializeField]
    private GameObject gridPanel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void LoadGrid(int gridID)
    {

    }
}
