using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;




public class ContentsManager : MonoBehaviour
{
    // Start is called before the first frame update
    public ARPlaneManager arPlaneManager;
    public ARRaycastManager arRaycastManager;
    public GameObject placePrefab;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    /*void Awake()
    {
        aRPlaneManager = GetComponent<ARPlaneManager>();
        aRRaycastManager = GetComponent<aRRaycastManager>();
    }*/

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Vector2 touchPos = Input.GetTouch(0).position;
                if (arRaycastManager.Raycast(touchPos, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    Pose hitPose = hits[0].pose;
                    Instantiate(placePrefab, hitPose.position, hitPose.rotation);
                }
            }
        }
    }

}
