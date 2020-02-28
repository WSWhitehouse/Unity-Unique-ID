// ------------------------------------------- //
// Author  : William Whitehouse / WSWhitehouse //
// GitHub  : github.com/WSWhitehouse           //
// Created : 09/02/2020                        //
// Edited  : 10/02/2020                        // 
// ------------------------------------------- //

using UnityEngine;

namespace WSWhitehouse.UniqueID
{
    [DisallowMultipleComponent]
    public class UniqueID : MonoBehaviour
    {
        private void Awake()
        {
            if (string.IsNullOrEmpty(id))
            {
                Debug.LogError(gameObject.name + " :: Unique ID is Null or Empty");
            }
        }

        [SerializeField] private string id;

        public string ID => id;
    }
}