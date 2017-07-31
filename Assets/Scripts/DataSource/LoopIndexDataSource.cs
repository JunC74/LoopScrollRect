using UnityEngine;
using System.Collections;

namespace UnityEngine.UI
{
    public class LoopIndexDataSource : DataSourceBehaviour
    {
        [SerializeField]
        private int ItemNum;
        
        public override void ProvideData(Transform transform, int idx)
        {
            transform.SendMessage("ScrollCellIndex", idx);
        }

        public override int GetItemNum()
        {
            return ItemNum;
        }
    }
}
