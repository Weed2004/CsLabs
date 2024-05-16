using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private Graph graph;
        private Graph buffer;

        public Form1()
        {
            InitializeComponent();
            graph = GraphInit();
            graphPanel.Paint += GraphPanel_Paint;

            saveFileDialog1.Filter = "Graph Files|*.g";
            openFileDialog1.Filter = "Graph Files|*.g";
        }

        public Graph GraphInit()
        {
            Graph graph = new Graph();

            Node node1 = graph.CreateNode("node1");
            Node node2 = graph.CreateNode("node2");
            Node node3 = graph.CreateNode("node3");
            Node node4 = graph.CreateNode("node4");

            graph.Connect(node1, node2, 3);
            graph.Connect(node2, node3, 54);

            GeneratePositions(graph);

            buffer = graph;

            return graph;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GraphPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawGraph(e.Graphics);
        }

        private void DrawGraph(Graphics graphics)
        {
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(Color.Black);
            Brush textBrush = new SolidBrush(Color.Red);
            Font font = new Font("Arial", 10);

            GeneratePositions(graph);

            foreach (var node in graph.Nodes())
            {
                // Draw node
                graphics.FillEllipse(brush, node.Position.X-10, node.Position.Y-10,20,20);

                foreach (var connection in node.Connections())
                {
                    graphics.DrawLine(pen, node.Position, connection.Item2.Position);
                    graphics.DrawString(connection.Item1.ToString(), font, textBrush,
                        (node.Position.X + connection.Item2.Position.X) / 2,
                        (node.Position.Y + connection.Item2.Position.Y) / 2);
                }

                graphics.DrawString(node.Name, font, textBrush, node.Position.X - 10, node.Position.Y - 10);
            }
        }

        private void GeneratePositions(Graph graph)
        {
            int panelWidth = graphPanel.ClientSize.Width;
            int panelHeight = graphPanel.ClientSize.Height;

            Point center = new Point(panelWidth/2, panelHeight/2);
            int r = Math.Min(panelWidth, panelHeight) /3;
            double step = 1;
            if (graph.NumOfNodes() != 0)
            {
                step = 360 / graph.NumOfNodes();
            }

            double i = step;
            foreach (var node in graph.Nodes())
            {
                node.Position = new Point((center.X + (int)(r*Math.Cos(i*(Math.PI/180)))),(center.Y+ (int)(r*Math.Sin((i * (Math.PI / 180))))));
                i += step;
            }
        }

        private void createNodeButton_Click(object sender, EventArgs e)
        {
            graph.CreateNode(createNodeNameTextBox.Text);
            graphPanel.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Node node1 = graph.GetNode(addConnectionNode1Name.Text);
            Node node2 = graph.GetNode(addConnectionNode2Name.Text);

            if(node1!=null&& node2!=null)
            {
                graph.Connect(node1, node2, Convert.ToInt16(addConnectionWeight.Text));
                graphPanel.Invalidate();
            }
        }

        private void removeConnectionButton_Click(object sender, EventArgs e)
        {
            Node node1 = graph.GetNode(removeConnectionNode1Name.Text);
            Node node2 = graph.GetNode(removeConnectionNode2Name.Text);

            if (node1 != null && node2 != null)
            {
                graph.RemoveConnection(node1, node2);
                graphPanel.Invalidate();
            }
        }

        private void removeNodeButton_Click(object sender, EventArgs e)
        {
            Node node = graph.GetNode(removeNodeName.Text);
            if(node != null )
            {
                graph.RemoveNode(node);
                graphPanel.Invalidate();
            }
        }

        private void pathFindButton_Click(object sender, EventArgs e)
        {
            Node start = graph.GetNode(pathFindNode1Name.Text);
            Node end = graph.GetNode(pathFindNode2Name.Text);

            if(start != null && end != null)
            {
                buffer = graph;
                graph = DijkstraАlgorithm.PathFind(graph, start, end);
                graphPanel.Invalidate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graph = buffer;
            graphPanel.Invalidate();
        }

        private void saveGrapgButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                Logger.Print("Ошибка, файл не найден");
                return;
            }
            string fileName = saveFileDialog1.FileName;
            Serializer.BinarySerialize(graph, fileName);
        }

        private void loadGrapghButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                Logger.Print("Ошибка, файл не найден");
                return;
            }

            string fileName = openFileDialog1.FileName;
            graph = Serializer.BinaryDeserialize(fileName);
            graphPanel.Invalidate();
        }
    }
}
