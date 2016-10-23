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

    void Start(){

        _gridTiles = new List<int[,]>();

        int[,] grid0 = new int[2, 2] { { 0, 2 }, { 1, 0 } };
        _gridTiles.Add(grid0);
    }

    public int[,] GridFromID(int i)
    {
        return _gridTiles[i];
    }
}
