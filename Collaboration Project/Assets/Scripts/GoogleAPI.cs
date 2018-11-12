using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoogleAPI : MonoBehaviour
{
    public RawImage img;
    private string url;
    public float lat;
    public float lon;
    LocationInfo li;
    public int zoom = 14;
    public int mapWidth = 640;
    public int mapHeight = 640;
    public enum mapType
    {
        roadmap,satellite,hybrid,terrain
    }
    public mapType mapSelected;
    public int scale;
    IEnumerator Map()
    {
        url = " " +
    }
	void Start () // Use this for initialization
    {
		
	}
	
	void Update () // Update is called once per frame
    {
		
	}
}
