using UnityEngine;
using UnityEngine.UI;

namespace MapSelect
{
    public class MapSelector : MonoBehaviour
    {
        public GridLayoutGroup mapList;
        public Image previewImage;
        
        public static MapSelector Instance { get; private set; }
        public static bool IsSelected { get; private set; }
        public static MapData SelectedMapData { get; private set; }
        private static MapData _currentMapData;
        private Rigidbody2D _rigidbody2D;
        private Vector2 _latestStablePosition;
        
        private void Start()
        {
            Instance = this;
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _latestStablePosition = _rigidbody2D.position;
        }

        private void Update()
        {
            var direction = Vector2.zero;
            if (Input.GetKeyDown(KeyCode.A)) direction += new Vector2(-(mapList.cellSize.x + mapList.spacing.x), 0);
            if (Input.GetKeyDown(KeyCode.D)) direction += new Vector2(mapList.cellSize.x + mapList.spacing.x, 0);
            if (Input.GetKeyDown(KeyCode.S)) direction += new Vector2(0, -(mapList.cellSize.y + mapList.spacing.y));
            if (Input.GetKeyDown(KeyCode.W)) direction += new Vector2(0, mapList.cellSize.y + mapList.spacing.y);
            _rigidbody2D.position += direction;
            if (!_rigidbody2D.IsTouchingLayers(LayerMask.GetMask("MapListMask"))) _rigidbody2D.position = _latestStablePosition;
            if (Input.GetKeyDown(KeyCode.Return)) Select(); // Return == 엔터키
            // 추후 입력 방식 추가 (조이스틱 등)
        }

        /// <summary>
        /// 현재 위치의 맵 가져와서 선택하기
        /// </summary>
        public void Select()
        {
            IsSelected = true;
            SelectedMapData = _currentMapData;
            previewImage.sprite = SelectedMapData.mapPreview;
        }

        // 얻어오는게 귀찮은 관계로 콜라이더 사용
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.CompareTag("MapSelectCell")) return;
            _currentMapData = other.transform.GetComponent<MapData>();
            if (!IsSelected) previewImage.sprite = _currentMapData.mapPreview; // 아직 선택하지 않았을 때 프리뷰 계속 바꿔주기
            _latestStablePosition = _rigidbody2D.position;
        }
    }
}
