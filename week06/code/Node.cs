public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value == Data) {
            // Do nothing, since the value is already present                - Problem 1 Implementation
            return;
        }

        if (value < Data) {
            // Insert to the left
            if (Left is null) {
                Left = new Node(value);
            } else {
                Left.Insert(value);
            }
        } else {
            // Insert to the right
            if (Right is null) {
                Right = new Node(value);
            } else {
                Right.Insert(value);
            }
        }
    }

   public bool Contains(int value) {      //Problem 2 Implementation "Contains"
        if (value == Data) {
            return true;
        }

        if (value < Data) {
            // Search in the left subtree
            if (Left is not null) {
                return Left.Contains(value);
            }
        } else {
            // Search in the right subtree
            if (Right is not null) {
                return Right.Contains(value);
            }
        }

        return false;
    }

    public int GetHeight() {           //Problem 4 Implementation "GetHeight"
        // Calculate the height of the left subtree
        int leftHeight = Left?.GetHeight() ?? 0;
        // Calculate the height of the right subtree
        int rightHeight = Right?.GetHeight() ?? 0;

        // Return one plus the maximum height of either subtree
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}