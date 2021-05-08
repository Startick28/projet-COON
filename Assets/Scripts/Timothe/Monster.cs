using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Monster : MonoBehaviour
{
    private Rigidbody rigi;
    private new Renderer renderer;

[SerializeField]
private float speed;
// Use this for initialization
void Awake()
{
    rigi = GetComponent<Rigidbody>();
    renderer = GetComponent<Renderer>();
}

private void OnEnable()
{
    renderer.material.color = Random.ColorHSV();
}

private void FixedUpdate()
{
    rigi.velocity = transform.up * speed;
}

private void OnTriggerEnter(Collider other)
{
    MonsterFactory.EndMonster(this);
}
}