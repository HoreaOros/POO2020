using System;
using System.Data;
using System.Text;

namespace Lab13
{
    public class BinarySearchTree
    {
        private TreeNode root;
        public BinarySearchTree()
        {
            root = null;
        }

        public void Add(params int[] keys)
        {
            foreach (var item in keys)
            {
                Add(item);
            }
        }

        private void Add(int key)
        {
            if (root == null)
            {
                TreeNode node = new TreeNode(key, 1);
                root = node;
                return;
            }

            bool inserted = false;
            TreeNode temp = root;
            while (!inserted)
            {
                if (key < temp.Key)
                {
                    if (temp.Left == null)
                    {
                        TreeNode node = new TreeNode(key, 1);
                        temp.Left = node;
                        inserted = true;
                    }
                    else
                        temp = temp.Left;
                }
                else if (key == temp.Key)
                {
                    temp.Data++;
                    inserted = true;
                }
                else
                {
                    if (temp.Right == null)
                    {
                        TreeNode node = new TreeNode(key, 1);
                        temp.Right = node;
                        inserted = true;
                    }
                    else
                        temp = temp.Right;
                }
            }

        }

        public TreeNode Find(int key)
        {
            TreeNode temp = root;
            while (temp != null)
            {
                if (temp.Key == key)
                {
                    return temp;
                }
                else if (key < temp.Key)
                    temp = temp.Left;
                else
                    temp = temp.Right;
            }

            return null;
        }
        public override string ToString()
        {
            return Inorder2(root);
        }

        // creeaza un string cu cheile arborelui in ordine crescatoare
        // TODO: trebuie implementat
        private string Inorder2(TreeNode node)
        {
            if (node == null)
            {
                return "";
            }
            else
                return Inorder2(node.Left) 
                    + string.Format("{0} - {1}\n", node.Key, node.Data) 
                    + Inorder2(node.Right);
        }

        public void Inorder()
        {
            Inorder(root);
        }
        private void Inorder(TreeNode node)
        {
            if (node != null)
            {
                Inorder(node.Left);

                Console.WriteLine($"{node.Key} - {node.Data}");

                Inorder(node.Right);
            }
        }

        // TODO: operatia de eliminare a unui nod din arbore
        // nu e simplu si trebuie sa cautati referinte
        public void Remove(TreeNode t)
        {
            throw new NotImplementedException();
        }
    }
}