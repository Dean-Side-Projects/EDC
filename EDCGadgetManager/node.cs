namespace EDCGadgetManager
{
    public class Node
    {
        public Gadget Data { get; set; }
        public Node Next { get; set; }

        public Node(Gadget data)
        {
            Data = data;
            Next = null;
        }
    }
}