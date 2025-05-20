using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(GameObject))]
public class SpriteBoundary : MonoBehaviour
{
    [SerializeField] private GameObject centerTile;
    private Vector3 north = new Vector2(0f, 10f /*/ 9f*/);
    private Vector3 south = new Vector2(0f, -10f /*/ 9f*/);
    private Vector3 east = new Vector2(21f /*/ 9f*/, 0f);
    private Vector3 west = new Vector2(-21f /*/ 9f*/, 0f);



    void Update()
    {

    }


    void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (gameObject.CompareTag("North"))
            {
                MoveTilesNorth();
            }
            if (gameObject.CompareTag("South"))
            {
                MoveTilesSouth();
            }
            if (gameObject.CompareTag("East"))
            {
                MoveTilesEast();
            }
            if (gameObject.CompareTag("West"))
            {
                MoveTilesWest();
            }
            else return;
        }
        else return;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && gameObject.CompareTag("Center"))
        {
            transform.position = other.transform.position;
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
