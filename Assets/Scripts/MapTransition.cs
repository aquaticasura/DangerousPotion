using Unity.Cinemachine;
using Unity.Loading;
using UnityEngine;
using UnityEngine.UI;

public class MapTransition : MonoBehaviour
{
    [SerializeField] PolygonCollider2D mapBoundry;
    CinemachineConfiner2D confiner;
    [SerializeField] Direction direction;
    [SerializeField] Transform teleportTargetPosition;


    enum Direction { Up, Down, Left, Right, Teleport}

    private void Awake()
    {

        confiner = FindFirstObjectByType<CinemachineConfiner2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            confiner.BoundingShape2D = mapBoundry;
            updateplayerposition(collision.gameObject);

        }
    }

    private void updateplayerposition(GameObject player)
    {
        if (direction == Direction.Teleport)
        {
            player.transform.position = teleportTargetPosition.position;

            return;
        }

        Vector3 newPos = player.transform.position;

        switch (direction)
        {
            case Direction.Up:
                newPos.y += 2;
                break;
            case Direction.Down:
                newPos.y -= 2;
                break;
            case Direction.Right:
                newPos.x -= 2;
                break;
            case Direction.Left:
                newPos.x += 2;
                break;
        }

        player.transform.position = newPos;
    }

}
