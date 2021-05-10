using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryTrack : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<MoveController>() != null)
        {
            Destroy(other.gameObject);
            TrackMgr.current.OnPlatformDestory();
        }
    }
}
