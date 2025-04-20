// MarkerDetection.cs
using System.Collections.Generic;  // Add this line
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class MarkerDetection : MonoBehaviour
{
    [SerializeField] private ARTrackedImageManager trackedImageManager;
    [SerializeField] private GameObject[] arObjectsToPlace;
    
    private Dictionary<string, GameObject> arObjects = new Dictionary<string, GameObject>();

    void Awake()
    {
        // Setup all objects
        foreach (GameObject arObject in arObjectsToPlace)
        {
            GameObject newARObject = Instantiate(arObject, Vector3.zero, Quaternion.identity);
            newARObject.name = arObject.name;
            newARObject.SetActive(false);
            arObjects.Add(arObject.name, newARObject);
        }
    }

    void OnEnable() => trackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;

    void OnDisable() => trackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;

    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (ARTrackedImage trackedImage in eventArgs.added)
        {
            UpdateARObject(trackedImage);
        }
        
        foreach (ARTrackedImage trackedImage in eventArgs.updated)
        {
            UpdateARObject(trackedImage);
        }
        
        foreach (ARTrackedImage trackedImage in eventArgs.removed)
        {
            arObjects[trackedImage.name].SetActive(false);
        }
    }

    void UpdateARObject(ARTrackedImage trackedImage)
    {
        // Display object based on tracking state
        if (trackedImage.trackingState == TrackingState.Tracking)
        {
            GameObject arObject = arObjects[trackedImage.name];
            arObject.transform.position = trackedImage.transform.position;
            arObject.transform.rotation = trackedImage.transform.rotation;
            arObject.SetActive(true);
        }
        else
        {
            arObjects[trackedImage.name].SetActive(false);
        }
    }
}