using UnityEngine;
using System.Collections;

namespace UnityEngine.UI
{
    public interface ILoopScrollDataSource
    {
        void ProvideData(Transform transform, int idx);
    }

	public class LoopScrollSendIndexSource : ILoopScrollDataSource
    {
		public static readonly LoopScrollSendIndexSource Instance = new LoopScrollSendIndexSource();

		LoopScrollSendIndexSource(){}

        public void ProvideData(Transform transform, int idx)
        {
            transform.SendMessage("ScrollCellIndex", idx);
        }
    }

	public class LoopScrollArraySource<T> : ILoopScrollDataSource
    {
        T[] objectsToFill;

		public LoopScrollArraySource(T[] objectsToFill)
        {
            this.objectsToFill = objectsToFill;
        }

        public void ProvideData(Transform transform, int idx)
        {
            transform.SendMessage("ScrollCellContent", objectsToFill[idx]);
        }
    }
}