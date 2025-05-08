using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(GameObject))]
public class SpriteBoundary : MonoBehaviour
{
    [SerializeField] private GameObject centerTile;
    private Vector3 north = new Vector2(0f, 10f/9f);
    private Vector3 south = new Vector2(0f, -10f/9f);
    private Vector3 east = new Vector2(21f/9f, 0f);
    private Vector3 west = new Vector2(-21f / 9f, 0f);
    
    

    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "North")
        {
            MoveTilesNorth();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveTilesSouth();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveTilesEast();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveTilesWest();
        }
    }

    public void MoveTilesNorth()
    {
        centerTile.transform.position += north;
    }
    public void MoveTilesSouth()
    {
        centerTile.transform.position += south;
    }
    public void MoveTilesEast()
    {
        centerTile.transform.position += east;
    }
    public void MoveTilesWest()
    {
        centerTile.transform.position += west;
    }
}
