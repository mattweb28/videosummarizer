﻿
//
// Custom control to display a histogram.
// Based off the source code from The Code Project.
//
// http://www.codeproject.com/KB/miscctrl/histogramcontrol.aspx?fid=229782&df=90&mpp=25&noise=3&sort=Position&view=Quick
//


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VideoPlayer
{
    public partial class HistogramControl : UserControl
    {

        public HistogramControl()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			this.Paint += new PaintEventHandler(OnPaint);
			this.Resize+=new EventHandler(OnResize);
		}

        private void OnPaint(object sender, PaintEventArgs e)
		{
			if (myIsDrawing)
			{

				Graphics g = e.Graphics;
				Pen myPen = new Pen(new SolidBrush(myColor),myXUnit);
				//The width of the pen is given by the XUnit for the control.
				for (int i=0;i<myValues.Length;i++)
				{

					//We draw each line 
					g.DrawLine(myPen,
						new PointF(myOffset + (i*myXUnit), this.Height - myOffset), 
						new PointF(myOffset + (i*myXUnit), this.Height - myOffset - myValues[i] * myYUnit));

					//We plot the coresponding index for the maximum value.
					if (myValues[i]==myMaxValue)
					{
						SizeF mySize = g.MeasureString(i.ToString(),myFont);

						g.DrawString(i.ToString(),myFont,new SolidBrush(myColor),
							new PointF(myOffset + (i*myXUnit) - (mySize.Width/2), this.Height - myFont.Height ),
							System.Drawing.StringFormat.GenericDefault);
					}
				}

				//We draw the indexes for 0 and for the length of the array beeing plotted
				g.DrawString("0",myFont, new SolidBrush(myColor),new PointF(myOffset,this.Height - myFont.Height),System.Drawing.StringFormat.GenericDefault);
				g.DrawString((myValues.Length-1).ToString(),myFont, 
					new SolidBrush(myColor),
					new PointF(myOffset + (myValues.Length * myXUnit) - g.MeasureString((myValues.Length-1).ToString(),myFont).Width,
					this.Height - myFont.Height),
					System.Drawing.StringFormat.GenericDefault);

				//We draw a rectangle surrounding the control.
				g.DrawRectangle(new System.Drawing.Pen(new SolidBrush(Color.Black),1),0,0,this.Width-1,this.Height-1);
			}

		}

		long myMaxValue;
		private long[] myValues;
		private bool myIsDrawing;

		private float myYUnit; //this gives the vertical unit used to scale our values
		private float myXUnit; //this gives the horizontal unit used to scale our values
		private int myOffset = 20; //the offset, in pixels, from the control margins.

		private Color myColor = Color.Black;
		private Font myFont = new Font("Tahoma",10);

		[Category("Histogram Options")]
		[Description ("The distance from the margins for the histogram")]
		public int Offset
		{
			set
			{
				if (value>0)
					myOffset= value;
			}
			get
			{
				return myOffset;
			}
		}

		[Category("Histogram Options")]
		[Description ("The color used within the control")]
		public Color DisplayColor
		{
			set
			{
				myColor = value;
			}
			get
			{
				return myColor;
			}
		}

		/// <summary>
		/// We draw the histogram on the control
		/// </summary>
		/// <param name="myValues">The values beeing draw</param>
		public void DrawHistogram(long[] Values)
		{
			myValues = new long[Values.Length];
			Values.CopyTo(myValues,0);

			myIsDrawing = true;
			myMaxValue = getMaxim(myValues);

			ComputeXYUnitValues();

			this.Refresh();
		}

		/// <summary>
		/// We get the highest value from the array
		/// </summary>
		/// <param name="Vals">The array of values in which we look</param>
		/// <returns>The maximum value</returns>
		private long getMaxim(long[] Vals)
		{
			if (myIsDrawing)
			{
				long max = 0;
				for (int i=0;i<Vals.Length;i++)
				{
					if (Vals[i] > max)
						max = Vals[i];
				}
				return max;
			}
			return 1;
		}

        private void OnResize(object sender, EventArgs e)
		{
			if (myIsDrawing)
			{
				ComputeXYUnitValues();
			}
			this.Refresh();
		}

		private void ComputeXYUnitValues()
		{
			myYUnit = (float) (this.Height - (2 * myOffset)) / myMaxValue;
			myXUnit = (float) (this.Width - (2 * myOffset)) / (myValues.Length-1);
		}
    }
}
