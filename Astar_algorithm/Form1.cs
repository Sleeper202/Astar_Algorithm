using Microsoft.VisualBasic.Devices;
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
        private bool isSelectingStart = false;
        private bool isSelectingEnd = false;
        private Node startNode = null;
        private Node endNode = null;
        
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
            double x = 2.75458054;
            return (float)(Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2))*x);
        }
        private void btnFindPath_Click(object sender, EventArgs e)
        {
            ResetNodes();
            // Lấy điểm bắt đầu và kết thúc từ TextBox
            //Node startNode = GetNodeFromInput(cbStart.Text);
            //Node endNode = GetNodeFromInput(cbEnd.Text);
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
                lblResult.Text ="Độ dài quãng đường:\r\n" + ((int)Heuristic(startNode,endNode)).ToString()+"m";
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
            /*
            foreach (var node in nodes)
            {
                g.FillEllipse(Brushes.Blue, node.x - 5, node.y - 5, 10, 10);
                g.DrawString(node.Name, new Font("Arial", 10), Brushes.Black, node.x + 10, node.y + 10);
            }

            // Vẽ các cạnh
            foreach (var node in nodes)
            {
                foreach (var edge in node.Edges)
                {
                    g.DrawLine(Pens.Black, node.x, node.y, edge.Destination.x, edge.Destination.y);
                }
            }*/
            // Vẽ đường nếu có
            if (path != null)
            {
                using (Pen p = new Pen(Brushes.Red, 10))
                {

                    foreach (var node in path)
                    {
                        g.FillEllipse(Brushes.Red, node.x - 5, node.y - 5, 10, 10);

                        if (node.Parent != null)
                        {                            
                            g.DrawLine(p, node.x, node.y, node.Parent.x, node.Parent.y);
                        }
                        //g.DrawString(node.Name, new Font("Arial", 10), Brushes.Black, node.x + 10, node.y + 10);
                    }                    
                    
                }

            }
            if(startNode != null) { g.FillEllipse(Brushes.Green, startNode.x - 10, startNode.y - 10, 20, 20); }
            if(endNode != null) { g.FillEllipse(Brushes.Blue, endNode.x - 10, endNode.y - 10, 20, 20); }
            
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

            //MessageBox.Show($"x = {x}, y = {y}");

            Node closestNode = FindClosestNode(x, y);

            if (closestNode != null)
            {
                if (isSelectingStart)
                {
                    startNode = closestNode;
                    //MessageBox.Show($"Điểm bắt đầu: {startNode.Name}");
                    isSelectingStart = false; // Reset trạng thái
                    cbStart.Text = startNode.Name;
                }
                else if (isSelectingEnd)
                {
                    endNode = closestNode;
                    //MessageBox.Show($"Điểm kết thúc: {endNode.Name}");
                    isSelectingEnd = false; // Reset trạng thái
                    cbEnd.Text = endNode.Name;
                }

                // Vẽ lại Panel nếu cần hiển thị các điểm đã chọn
                panel1.Invalidate();
            }
        }
        private Node FindClosestNode(int mouseX, int mouseY)
        {
            Node closestNode = null;
            double minDistance = double.MaxValue;

            foreach (var node in nodes)
            {
                // Giả sử mỗi node có tọa độ (node.X, node.Y)
                double distance = Math.Sqrt(Math.Pow(node.x - mouseX, 2) + Math.Pow(node.y - mouseY, 2));

                // Kiểm tra nếu khoảng cách ngắn hơn khoảng cách nhỏ nhất đã biết
                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestNode = node;
                }
            }

            return closestNode;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            isSelectingStart = true;
            isSelectingEnd = false;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            isSelectingStart = false;
            isSelectingEnd = true;
        }
    }
}
