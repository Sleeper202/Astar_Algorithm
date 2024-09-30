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
        private List<Node> path;
        private void InitializeNodes()
        {
            nodes = new List<Node>();

            Node node0 = new Node { Name = "0", x = 435, y = 95 };
            Node node1 = new Node { Name = "1", x = 625, y = 57 };
            Node node2 = new Node { Name = "2", x = 470, y = 177 };
            Node node3 = new Node { Name = "3", x = 642, y = 119 };
            Node node4 = new Node { Name = "4", x = 509, y = 263 };
            Node nodex = new Node { Name = "x", x = 41, y = 320 };
            Node nodey = new Node { Name = "y", x = 245, y = 215 };

            node0.Edges.Add(new Edge(node1, Heuristic(node0, node1)));
            node0.Edges.Add(new Edge(node2, Heuristic(node0, node2)));
            node1.Edges.Add(new Edge(node3, Heuristic(node1, node3)));            
            node2.Edges.Add(new Edge(node0, Heuristic(node2, node0)));
            node2.Edges.Add(new Edge(node3, Heuristic(node2, node3)));
            node2.Edges.Add(new Edge(node4, Heuristic(node2, node4)));
            node3.Edges.Add(new Edge(node1, Heuristic(node3, node1)));
            node3.Edges.Add(new Edge(node2, Heuristic(node3, node2)));
            node4.Edges.Add(new Edge(node2, Heuristic(node4, node2)));
            

            node0.Edges.Add(new Edge(nodex, Heuristic(node0, nodex)));
            nodex.Edges.Add(new Edge(nodey, Heuristic(nodey, nodex)));

            nodey.Edges.Add(new Edge(node0, Heuristic(node0, nodey)));


            nodes.Add(node0);
            nodes.Add(node1);
            nodes.Add(node2);
            nodes.Add(node3);
            nodes.Add(node4);
            nodes.Add(nodex);
            nodes.Add(nodey);
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
                //path.Reverse();
                return path;
            }


        }
        private float Heuristic(Node a, Node b)
        {
            // Sử dụng khoảng cách Euclide làm heuristic (nếu có tọa độ)
            return (float)Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2)) / 100;
        }
        private void btnFindPath_Click(object sender, EventArgs e)
        {
            ResetNodes();
            // Lấy điểm bắt đầu và kết thúc từ TextBox
            Node startNode = GetNodeFromInput(cbStart.Text);
            Node endNode = GetNodeFromInput(cbEnd.Text);
            //Tính H
            foreach (var node in nodes)
            {
                node.H = Heuristic(node, endNode);
            }
            //Vẽ lại
            panel1.Invalidate();

            // Gọi hàm tìm đường
            AStar aStar = new AStar();
            path = aStar.FindPath(startNode, endNode);

            // Hiển thị kết quả
            if (path != null)
            {
                var p = path;
                p.Reverse();
                lblResult.Text = "Kết quả:\r\nĐường đi: " + string.Join(" -> ", p.Select(n => n.Name));
                panel1.Invalidate();
            }
            else
            {
                lblResult.Text = "Kết quả:\r\nKhông tìm thấy đường!";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (panel1.BackgroundImage != null) { g.DrawImage(panel1.BackgroundImage, 0, 0, panel1.Width, panel1.Height); }

            // Vẽ các đỉnh
            foreach (var node in nodes)
            {
                g.FillEllipse(Brushes.Blue, node.x-15, node.y-15, 30, 30);
                g.DrawString(node.Name, new Font("Arial", 10), Brushes.Black, node.x + 10, node.y + 10);
            }

            // Vẽ các cạnh
            foreach (var node in nodes)
            {
                foreach (var edge in node.Edges)
                {
                    g.DrawLine(Pens.Black, node.x, node.y, edge.Destination.x, edge.Destination.y);
                }
            }
            // Vẽ đường nếu có
            if (path != null)
            {
                using(Pen p = new Pen(Brushes.Red, 15))
                {
                    foreach (var node in path)
                    {
                        g.FillEllipse(Brushes.Yellow, node.x - 15, node.y - 15, 30, 30);
                        
                        if (node.Parent != null)
                        {
                            if (node.Name == "0" && node.Parent.Name == "1")
                            {
                                Point[] points =
                                {
                                    new Point(node.x, node.y),
                                    new Point(474,74),
                                    new Point(node.Parent.x, node.Parent.y),
                                };
                                g.DrawCurve(p, points);
                            }
                            else if (node.Name == "x" && node.Parent.Name == "0")
                            {
                                Point[] points =
                                {
                                    new Point(node.x, node.y),                                    
                                    new Point(110,295),
                                    new Point(245,211),
                                    new Point(360,130),                                    
                                    new Point(node.Parent.x, node.Parent.y),
                                };
                                g.DrawCurve(p, points);
                            }
                            else if (node.Name == "0" && node.Parent.Name == "x")
                            {
                                Point[] points =
                                {
                                    new Point(node.x, node.y),
                                    new Point(360,130),
                                    new Point(245,211),
                                    new Point(110,295),
                                    new Point(node.Parent.x, node.Parent.y),
                                };
                                g.DrawCurve(p, points);
                            }
                            else g.DrawLine(p, node.x, node.y, node.Parent.x, node.Parent.y);
                        }
                            
                        

                        g.DrawString(node.Name, new Font("Arial", 10), Brushes.Black, node.x + 10, node.y + 10);
                    }
                }
                
            }
        }
        private void ResetNodes()
        {
            foreach (var node in nodes)
            {
                node.G = 0;
                node.H = 0;
                node.Parent = null;
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            MessageBox.Show($"x = {x}, y = {y}");
        }
    }
}
