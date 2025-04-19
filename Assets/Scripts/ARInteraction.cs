// ARInteraction.cs
public class ARInteraction : MonoBehaviour
{
    [SerializeField] private Animator objectAnimator;
    private bool isAnimating = false;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform == transform)
                {
                    ToggleAnimation();
                }
            }
        }
    }

    void ToggleAnimation()
    {
        isAnimating = !isAnimating;
        objectAnimator.SetBool("IsAnimating", isAnimating);
    }
}