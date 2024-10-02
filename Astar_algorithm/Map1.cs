// Form1.Nodes.cs
using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Astar_algorithm
{
    public partial class Form1
    {
        private void InitializeNodes()
        {
            nodes = new List<Node>();

            Node node0 = new Node { Name = "0", x = 435, y = 95 };
            Node node0_1 = new Node { Name = "0_1", x = 430, y = 85 };
            Node node1 = new Node { Name = "1", x = 625, y = 57 };
            Node node2 = new Node { Name = "2", x = 470, y = 177 };
            Node node3 = new Node { Name = "3", x = 642, y = 119 };
            Node node4 = new Node { Name = "4", x = 509, y = 263 };
            Node node5 = new Node { Name = "5", x = 569, y = 376 };
            Node node67 = new Node { Name = "67", x = 550, y = 350 };
            Node node68 = new Node { Name = "68", x = 558, y = 384 };
            Node node5_1 = new Node { Name = "5_1", x = 535, y = 412 };
            Node node6 = new Node { Name = "6", x = 699, y = 292 };
            Node node7 = new Node { Name = "7", x = 496, y = 499 };
            Node node8 = new Node { Name = "8", x = 458, y = 491 };
            Node node9 = new Node { Name = "9", x = 409, y = 391 };
            Node node10 = new Node { Name = "10", x = 381, y = 361 };
            Node node11 = new Node { Name = "11", x = 364, y = 344 };
            Node node12 = new Node { Name = "12", x = 353, y = 331 };
            Node node13 = new Node { Name = "13", x = 290, y = 265 };
            Node node14 = new Node { Name = "14", x = 279, y = 250 };
            Node node15 = new Node { Name = "15", x = 690, y = 261 };
            Node node16 = new Node { Name = "16", x = 720, y = 348 };
            Node node17 = new Node { Name = "17", x = 733, y = 395 };
            Node node18 = new Node { Name = "18", x = 749, y = 443 };
            Node node19 = new Node { Name = "19", x = 765, y = 497 };
            Node node20 = new Node { Name = "20", x = 719, y = 456 };
            Node node21 = new Node { Name = "21", x = 722, y = 499 };
            Node node22 = new Node { Name = "22", x = 746, y = 498 };
            Node node23 = new Node { Name = "23", x = 340, y = 206 };
            Node node24 = new Node { Name = "24", x = 319, y = 236 };
            Node node25 = new Node { Name = "25", x = 303, y = 252 };
            Node node26 = new Node { Name = "26", x = 293, y = 238 };
            Node node27 = new Node { Name = "27", x = 366, y = 318 };
            Node node28 = new Node { Name = "28", x = 380, y = 329 };
            Node node29 = new Node { Name = "29", x = 468, y = 320 };
            Node node30 = new Node { Name = "30", x = 461, y = 342 };
            Node node31 = new Node { Name = "31", x = 398, y = 343 };
            Node node32 = new Node { Name = "32", x = 429, y = 322 };
            Node node33 = new Node { Name = "33", x = 369, y = 432 };
            Node node34 = new Node { Name = "34", x = 335, y = 468 };
            Node node35 = new Node { Name = "35", x = 308, y = 498 };
            Node node36 = new Node { Name = "36", x = 423, y = 508 };
            Node node37 = new Node { Name = "37", x = 457, y = 511 };
            Node node38 = new Node { Name = "38", x = 502, y = 513 };
            Node node39 = new Node { Name = "39", x = 534, y = 515 };
            Node node40 = new Node { Name = "40", x = 533, y = 535 };
            Node node41 = new Node { Name = "41", x = 471, y = 548 };
            Node node42 = new Node { Name = "42", x = 288, y = 679 };
            Node node43 = new Node { Name = "43", x = 245, y = 674 };
            Node node44 = new Node { Name = "44", x = 241, y = 712 };
            Node node45 = new Node { Name = "45", x = 285, y = 713 };
            Node node46 = new Node { Name = "46", x = 174, y = 610 };
            Node node47 = new Node { Name = "47", x = 277, y = 523 };
            Node node48 = new Node { Name = "48", x = 341, y = 392 };
            Node node49 = new Node { Name = "49", x = 242, y = 483 };
            Node node50 = new Node { Name = "50", x = 331, y = 377 };
            Node node51 = new Node { Name = "51", x = 233, y = 471 };
            Node node52 = new Node { Name = "52", x = 321, y = 363 };
            Node node53 = new Node { Name = "53", x = 217, y = 453 };
            Node node54 = new Node { Name = "54", x = 98, y = 387 };
            Node node55 = new Node { Name = "55", x = 87, y = 361 };
            Node node56 = new Node { Name = "56", x = 89, y = 343 };
            Node node57 = new Node { Name = "57", x = 100, y = 322 };
            Node node58 = new Node { Name = "58", x = 200, y = 466 };
            Node node59 = new Node { Name = "59", x = 109, y = 551 };
            Node node60 = new Node { Name = "60", x = 90, y = 315 };
            Node node61 = new Node { Name = "61", x = 111, y = 423 };
            Node node62 = new Node { Name = "62", x = 81, y = 393 };
            Node node63 = new Node { Name = "63", x = 69, y = 472 };
            Node node64 = new Node { Name = "64", x = 53, y = 402 };
            Node node65 = new Node { Name = "65", x = 44, y = 354 };
            Node node66 = new Node { Name = "66", x = 90, y = 300 };
            Node node69 = new Node { Name = "69", x = 615, y = 510 };
            Node node70 = new Node { Name = "70", x = 630, y = 500 };
            Node node71 = new Node { Name = "71", x = 627, y = 520 };
            Node node72 = new Node { Name = "72", x = 592, y = 795 };
            Node node73 = new Node { Name = "73", x = 255, y = 290 };
            Node node74 = new Node { Name = "74", x = 725, y = 555 };
            Node node75 = new Node { Name = "75", x = 238, y = 210 };
            Node node76 = new Node { Name = "76", x = 125, y = 120 };
            Node node77 = new Node { Name = "77", x = 40, y = 273 };
            Node node78 = new Node { Name = "78", x = 2, y = 30 };
            Node node79 = new Node { Name = "79", x = 700, y = 40 };
            Node node80 = new Node { Name = "80", x = 400, y = 10 };

            Node nodex = new Node { Name = "x", x = 41, y = 320 };
            Node nodey = new Node { Name = "y", x = 245, y = 215 };

            node0.Edges.Add(new Edge(node1, Heuristic(node0, node1)));
            node0.Edges.Add(new Edge(node2, Heuristic(node0, node2)));
            node0.Edges.Add(new Edge(node0_1, Heuristic(node0, node0_1)));

            node1.Edges.Add(new Edge(node3, Heuristic(node1, node3)));

            node2.Edges.Add(new Edge(node0, Heuristic(node2, node0)));
            node2.Edges.Add(new Edge(node3, Heuristic(node2, node3)));
            node2.Edges.Add(new Edge(node4, Heuristic(node2, node4)));
            node2.Edges.Add(new Edge(node23, Heuristic(node2, node23)));

            node3.Edges.Add(new Edge(node1, Heuristic(node3, node1)));
            node3.Edges.Add(new Edge(node2, Heuristic(node3, node2)));
            node3.Edges.Add(new Edge(node15, Heuristic(node3, node15)));

            node4.Edges.Add(new Edge(node2, Heuristic(node4, node2)));
            node4.Edges.Add(new Edge(node67, Heuristic(node4, node67)));
            node4.Edges.Add(new Edge(node29, Heuristic(node4, node29)));

            node5.Edges.Add(new Edge(node67, Heuristic(node67, node5)));
            node5.Edges.Add(new Edge(node6, Heuristic(node6, node5)));
            //node5.Edges.Add(new Edge(node5_1, Heuristic(node5, node5_1)));

            node5_1.Edges.Add(new Edge(node68, Heuristic(node68, node5_1)));
            node5_1.Edges.Add(new Edge(node7, Heuristic(node7, node5_1)));

            node6.Edges.Add(new Edge(node15, Heuristic(node15, node6)));
            node6.Edges.Add(new Edge(node5, Heuristic(node6, node5)));
            node6.Edges.Add(new Edge(node16, Heuristic(node6, node16)));

            node7.Edges.Add(new Edge(node5_1, Heuristic(node5_1, node7)));
            node7.Edges.Add(new Edge(node8, Heuristic(node8, node7)));
            node7.Edges.Add(new Edge(node38, Heuristic(node7, node38)));

            node8.Edges.Add(new Edge(node7, Heuristic(node8, node7)));
            node8.Edges.Add(new Edge(node9, Heuristic(node8, node9)));
            node8.Edges.Add(new Edge(node37, Heuristic(node8, node37)));

            node9.Edges.Add(new Edge(node8, Heuristic(node8, node9)));
            node9.Edges.Add(new Edge(node10, Heuristic(node9, node10)));
            node9.Edges.Add(new Edge(node30, Heuristic(node9, node30)));
            node9.Edges.Add(new Edge(node33, Heuristic(node9, node33)));

            node10.Edges.Add(new Edge(node9, Heuristic(node9, node10)));
            node10.Edges.Add(new Edge(node11, Heuristic(node10, node11)));
            node10.Edges.Add(new Edge(node31, Heuristic(node10, node31)));
            node10.Edges.Add(new Edge(node48, Heuristic(node10, node48)));

            node11.Edges.Add(new Edge(node10, Heuristic(node10, node11)));
            node11.Edges.Add(new Edge(node12, Heuristic(node11, node12)));
            node11.Edges.Add(new Edge(node28, Heuristic(node11, node28)));
            node11.Edges.Add(new Edge(node50, Heuristic(node11, node50)));

            node12.Edges.Add(new Edge(node11, Heuristic(node11, node12)));
            node12.Edges.Add(new Edge(node13, Heuristic(node12, node13)));
            node12.Edges.Add(new Edge(node27, Heuristic(node12, node27)));
            node12.Edges.Add(new Edge(node52, Heuristic(node12, node52)));

            node13.Edges.Add(new Edge(node12, Heuristic(node12, node13)));
            node13.Edges.Add(new Edge(node14, Heuristic(node13, node14)));
            node13.Edges.Add(new Edge(node25, Heuristic(node13, node25)));
            node13.Edges.Add(new Edge(node73, Heuristic(node13, node73)));

            node14.Edges.Add(new Edge(node13, Heuristic(node13, node14)));
            node14.Edges.Add(new Edge(nodey, Heuristic(nodey, node14)));
            node14.Edges.Add(new Edge(node26, Heuristic(node26, node14)));
            //node14.Edges.Add(new Edge(nodey, Heuristic(node14, nodey)));

            node15.Edges.Add(new Edge(node3, Heuristic(node3, node15)));
            node15.Edges.Add(new Edge(node6, Heuristic(node6, node15)));

            node16.Edges.Add(new Edge(node6, Heuristic(node6, node16)));
            node16.Edges.Add(new Edge(node17, Heuristic(node17, node16)));

            node17.Edges.Add(new Edge(node16, Heuristic(node16, node17)));
            node17.Edges.Add(new Edge(node18, Heuristic(node18, node17)));
            node17.Edges.Add(new Edge(node20, Heuristic(node17, node20)));

            node18.Edges.Add(new Edge(node17, Heuristic(node17, node18)));
            node18.Edges.Add(new Edge(node19, Heuristic(node18, node19)));

            node19.Edges.Add(new Edge(node18, Heuristic(node18, node19)));
            node19.Edges.Add(new Edge(node22, Heuristic(node22, node19)));

            node20.Edges.Add(new Edge(node17, Heuristic(node17, node20)));
            node20.Edges.Add(new Edge(node21, Heuristic(node20, node21)));

            node21.Edges.Add(new Edge(node22, Heuristic(node21, node22)));
            node21.Edges.Add(new Edge(node70, Heuristic(node21, node70)));

            node22.Edges.Add(new Edge(node19, Heuristic(node22, node19)));
            node22.Edges.Add(new Edge(node21, Heuristic(node21, node22)));
            node22.Edges.Add(new Edge(node74, Heuristic(node74, node22)));

            node23.Edges.Add(new Edge(node2, Heuristic(node2, node23)));
            node23.Edges.Add(new Edge(node24, Heuristic(node24, node23)));

            node24.Edges.Add(new Edge(node23, Heuristic(node24, node23)));
            node24.Edges.Add(new Edge(node25, Heuristic(node25, node24)));

            node25.Edges.Add(new Edge(node13, Heuristic(node25, node13)));
            node25.Edges.Add(new Edge(node24, Heuristic(node25, node24)));
            node25.Edges.Add(new Edge(node26, Heuristic(node26, node25)));
            node25.Edges.Add(new Edge(node27, Heuristic(node25, node27)));

            node26.Edges.Add(new Edge(node25, Heuristic(node25, node26)));
            node26.Edges.Add(new Edge(node14, Heuristic(node14, node26)));

            node27.Edges.Add(new Edge(node25, Heuristic(node25, node27)));
            node27.Edges.Add(new Edge(node28, Heuristic(node27, node28)));
            node27.Edges.Add(new Edge(node12, Heuristic(node12, node27)));

            node28.Edges.Add(new Edge(node27, Heuristic(node27, node28)));
            node28.Edges.Add(new Edge(node11, Heuristic(node11, node28)));

            node29.Edges.Add(new Edge(node4, Heuristic(node4, node29)));
            node29.Edges.Add(new Edge(node30, Heuristic(node29, node30)));

            node30.Edges.Add(new Edge(node29, Heuristic(node30, node29)));
            node30.Edges.Add(new Edge(node9, Heuristic(node30, node9)));

            node31.Edges.Add(new Edge(node10, Heuristic(node10, node31)));
            node31.Edges.Add(new Edge(node32, Heuristic(node31, node32)));

            node32.Edges.Add(new Edge(node31, Heuristic(node32, node31)));

            node33.Edges.Add(new Edge(node9, Heuristic(node33, node9)));
            node33.Edges.Add(new Edge(node34, Heuristic(node33, node34)));

            node34.Edges.Add(new Edge(node33, Heuristic(node33, node34)));
            node34.Edges.Add(new Edge(node35, Heuristic(node34, node35)));

            node35.Edges.Add(new Edge(node34, Heuristic(node34, node35)));
            node35.Edges.Add(new Edge(node36, Heuristic(node35, node36)));
            node35.Edges.Add(new Edge(node47, Heuristic(node47, node35)));

            node36.Edges.Add(new Edge(node35, Heuristic(node35, node36)));
            node36.Edges.Add(new Edge(node37, Heuristic(node36, node37)));
            node36.Edges.Add(new Edge(node41, Heuristic(node36, node41)));

            node37.Edges.Add(new Edge(node36, Heuristic(node36, node37)));
            node37.Edges.Add(new Edge(node38, Heuristic(node37, node38)));
            node37.Edges.Add(new Edge(node8, Heuristic(node37, node8)));

            node38.Edges.Add(new Edge(node37, Heuristic(node37, node38)));
            node38.Edges.Add(new Edge(node39, Heuristic(node39, node38)));

            node39.Edges.Add(new Edge(node38, Heuristic(node38, node39)));
            node39.Edges.Add(new Edge(node69, Heuristic(node39, node69)));

            node40.Edges.Add(new Edge(node41, Heuristic(node40, node41)));
            node40.Edges.Add(new Edge(node39, Heuristic(node40, node39)));

            node41.Edges.Add(new Edge(node40, Heuristic(node40, node41)));
            node41.Edges.Add(new Edge(node36, Heuristic(node41, node36)));
            node41.Edges.Add(new Edge(node42, Heuristic(node41, node42)));

            node42.Edges.Add(new Edge(node43, Heuristic(node42, node43)));
            node42.Edges.Add(new Edge(node41, Heuristic(node42, node41)));
            node42.Edges.Add(new Edge(node45, Heuristic(node42, node45)));

            node43.Edges.Add(new Edge(node42, Heuristic(node42, node43)));
            node43.Edges.Add(new Edge(node44, Heuristic(node44, node43)));
            node43.Edges.Add(new Edge(node46, Heuristic(node43, node46)));

            node44.Edges.Add(new Edge(node43, Heuristic(node44, node43)));
            node44.Edges.Add(new Edge(node45, Heuristic(node44, node45)));

            node45.Edges.Add(new Edge(node44, Heuristic(node44, node45)));
            node45.Edges.Add(new Edge(node42, Heuristic(node42, node45)));

            node46.Edges.Add(new Edge(node43, Heuristic(node46, node43)));
            node46.Edges.Add(new Edge(node47, Heuristic(node46, node47)));
            node46.Edges.Add(new Edge(node59, Heuristic(node46, node59)));

            node47.Edges.Add(new Edge(node46, Heuristic(node46, node47)));
            node47.Edges.Add(new Edge(node35, Heuristic(node35, node47)));
            node47.Edges.Add(new Edge(node49, Heuristic(node47, node49)));

            node48.Edges.Add(new Edge(node10, Heuristic(node10, node48)));
            node48.Edges.Add(new Edge(node49, Heuristic(node48, node49)));
            node48.Edges.Add(new Edge(node50, Heuristic(node48, node50)));

            node49.Edges.Add(new Edge(node48, Heuristic(node49, node48)));
            node49.Edges.Add(new Edge(node47, Heuristic(node49, node47)));
            node49.Edges.Add(new Edge(node51, Heuristic(node49, node51)));

            node50.Edges.Add(new Edge(node11, Heuristic(node11, node50)));
            node50.Edges.Add(new Edge(node48, Heuristic(node48, node50)));
            node50.Edges.Add(new Edge(node51, Heuristic(node50, node51)));
            node50.Edges.Add(new Edge(node52, Heuristic(node50, node52)));

            node51.Edges.Add(new Edge(node50, Heuristic(node51, node50)));
            node51.Edges.Add(new Edge(node49, Heuristic(node51, node49)));
            node51.Edges.Add(new Edge(node53, Heuristic(node51, node53)));

            node52.Edges.Add(new Edge(node50, Heuristic(node52, node50)));
            node52.Edges.Add(new Edge(node12, Heuristic(node52, node12)));
            node52.Edges.Add(new Edge(node53, Heuristic(node52, node53)));
            node52.Edges.Add(new Edge(node73, Heuristic(node52, node73)));

            node53.Edges.Add(new Edge(node52, Heuristic(node52, node53)));
            node53.Edges.Add(new Edge(node51, Heuristic(node51, node53)));
            node53.Edges.Add(new Edge(node54, Heuristic(node53, node54)));
            node53.Edges.Add(new Edge(node58, Heuristic(node53, node58)));

            node54.Edges.Add(new Edge(node53, Heuristic(node53, node54)));
            node54.Edges.Add(new Edge(node55, Heuristic(node54, node55)));
            node54.Edges.Add(new Edge(node62, Heuristic(node54, node62)));

            node55.Edges.Add(new Edge(node54, Heuristic(node54, node55)));
            node55.Edges.Add(new Edge(node56, Heuristic(node56, node55)));

            node56.Edges.Add(new Edge(node55, Heuristic(node56, node55)));
            node56.Edges.Add(new Edge(node57, Heuristic(node56, node57)));

            node57.Edges.Add(new Edge(node56, Heuristic(node56, node57)));
            node57.Edges.Add(new Edge(node60, Heuristic(node57, node60)));

            node58.Edges.Add(new Edge(node53, Heuristic(node53, node58)));
            node58.Edges.Add(new Edge(node59, Heuristic(node59, node58)));
            node58.Edges.Add(new Edge(node61, Heuristic(node61, node58)));

            node59.Edges.Add(new Edge(node58, Heuristic(node58, node59)));
            node59.Edges.Add(new Edge(node46, Heuristic(node46, node59)));
            node59.Edges.Add(new Edge(node63, Heuristic(node59, node63)));

            node60.Edges.Add(new Edge(node57, Heuristic(node57, node60)));
            node60.Edges.Add(new Edge(nodey, Heuristic(node60, nodey)));

            node61.Edges.Add(new Edge(node58, Heuristic(node58, node61)));
            node61.Edges.Add(new Edge(node62, Heuristic(node61, node62)));

            node62.Edges.Add(new Edge(node61, Heuristic(node61, node62)));
            node62.Edges.Add(new Edge(node54, Heuristic(node54, node62)));

            node63.Edges.Add(new Edge(node59, Heuristic(node59, node63)));
            node63.Edges.Add(new Edge(node64, Heuristic(node64, node63)));

            node64.Edges.Add(new Edge(node63, Heuristic(node64, node63)));
            node64.Edges.Add(new Edge(node65, Heuristic(node65, node64)));

            node65.Edges.Add(new Edge(node64, Heuristic(node65, node64)));
            node65.Edges.Add(new Edge(nodex, Heuristic(node65, nodex)));
            node65.Edges.Add(new Edge(node55, Heuristic(node55, node65)));

            node66.Edges.Add(new Edge(nodex, Heuristic(nodex, node66)));

            node67.Edges.Add(new Edge(node4, Heuristic(node4, node67)));
            node67.Edges.Add(new Edge(node68, Heuristic(node68, node67)));
            node67.Edges.Add(new Edge(node71, Heuristic(node71, node67)));


            node68.Edges.Add(new Edge(node5_1, Heuristic(node5_1, node68)));
            node68.Edges.Add(new Edge(node69, Heuristic(node69, node68)));

            node69.Edges.Add(new Edge(node70, Heuristic(node70, node69)));
            node69.Edges.Add(new Edge(node39, Heuristic(node39, node69)));
            node69.Edges.Add(new Edge(node74, Heuristic(node74, node69)));

            node70.Edges.Add(new Edge(node21, Heuristic(node21, node70)));
            node70.Edges.Add(new Edge(node5, Heuristic(node5, node70)));
            node70.Edges.Add(new Edge(node69, Heuristic(node69, node70)));

            node71.Edges.Add(new Edge(node67, Heuristic(node67, node71)));
            node71.Edges.Add(new Edge(node72, Heuristic(node72, node71)));

            node72.Edges.Add(new Edge(node71, Heuristic(node72, node71)));

            node73.Edges.Add(new Edge(node52, Heuristic(node73, node52)));
            node73.Edges.Add(new Edge(node13, Heuristic(node73, node13)));

            node74.Edges.Add(new Edge(node69, Heuristic(node74, node69)));
            node74.Edges.Add(new Edge(node22, Heuristic(node74, node22)));

            node75.Edges.Add(new Edge(node66, Heuristic(node75, node66)));
            node75.Edges.Add(new Edge(node76, Heuristic(node75, node76)));

            node76.Edges.Add(new Edge(node75, Heuristic(node75, node76)));
            node76.Edges.Add(new Edge(node77, Heuristic(node77, node76)));

            node77.Edges.Add(new Edge(node76, Heuristic(node77, node76)));
            node77.Edges.Add(new Edge(node78, Heuristic(node77, node78)));

            node78.Edges.Add(new Edge(nodex, Heuristic(node78, nodex)));

            node79.Edges.Add(new Edge(node0_1, Heuristic(node79, node0_1)));

            node80.Edges.Add(new Edge(node0_1, Heuristic(node80, node0_1)));

            //node0.Edges.Add(new Edge(nodex, Heuristic(node0, nodex)));


            //nodex.Edges.Add(new Edge(nodey, Heuristic(nodey, nodex)));
            nodex.Edges.Add(new Edge(node60, Heuristic(node60, nodex)));
            nodex.Edges.Add(new Edge(node65, Heuristic(node65, nodex)));
            nodex.Edges.Add(new Edge(node77, Heuristic(node77, nodex)));

            nodey.Edges.Add(new Edge(node0, Heuristic(node0, nodey)));
            nodey.Edges.Add(new Edge(node14, Heuristic(node14, nodey)));

            node0_1.Edges.Add(new Edge(node0, Heuristic(node0, node0_1)));
            node0_1.Edges.Add(new Edge(node75, Heuristic(node75, node0_1)));
            node0_1.Edges.Add(new Edge(node80, Heuristic(node80, node0_1)));


            nodes.Add(node0);
            nodes.Add(node0_1);
            nodes.Add(node1);
            nodes.Add(node2);
            nodes.Add(node3);
            nodes.Add(node4);
            nodes.Add(node5);
            nodes.Add(node6);
            nodes.Add(node7);
            nodes.Add(node8);
            nodes.Add(node9);
            nodes.Add(node10);
            nodes.Add(node11);
            nodes.Add(node12);
            nodes.Add(node13);
            nodes.Add(node14);
            nodes.Add(node15);
            nodes.Add(node16);
            nodes.Add(node17);
            nodes.Add(node18);
            nodes.Add(node19);
            nodes.Add(node20);
            nodes.Add(node21);
            nodes.Add(node22);
            nodes.Add(node5_1);
            nodes.Add(node23);
            nodes.Add(node24);
            nodes.Add(node25);
            nodes.Add(node26);
            nodes.Add(node27);
            nodes.Add(node28);
            nodes.Add(node29);
            nodes.Add(node30);
            nodes.Add(node31);
            nodes.Add(node32);
            nodes.Add(node33);
            nodes.Add(node34);
            nodes.Add(node35);
            nodes.Add(node36);
            nodes.Add(node37);
            nodes.Add(node38);
            nodes.Add(node39);
            nodes.Add(node40);
            nodes.Add(node41);
            nodes.Add(node42);
            nodes.Add(node43);
            nodes.Add(node44);
            nodes.Add(node45);
            nodes.Add(node46);
            nodes.Add(node47);
            nodes.Add(node48);
            nodes.Add(node49);
            nodes.Add(node50);
            nodes.Add(node51);
            nodes.Add(node52);
            nodes.Add(node53);
            nodes.Add(node54);
            nodes.Add(node55);
            nodes.Add(node56);
            nodes.Add(node57);
            nodes.Add(node58);
            nodes.Add(node59);
            nodes.Add(node60);
            nodes.Add(node61);
            nodes.Add(node62);
            nodes.Add(node63);
            nodes.Add(node64);
            nodes.Add(node65);
            nodes.Add(node66);
            nodes.Add(node67);
            nodes.Add(node68);
            nodes.Add(node69);
            nodes.Add(node70);
            nodes.Add(node71);
            nodes.Add(node72);
            nodes.Add(node73);
            nodes.Add(node74);
            nodes.Add(node75);
            nodes.Add(node76);
            nodes.Add(node77);
            nodes.Add(node78);
            nodes.Add(node79);
            nodes.Add(node80);

            nodes.Add(nodex);
            nodes.Add(nodey);
        }
    }
}
