using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;



public class Track : MonoBehaviour
{
    public VideoPlayer video;
    Slider tracking;

    // Start is called before the first frame update
    void Start()
    {
        tracking = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        tracking.value = video.frame / (float)video.frameCount;
    }
}
