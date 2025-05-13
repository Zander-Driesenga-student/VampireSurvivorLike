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
        print("working");
        if (collision.CompareTag("Player"))
        {
            print("working");
            if (gameObject.CompareTag("North"))
            {
                MoveTilesNorth();
                print("working");
            }
            if (gameObject.CompareTag("South"))
            {
                MoveTilesSouth();
                print("working");
            }
            if (gameObject.CompareTag("East"))
            {
                MoveTilesEast();
                print("working");
            }
            if (gameObject.CompareTag("West"))
            {
                MoveTilesWest();
                print("working");
            }
            else return;
        }
        else return;
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
