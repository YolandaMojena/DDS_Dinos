using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum TypeOfTile
{
    empty,
    field,
    rock
}

public class GridDescriptor : MonoBehaviour {

    private List<int[,]> _gridTiles;

    public static GridDescriptor mInstance;

    void Awake()
    {
        mInstance = this;
    }

    void Start(){

        _gridTiles = new List<int[,]>();

        int[,] grid0 = new int[2, 2] { { 2, 2 }, { 1, 0 } };
        _gridTiles.Add(grid0);

        int[,] grid1 = new int[3, 3] { { 2, 2, 2 }, { 1, 0, 1 }, { 0, 0, 0 } };
        _gridTiles.Add(grid1);
    }

    public static int[,] GetGridFromID(int i)
    {
        return mInstance._gridTiles[i];
    }
}
