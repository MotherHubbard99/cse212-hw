public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        //make sure the value hasn't already been added to the tree
        if (value == Data)
            return;

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        //make sure the value hasn't already been added to the tree
        if (value == Data)
            return true;
        else if (value < Data)
        {
            if (Left == null)
                return false;
            else if (Left.Contains(value))
                return true;
            else
                return false;
        }
        else    //check right side
            if (Right == null)
            return false;
        else if (Right.Contains(value))
            return true;
        else
            return false;
    }

    public int GetHeight()
    {
        //initialize left height
        int LeftHeight = 0;
        //check to see if their is a left subtree
        if (Left != null)
        {
            LeftHeight = Left.GetHeight();
        }
        //initialize the right height
        int RightHeight = 0;
        if (Right != null)
        {
            RightHeight = Right.GetHeight();
        }
        //The height of the root is 1, then add the taller of the right or left subtree
        int TotalHeight = 1 + Math.Max(LeftHeight, RightHeight);

        return TotalHeight;
    }
}