using System.Xml.Linq;

namespace Astar_algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeNodes();
        }
        class Node
        {
            public string Name;
            public List<Edge> Edges = new List<Edge>();
            public int x;
            public int y;
            public float G; // Chi phí từ điểm bắt đầu
            public float H; // Heuristic (ước lượng chi phí đến điểm đích)
            public Node Parent; // Đỉnh cha

            public float F => G + H; // Tổng chi phí
        }

        class Edge
        {
            public Node Destination;
            public float Cost;

            public Edge(Node destination, float cost)
            {
                Destination = destination;
                Cost = cost;
            }
        }
        private List<Node> nodes;
        private void InitializeNodes()
        {
            nodes = new List<Node>();

            Node node0 = new Node { Name = "A", x = 200, y = 50 };
            Node node1 = new Node { Name = "B", x = 50, y = 150 };
            Node node2 = new Node { Name = "C", x = 150, y = 150 };
            Node node3 = new Node { Name = "D", x = 250, y = 150 };
            Node node4 = new Node { Name = "E", x = 350, y = 150 };
            Node node5 = new Node { Name = "G", x = 200, y = 250 };
            Node node6 = new Node { Name = "H", x = 300, y = 250 };
            Node node7 = new Node { Name = "I", x = 250, y = 350 };

            node0.Edges.Add(new Edge(node1, 1));
            node0.Edges.Add(new Edge(node2, 1));
            node0.Edges.Add(new Edge(node3, 1));
            node0.Edges.Add(new Edge(node4, 1));
            node2.Edges.Add(new Edge(node5, 1));
            node3.Edges.Add(new Edge(node5, 1));
            node4.Edges.Add(new Edge(node6, 1));
            node5.Edges.Add(new Edge(node7, 1));
            node6.Edges.Add(new Edge(node5, 1));


            nodes.Add(node0);
            nodes.Add(node1);
            nodes.Add(node2);
            nodes.Add(node3);
            nodes.Add(node4);
            nodes.Add(node5);
            nodes.Add(node6);
            nodes.Add(node7);
        }
        private Node GetNodeFromInput(string input)
        {
            // Tìm đỉnh dựa trên tên nhập vào
            return nodes.FirstOrDefault(n => n.Name == input);
        }
        class AStar
        {
            public List<Node> FindPath(Node start, Node goal)
            {
                var openSet = new List<Node> { start };
                var closedSet = new HashSet<Node>();

                while (openSet.Count > 0)
                {
                    // Lấy nút có giá trị F nhỏ nhất
                    Node current = openSet[0];
                    foreach (var node in openSet)
                    {
                        if (node.F < current.F)
                        {
                            current = node;
                        }
                    }

                    // Nếu đã đến đích
                    if (current == goal)
                    {
                        return RetracePath(current);
                    }

                    openSet.Remove(current);
                    closedSet.Add(current);

                    // Duyệt qua các cạnh
                    foreach (var edge in current.Edges)
                    {
                        if (closedSet.Contains(edge.Destination)) continue;

                        float tentativeG = current.G + edge.Cost;

                        if (!openSet.Contains(edge.Destination))
                        {
                            openSet.Add(edge.Destination);
                        }
                        else if (tentativeG >= edge.Destination.G)
                        {
                            continue;
                        }

                        // Cập nhật các giá trị G, H, và Parent
                        edge.Destination.G = tentativeG;
                        edge.Destination.H = Heuristic(edge.Destination, goal);
                        edge.Destination.Parent = current;
                    }
                }

                return null; // Không tìm thấy đường
            }

            private List<Node> RetracePath(Node endNode)
            {
                var path = new List<Node>();
                Node current = endNode;

                while (current != null)
                {
                    path.Add(current);
                    current = current.Parent;
                }
                path.Reverse();
                return path;
            }

            private float Heuristic(Node a, Node b)
            {
                // Sử dụng khoảng cách Euclide làm heuristic (nếu có tọa độ)
                // return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
                return 0; // Cập nhật theo cách bạn muốn
            }
        }

        private void btnFindPath_Click(object sender, EventArgs e)
        {


            // Lấy điểm bắt đầu và kết thúc từ TextBox
            Node startNode = GetNodeFromInput(cbStart.Text);
            Node endNode = GetNodeFromInput(cbEnd.Text);

            // Gọi hàm tìm đường
            AStar aStar = new AStar();
            List<Node> path = aStar.FindPath(startNode, endNode);

            // Hiển thị kết quả
            if (path != null)
            {
                lblResult.Text = "Kết quả:\r\nĐường đi: " + string.Join(" -> ", path.Select(n => n.Name));
            }
            else
            {
                lblResult.Text = "Kết quả:\r\nKhông tìm thấy đường!";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Vẽ các đỉnh
            foreach (var node in nodes)
            {
                g.FillEllipse(Brushes.Blue, node.x, node.y, 30, 30);
                g.DrawString(node.Name, new Font("Arial", 10), Brushes.White, node.x,node.y);
            }

            // Vẽ các cạnh
            foreach (var node in nodes)
            {
                foreach (var edge in node.Edges)
                {
                    g.DrawLine(Pens.Black, node.x+15,node.y+15,edge.Destination.x+15,edge.Destination.y+15);
                }
            }
        }
    }
}
