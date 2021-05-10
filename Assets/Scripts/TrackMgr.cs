using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMgr : MonoBehaviour
{
    public static TrackMgr current;
    private void Awake()
    {
        current = this;
        startPos = generateTrans.localPosition;
    }

    public GameObject[] trackPrefabs;

    public GameObject trackRoot;

    public Transform generateTrans;


    readonly Vector3 offset = new Vector3(-2, 0, 0);
    Vector3 startPos;

    int platCount = 0;
    public void OnPlatformDestory()
    {
        platCount++;
        int index = Random.Range(0, 3);
        var curprefab = trackPrefabs[index];
        var gb = Instantiate<GameObject>(curprefab,trackRoot.transform);
        gb.transform.localPosition = startPos + offset * platCount;

    }
}
