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
    public enum MapType
    {
        roadmap,satellite,hybrid,terrain
    }
    public MapType mapSelected;
    public int scale;
    IEnumerator Map()
    {
        url = " " +
            "" +
            "";
        WWW www = new WWW(url);
        yield return www;
        img.texture = www.texture;
        img.SetNativeSize();
    }
	void Start () // Use this for initialization
    {
        img = gameObject.GetComponent<RawImage>();
        StartCoroutine(Map());
	}
	
	void Update () // Update is called once per frame
    {
		
	}
}
