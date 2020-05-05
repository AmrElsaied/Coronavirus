#define Graph_And_Chart_PRO
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace ChartAndGraph
{
    /// <summary>
    /// this class demonstrates the use of chart events
    /// </summary>
    public partial class InfoBox : MonoBehaviour
    {
        //public PieChart[] PieChart;
        //public BarChart[] BarChart;
        public GraphChartBase[] GraphChart;
        //public RadarChart[] RadarChart;
        //public PyramidChart[] PyramidChart;
        public Text infoText; 
         
       // void BarHovered(BarChart.BarEventArgs args)
       //{
            
        //    infoText.text = string.Format("({0},{1}) : {2}", args.Category, args.Group, args.Value);
        //}

        //void RadarHovered(RadarChart.RadarEventArgs args)
        //{
       //     infoText.text = string.Format("{0},{1} : {2}", args.Category, args.Group, ChartAdancedSettings.Instance.FormatFractionDigits(2, args.Value));
        //}
        void GraphClicked(GraphChartBase.GraphEventArgs args)
        {
            if (args.Magnitude < 0f)
                infoText.text = string.Format("{0} : {1},{2} Clicked", args.Category, args.XString, args.YString);
            else
                infoText.text = string.Format("{0} : {1},{2} : Sample Size {3} Clicked", args.Category, args.XString, args.YString, args.Magnitude);
        }

        void GraphHoverd(GraphChartBase.GraphEventArgs args)
        {
            if (args.Magnitude < 0f)
                infoText.text = string.Format("{0} : {1},{2}", args.Category, args.XString, args.YString);
            else
                infoText.text = string.Format("{0} : {1},{2} : Sample Size {3}", args.Category, args.XString, args.YString, args.Magnitude);
        }

        void GraphLineClicked(GraphChartBase.GraphEventArgs args)
        {
            if (args.Magnitude < 0f)
                infoText.text = string.Format("Line Start at {0} : {1},{2} Clicked", args.Category, args.XString, args.YString);
            else
                infoText.text = string.Format("Line Start at{0} : {1},{2} : Sample Size {3} Clicked", args.Category, args.XString, args.YString, args.Magnitude);
        }

        void GraphLineHoverd(GraphChartBase.GraphEventArgs args)
        {
            if (args.Magnitude < 0f)
                infoText.text = string.Format("Line Start at {0} : {1},{2}", args.Category, args.XString, args.YString);
            else
                infoText.text = string.Format("Line Start at {0} : {1},{2} : Sample Size {3}", args.Category, args.XString, args.YString, args.Magnitude);
        }

        

        void NonHovered()
        {
            infoText.text = "";
        }

        partial void HookCandle();

        public void HookChartEvents()
        {
            
            
            //if(PyramidChart != null)
            ///{
             //   foreach (PyramidChart pyramid in PyramidChart)
             //   {
             //       if (pyramid == null)
             //           continue;
            //        pyramid.ItemHovered.AddListener(PyramidHovered);        // add listeners for the pie chart events
              //      pyramid.NonHovered.AddListener(NonHovered);
            //    }
            //}
            

            if(GraphChart  != null)
            {
                foreach(GraphChartBase graph in GraphChart)
                {
                    if (graph == null)
                        continue;
                    graph.PointClicked.AddListener(GraphClicked);
                    graph.PointHovered.AddListener(GraphHoverd);
                    if(graph is GraphChart)
                    {
                        ((GraphChart)graph).LineClicked.AddListener(GraphLineClicked);
                        ((GraphChart)graph).LineHovered.AddListener(GraphLineHoverd);
                    }
                    graph.NonHovered.AddListener(NonHovered);
                }
            }
            HookCandle();
           
        }

        // Use this for initialization
        void Start()
        {
            HookChartEvents();
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
}