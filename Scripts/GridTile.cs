using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GridTile {

    private int _type;
    private GameObject _currentSprite = null;
    private int _size;
    private bool _freeTile = false;

    public int Type
    {
        get { return _type; } set { _type = value; }
    }
    public GameObject CurrentSprite
    {
        get { return _currentSprite; } set { _currentSprite = value; }
    }
    public int Size
    {
        get { return _size; } set { _size = value; }
    }
    public bool FreeTile
    {
        get { return _freeTile; } set { _freeTile = value; }
    }

    public GridTile(int type, int size, bool freeTile)
    {
        _type = type;
        _size = size;
        _freeTile = freeTile;
    }
}
