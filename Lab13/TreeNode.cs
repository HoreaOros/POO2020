using System.Threading;

namespace Lab13
{
    public class TreeNode
    {
        private int key;
        private int data;
        private TreeNode left, right;
        // TODO: parent = referinta la nodul parinte, adaugat cod in metoda Add pentru intretinerea lui parent
        private TreeNode parent;

        public TreeNode(int key, int data)
        {
            this.key = key;
            this.data = data;
            this.left = this.right = this.parent = null;
        }

        public int Data
        {
            get 
            {
                return data;
            }
            set
            {
                // TODO: modificarea in mod arbitrar a datelor satelit nu e o idee prea buna.
                data = value;
            }
        }

        public int Key
        {
            get { return key; }
        }
        public TreeNode Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;
            }
        }
        public TreeNode Right
        {
            get
            {
                return right;
            }
            set
            {
                right = value;
            }
        }
    }
}