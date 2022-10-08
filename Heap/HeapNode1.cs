namespace DataStructure
{

    public class HeapNode1 : IHeapItem<HeapNode1>
    {
        public bool walkable;

        public int movementPenalty;



        public int gCost = 0;
        public int hCost = 0;
        public int fCost { get { return hCost + gCost; } }

        public int HeapIndex
        {
            get
            {
                return heapIndex;
            }
            set
            {
                heapIndex = value;
            }
        }

        public int inGridX;
        public int inGridY;

        public HeapNode1 parent;
        int heapIndex;

        public HeapNode1(bool walkable,  int inGridX, int inGridY, int panelty)
        {
            this.walkable = walkable;
         
            this.inGridX = inGridX;
            this.inGridY = inGridY;
            this.movementPenalty = panelty;
        }
        
        public  int CompareTo(HeapNode1 compareTarget)
        {
            int compare = fCost.CompareTo(compareTarget.fCost);
            if (compare == 0)
            {
                compare = gCost.CompareTo(compareTarget.gCost);
            }
            return -compare;
        }
    }

}