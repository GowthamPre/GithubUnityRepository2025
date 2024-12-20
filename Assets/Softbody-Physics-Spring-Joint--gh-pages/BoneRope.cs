using UnityEngine;

public class BoneRope : MonoBehaviour
{
    [Header("Bones")]
    public GameObject A = null;
    public GameObject B = null;
  
    [Header("Spring Joint Settings")]
    [Tooltip("Strength of spring")]
    public float Spring = 100f;
    [Tooltip("Higher the value the faster the spring oscillation stops")]
    public float Damper = 0.2f;

    private void Start()
    {
        AddSpring(A, B, Spring, Damper);
       
    }
    public void AddSpring(GameObject go1,GameObject go2, float spring, float damper)
    {
        SpringJoint sp = go1.AddComponent<SpringJoint>();
        sp.connectedBody = go2.GetComponent<Rigidbody>();
        sp.spring = spring;
        sp.damper = damper;
    }
}
