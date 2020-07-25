using GraphLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace GraphDrawing
{
	public enum GraphMode
	{ Rectangular, Polar };

	public partial class ExpressionPlotter : Control
	{

		#region MemberVariables

		private int iLengthScale; //represents no. of pixels for a scale
		private int iOriginX, iOriginY; //represents the location of origin

		private double dScaleX = 10, dScaleY = 10;  //base scale for graph 
		private double dForwardX = 0, dForwardY = 0;//position related to base scale

		private int iDivisionsX = 5, iDivisionsY = 5;
		private int iLengthBox;
		private int iPrintStepX = 1;
		private int iPrintStepY = 1;
		private int iControlSize = 0;
		private int iPenWidth = 1;
		private bool bGrids = false;
		private bool bDisplayText = true;
		private int iPolarSensitivity = 100;
		private GraphMode graphMode = GraphMode.Rectangular;
		private PrintDocument printDoc;
		private readonly List<IEvaluatable> expressions;
		private readonly List<Color> expColors;
		private readonly List<bool> expVisible;

		#endregion

		#region Control specific functions
		public ExpressionPlotter()
		{
			expressions = new List<IEvaluatable>();
			expColors = new List<Color>();
			expVisible = new List<bool>();
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			//update internal variables
			UpdateVariables();

			pe.Graphics.Clear(Color.White);
			pe.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
			pe.Graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
			pe.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			PlotGraph(pe.Graphics);

			// Calling the base class OnPaint
			base.OnPaint(pe);
		}

		//private void ExpressionPlotter_Resize(object sender,EventArgs e)
		//{
		//,//code to keep the control's height and width same

		//,//see whether width was changed or the height was changed
		//,if (iControlSize != Width)
		//,,Height = Width; //width was changed so adjust height accordingly
		//,else
		//,,Width = Height; //height was changed so adjust width accordingly
		//}

		private void UpdateVariables()
		{
			iControlSize = Height;
			iLengthScale = (int)(iControlSize / 2.25);
			iOriginX = (Width) / 2;
			iOriginY = (Height) / 2;
			if (bGrids == true)
			{
				iLengthBox = iLengthScale;
			}
			else
			{
				iLengthBox = (int)(iLengthScale * 0.025);
			}
		}
		private double IncreaseScale(double scale)
		{
			double absScale = Math.Round(Math.Abs(scale), 3);
			double newScale;
			if (absScale >= 100)
			{
				newScale = (absScale + 100);
			}
			else if (absScale >= 10)
			{
				newScale = (absScale + 10);
			}
			else if (absScale >= 1)
			{
				newScale = (absScale + 1);
			}
			else if (absScale >= .10)
			{
				newScale = (absScale + .10);
			}
			else
			{
				newScale = (absScale + .010);
			}

			return newScale * Math.Sign(scale);
		}
		private double DecreaseScale(double scale)
		{
			double absScale = Math.Round(Math.Abs(scale), 3);
			double newScale;
			if (absScale > 100)
			{
				newScale = (absScale - 100);
			}
			else if (absScale > 10)
			{
				newScale = (absScale - 10);
			}
			else if (absScale > 1)
			{
				newScale = (absScale - 1);
			}
			else if (absScale > .1)
			{
				newScale = (absScale - .1);
			}
			else if (absScale > .01)
			{
				newScale = (absScale - .01);
			}
			else
			{
				newScale = absScale;
			}

			return newScale * Math.Sign(scale);
		}

		#endregion

		#region Properties
		public int DivisionsX
		{
			get => iDivisionsX;
			set
			{
				if (value > 0)
				{
					iDivisionsX = value;
				}
			}
		}
		public int DivisionsY
		{
			get => iDivisionsY;
			set
			{
				if (value > 0)
				{
					iDivisionsY = value;
				}
			}
		}

		public double ScaleX
		{
			get => dScaleX;
			set
			{
				if (value != 0)
				{
					dScaleX = value;
				}
			}
		}
		public double ScaleY
		{
			get => dScaleY;
			set
			{
				if (value != 0)
				{
					dScaleY = value;
				}
			}
		}

		public double ForwardX
		{
			get => dForwardX;
			set => dForwardX = value;
		}
		public double ForwardY
		{
			get => dForwardY;
			set => dForwardY = value;
		}

		public int PrintStepX
		{
			get => iPrintStepX;
			set
			{
				if (value > 0)
				{
					iPrintStepX = value;
				}
			}
		}
		public int PrintStepY
		{
			get => iPrintStepY;
			set
			{
				if (value > 0)
				{
					iPrintStepY = value;
				}
			}
		}

		public int PolarSensitivity
		{
			get => iPolarSensitivity;
			set
			{
				if (value > 0)
				{
					iPolarSensitivity = value;
				}
			}
		}

		public bool Grids
		{
			get => bGrids;
			set => bGrids = value;
		}

		public bool DisplayText
		{
			get => bDisplayText;
			set => bDisplayText = value;
		}

		public GraphMode GraphMode
		{
			get => graphMode;
			set => graphMode = value;
		}

		public int PenWidth
		{
			get => iPenWidth;
			set => iPenWidth = value;
		}

		#endregion

		#region Plotting Functions
		private void PlotGraph(Graphics g)
		{
			DisplayScale(g);
			if (bDisplayText)
			{
				DisplayExpressionsText(g);
			}

			double X, Y;
			double dPointX, dPointY;
			double dLeastStepX, dLeastStepY;
			double dMin, dMax, dStep;
			int i;

			//(X1,Y1) is the previous point ploted,(X2,Y2) is the current point to plot. (we will join both to have our 
			// graph continuous).
			float X1 = 0, Y1 = 0, X2 = 0, Y2 = 0;
			//This variable controls whether our graph should be continuous or not
			bool bContinuity = false;

			//divide scale with its length(pixels) to get increment per pixel
			dLeastStepX = dScaleX / iLengthScale;
			dLeastStepY = dScaleY / iLengthScale;

			//prepare variables for loop
			if (graphMode == GraphMode.Polar)
			{
				dMin = -Math.PI;
				dMax = Math.PI;
				dStep = dScaleX / iPolarSensitivity;
			}
			else //if (Rectangular Mode)
			{
				dStep = dLeastStepX;
				dMin = -dScaleX + dForwardX;
				dMax = dScaleX + dForwardX;
			}


			for (i = 0; i < expressions.Count; i++)
			{
				//check if expression needs to be drawn and is valid
				if (expVisible[i] == true && expressions[i].IsValid == true)
				{
					bContinuity = false;
					for (X = dMin; X != dMax; X += dStep)
					{
						if (dScaleX < 0 && X < dMax)
						{
							break;
						}

						if (dScaleX > 0 && X > dMax)
						{
							break;
						}

						try
						{
							//evaluate expression[i] at point: X
							Y = expressions[i].Evaluate(X);
							if (double.IsNaN(Y))
							{
								//break continuity in graph if expression returned a NaN
								bContinuity = false;
								continue;
							}

							//get points to plot
							if (graphMode == GraphMode.Polar)
							{
								dPointX = Y * Math.Cos(X) / dLeastStepX;
								dPointY = Y * Math.Sin(X) / dLeastStepY;
							}
							else // if (Rectangular mode;
							{
								dPointX = X / dLeastStepX;
								dPointY = Y / dLeastStepY;
							}

							//check if the point to be plotted lies inside our visible area(i.e. inside our current axes ranges)
							if ((iOriginY - dPointY + dForwardY / dLeastStepY) < iOriginY - iLengthScale
								|| (iOriginY - dPointY + dForwardY / dLeastStepY) > iOriginY + iLengthScale
								|| (iOriginX + dPointX - dForwardX / dLeastStepX) < iOriginX - iLengthScale
								|| (iOriginX + dPointX - dForwardX / dLeastStepX) > iOriginX + iLengthScale)
							{
								//the point lies outside our current scale so break continuity
								bContinuity = false;
								continue;
							}

							//get coordinates for currently evaluated point
							X2 = (float)(iOriginX + dPointX - dForwardX / dLeastStepX);
							Y2 = (float)(iOriginY - dPointY + dForwardY / dLeastStepY);

							//if graph should not be continuous
							if (bContinuity == false)
							{
								X1 = X2;
								Y1 = Y2;
								// the graph should be continuous afterwards since the current evaluated value is valid 
								//  and can be plot within our axes range
								bContinuity = true;

							}

							//join points (X1,Y1) and (X2,Y2)
							g.DrawLine(new Pen(expColors[i], iPenWidth), new PointF(X1, Y1), new PointF(X2, Y2));

							//get current values into X1,Y1
							X1 = X2;
							Y1 = Y2;
						}
						catch
						{
							bContinuity = false;
							continue;
						}

					}
				}
			}
		}

		private void DisplayScale(Graphics g)
		{
			//axes lines
			g.DrawLine(new Pen(Color.Black, 2),
				new Point(iOriginX - iLengthScale, iOriginY),
				new Point(iOriginX + iLengthScale, iOriginY));

			g.DrawLine(new Pen(Color.Black, 2),
				new Point(iOriginX, iOriginY - iLengthScale),
				new Point(iOriginX, iOriginY + iLengthScale));

			int i;
			double dValue;
			string strValue;

			float cordX, cordY;

			//X-axis values
			dValue = -dScaleX + dForwardX;
			for (i = -iDivisionsX; i <= iDivisionsX; i++)
			{
				g.DrawLine(new Pen(Color.Gray, 1),
					new PointF((float)(iOriginX + (dValue - dForwardX) * iLengthScale / dScaleX), iOriginY - iLengthBox),
					new PointF((float)(iOriginX + (dValue - dForwardX) * iLengthScale / dScaleX), iOriginY + iLengthBox));
				if (i % iPrintStepX == 0 && i != 0)
				{
					strValue = Math.Round(dValue, 3).ToString();
					cordX = (float)(iOriginX + (dValue - dForwardX) * iLengthScale / dScaleX - 6 - (strValue.Length - 2) * 5);
					cordY = iOriginY + 10;
					g.DrawString(strValue, new Font("Arial", 8), new SolidBrush(Color.Black), cordX, cordY);
				}
				dValue = dValue + dScaleX / iDivisionsX;
			}


			//Y-axis values
			dValue = -dScaleY + dForwardY;
			for (i = -iDivisionsY; i <= iDivisionsY; i++)
			{
				g.DrawLine(new Pen(Color.Gray, 1),
					new PointF(iOriginX - iLengthBox, (float)(iOriginY + (dValue - dForwardY) * iLengthScale / dScaleY)),
					new PointF(iOriginX + iLengthBox, (float)(iOriginY + (dValue - dForwardY) * iLengthScale / dScaleY)));
				if (i % iPrintStepY == 0 && i != 0)
				{
					strValue = Math.Round(dValue, 3).ToString();
					cordX = iOriginX - 20 - (strValue.Length) * 4;
					cordY = (float)(iOriginY - (dValue - dForwardY) * iLengthScale / dScaleY - 7);
					if (iLengthBox == iLengthScale)
					{
						cordY += 6;
					}

					g.DrawString(strValue, new Font("Arial", 8), new SolidBrush(Color.Black), cordX, cordY);
				}
				dValue = dValue + dScaleY / iDivisionsY;
			}

			if (graphMode == GraphMode.Polar)
			{
				g.DrawEllipse(new Pen(Color.Black, 1), iOriginX - iLengthScale, iOriginY - (float)(iLengthScale * dScaleX / dScaleY), iLengthScale * 2, (float)(iLengthScale * dScaleX / dScaleY) * 2);
				for (dValue = 0; dValue <= 2 * Math.PI; dValue += Math.PI / 6)
				{
					g.DrawLine(new Pen(Color.Black, 1), new Point(iOriginX, iOriginY),
						new PointF((float)(iOriginX + iLengthScale * Math.Cos(dValue)), (float)(iOriginY + iLengthScale * Math.Sin(dValue))));
				}
			}
		}

		private void DisplayExpressionsText(Graphics g)
		{
			int line = 0;
			for (int i = 0; i < expressions.Count; i++)
			{
				if (expVisible[i] == true)
				{
					if (expressions[i].IsValid)
					{
						g.DrawString(expressions[i].ExpressionText, new Font("Arial", 10), new SolidBrush(expColors[i]), 10, 10 + 18 * line);
					}
					else
					{
						g.DrawString("ERROR: " + expressions[i].ExpressionText, new Font("Arial", 10), new SolidBrush(expColors[i]), 10, 10 + 18 * line);
					}

					line++;
				}
			}
		}

		private void InitializePrintDoc()
		{
			printDoc = new PrintDocument
			{
				OriginAtMargins = true
			};
			printDoc.DefaultPageSettings.Margins.Left = 200;
			printDoc.DefaultPageSettings.Margins.Top = 100;
			printDoc.DocumentName = "Graph Plotter by Syed Mehroz Alam";
			printDoc.PrintPage += delegate (object sender, PrintPageEventArgs e) { PlotGraph(e.Graphics); };
		}

		#endregion

		#region Public functions for expression management

		public void AddExpression(IEvaluatable expression, Color color, bool visible)
		{
			expressions.Add(expression);
			expColors.Add(color);
			expVisible.Add(visible);
		}
		public bool RemoveExpression(IEvaluatable expression)
		{
			int index = expressions.IndexOf(expression);
			if (index == -1)
			{
				return false;
			}

			expressions.RemoveAt(index);
			expColors.RemoveAt(index);
			expVisible.RemoveAt(index);
			return true;
		}

		public void RemoveExpressionAt(int index)
		{
			// can throw OutOfRangeException
			expressions.RemoveAt(index);
			expColors.RemoveAt(index);
			expVisible.RemoveAt(index);
		}

		public void RemoveAllExpressions()
		{
			expressions.Clear();
			expColors.Clear();
			expVisible.Clear();
		}

		public IEvaluatable GetExpression(int index)
		{
			// can throw OutOfRangeException
			return expressions[index];
		}
		public Color GetExpressionColor(int index)
		{
			// can throw OutOfRangeException
			return expColors[index];
		}

		public bool GetExpressionVisibility(int index)
		{
			// can throw OutOfRangeException
			return expVisible[index];
		}

		public void SetExpression(int index, IEvaluatable expression)
		{
			// can throw OutOfRangeException
			expressions[index] = expression;
		}

		public void SetExpressionColor(int index, Color color)
		{
			// can throw OutOfRangeException
			expColors[index] = color;
		}

		public void SetExpressionVisibility(int index, bool visibility)
		{
			// can throw OutOfRangeException
			expVisible[index] = visibility;
		}

		#endregion

		#region Public functions for graph management

		public void SetRangeX(double startX, double endX)
		{
			dScaleX = (endX - startX) / 2;
			dForwardX = (endX + startX) / 2;
		}

		public void SetRangeY(double startY, double endY)
		{
			dScaleY = (endY - startY) / 2;
			dForwardY = (endY + startY) / 2;
		}

		public void RestoreDefaults()
		{
			dScaleX = dScaleY = 10;
			dForwardX = dForwardY = 0;
			iDivisionsX = iDivisionsY = 5;
			iPrintStepX = iPrintStepY = 1;
			bGrids = false;
			iPolarSensitivity = 100;
		}

		public void ToggleGrids()
		{
			bGrids = (!bGrids);
		}

		public double[] GetValues(double x)
		{
			double[] result = new double[expressions.Count];
			for (int i = 0; i < expressions.Count; i++)
			{
				if (expressions[i].IsValid)
				{
					result[i] = expressions[i].Evaluate(x);
				}
			}

			return result;
		}

		public Bitmap GetGraphBitmap()
		{
			Bitmap bmpSnap = new Bitmap(Width, Height);
			DrawToBitmap(bmpSnap, new Rectangle(0, 0, Width, Height));
			return bmpSnap;
		}

		public void CopyToClipboard()
		{
			Clipboard.SetImage(GetGraphBitmap());
		}

		public void MoveLeft(int divisions)
		{
			dForwardX -= divisions * dScaleX / iDivisionsX;
		}

		public void MoveRight(int divisions)
		{
			dForwardX += divisions * dScaleX / iDivisionsX;
		}

		public void MoveUp(int divisions)
		{
			dForwardY += divisions * dScaleY / iDivisionsY;
		}

		public void MoveDown(int divisions)
		{
			dForwardY -= divisions * dScaleY / iDivisionsY;
		}

		public void ZoomInX()
		{
			dScaleX = DecreaseScale(dScaleX);
		}

		public void ZoomInY()
		{
			dScaleY = DecreaseScale(dScaleY);
		}

		public void ZoomOutX()
		{
			dScaleX = IncreaseScale(dScaleX);
		}

		public void ZoomOutY()
		{
			dScaleY = IncreaseScale(dScaleY);
		}

		public void ZoomIn()
		{
			ZoomInX();
			ZoomInY();
		}

		public void ZoomOut()
		{
			ZoomOutX();
			ZoomOutY();
		}
		#endregion

	}
}
