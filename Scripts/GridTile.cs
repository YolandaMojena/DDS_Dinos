using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GridTile {

    private int _type;
    private Sprite _currentSprite;
    private int _size;
    private bool _freeTile = false;

	public GridTile(int type)
    {
        _type = type;
    }
}
