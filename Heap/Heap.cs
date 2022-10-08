using System;
namespace DataStructure
{


    //小根堆
    /// <summary>
    /// 支持自定义node  
    /// 要求node 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Heap<T> where T : IHeapItem<T>
    {
        private T[] items;
        private int curItemCount;

        public Heap(int maxHeapSize)
        {
            items = new T[maxHeapSize];//创建一个数组用来存储堆
        }

        public int Count
        {
            get
            {
                return curItemCount;
            }
        }
        public bool Contains(T item)
        {
            return Equals(items[item.HeapIndex], item);
        }
        public void UpdateItem(T item)
        {
            SortUp(item);
        }

        //堆插函数
        public void Add(T item)
        {
            item.HeapIndex = curItemCount;
            items[curItemCount] = item;
            SortUp(item);
            curItemCount++;
        }
        public T RemoveFirst()
        { //移除堆顶元素,并返回
            T firstItem = items[0];
            curItemCount--;
            items[0] = items[curItemCount];//堆顶元素和堆底元素交换
            items[0].HeapIndex = 0;//堆顶元素索引置为0,更新索引
            SortDown(items[0]);
            return firstItem;
        }



        void SortUp(T item)
        {//自底向上
            int parentIndex = (item.HeapIndex - 1) / 2;
            while (true)
            {
                T parentItem = items[parentIndex];
                if (item.CompareTo(parentItem) > 0)
                {
                    Swap(item, parentItem);
                }
                else
                {
                    break;
                }
                parentIndex = (item.HeapIndex - 1) / 2;//父节点索引
            }
        }
        void SortDown(T item)
        {//自顶向下调整
            while (true)
            {
                int childLeftIndex = item.HeapIndex * 2 + 1;
                int childRightIndex = item.HeapIndex * 2 + 2;
                //寻找最小值的节点索引
                int swapIndex = 0;
                if (childLeftIndex < curItemCount)
                {
                    swapIndex = childLeftIndex;//初始化
                    if (childRightIndex < curItemCount)
                    {
                        //Compare接口,比较节点Left和节点Right,负值说明R的代价小于L
                        if (items[childLeftIndex].CompareTo(items[childRightIndex]) < 0)
                        {
                            swapIndex = childRightIndex;
                        }
                    }
                    if (item.CompareTo(items[swapIndex]) < 0)
                    {
                        Swap(item, items[swapIndex]);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
        }
        void Swap(T itemA, T itemB)
        {
            //引用类型交换赋值
            items[itemA.HeapIndex] = itemB;
            items[itemB.HeapIndex] = itemA;

            //值类型的借助临时变量交换
            int itemAIndex = itemA.HeapIndex;
            itemA.HeapIndex = itemB.HeapIndex;
            itemB.HeapIndex = itemAIndex;
        }
    }

    public interface IHeapItem<T> : IComparable<T>
    {
        int HeapIndex { get; set; }
    }
}