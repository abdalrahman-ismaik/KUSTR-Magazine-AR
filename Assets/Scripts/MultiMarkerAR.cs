using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class MultiMarkerAR : MonoBehaviour
{
    [SerializeField] private ARTrackedImageManager trackedImageManager;
    
    // Assign models in Unity Inspector (match names with marker images)
    [SerializeField] private GameObject[] arModels;

    private Dictionary<string, GameObject> spawnedModels = new Dictionary<string, GameObject>();

    void Awake()
    {
        // Instantiate all models and hide them
        foreach (GameObject model in arModels)
        {
            GameObject newModel = Instantiate(model, Vector3.zero, Quaternion.identity);
            newModel.name = model.name;
            newModel.SetActive(false);
            spawnedModels.Add(model.name, newModel);
        }
    }

    void OnEnable() => trackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    void OnDisable() => trackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;

    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (ARTrackedImage trackedImage in eventArgs.added)
        {
            UpdateModel(trackedImage);
        }
        
        foreach (ARTrackedImage trackedImage in eventArgs.updated)
        {
            UpdateModel(trackedImage);
        }
        
        foreach (ARTrackedImage trackedImage in eventArgs.removed)
        {
            spawnedModels[trackedImage.referenceImage.name].SetActive(false);
        }
    }

    void UpdateModel(ARTrackedImage trackedImage)
    {
        string imageName = trackedImage.referenceImage.name;
        GameObject model = spawnedModels[imageName];

        if (trackedImage.trackingState == TrackingState.Tracking)
        {
            model.transform.position = trackedImage.transform.position;
            model.transform.rotation = trackedImage.transform.rotation;
            model.SetActive(true);
        }
        else
        {
            model.SetActive(false);
        }
    }
}