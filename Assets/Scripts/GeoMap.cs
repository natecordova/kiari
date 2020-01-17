using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeoMap : MonoBehaviour
{
    private string urlMap = "";
    public RawImage imageMap;
    public Text latitudText;
    public Text longitudText;

    public int zoom = 20;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("GetMap");
    }

    public void ZoomInButton()
    {
        zoom++;
        StartCoroutine("GetMap");
    }


    public void ZoomOutButton()
    {
        if(zoom>=0)zoom--;
        StartCoroutine("GetMap");
    }

    private IEnumerator GetMap()
    {
        Input.location.Start();
        float latitud = Input.location.lastData.latitude;
        yield return latitud;
        float longitud = Input.location.lastData.longitude;
        yield return longitud;

        urlMap = "https://maps.googleapis.com/maps/api/staticmap?center=" + latitud + ","+longitud+ "&zoom="+zoom+ "&size=600x300&maptype=roadmap&markers=color:blue%7Clabel:S%7C40.702147,-74.015794&markers=color:green%7Clabel:G%7C40.711614,-74.012318&markers=color:red%7Clabel:C%7C" + latitud+","+longitud+"&key=AIzaSyD65lnodvxGj2IdvHE7Hkuwht_Cv2h4Mac";

        WWW www = new WWW(urlMap);
        yield return www;

        imageMap.texture = www.texture;
        latitudText.text = "" + latitud;
        longitudText.text = "" + longitud;

    }



 
}
