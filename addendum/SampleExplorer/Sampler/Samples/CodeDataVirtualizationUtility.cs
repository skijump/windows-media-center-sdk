//
// "Fractal Snow"
// by Tomas Petricek (http://www.thecodeproject.com)
//

using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FractalSnow
{
	/// <summary>
	/// Object for drawing fractal snow flake
	/// </summary>
	public class SnowFlake
	{
    #region Types

    public enum FlakeType {LineType,PointType}

    #endregion
    #region Local variables

    private int iMaxDepth=2;
    private FlakeType type=FlakeType.LineType;
    private int iBranchAngle=30;
    private float fBranching=0.33f;
    private float fShrinking=0.66f;
    private int iSize=50;
    private bool bChanged=true;
    private bool bAntialias=true;

    private float minx,miny,maxx,maxy;
    private Bitmap bmpBack;
    private Color color=Color.White;

    #endregion
    #region Properties

    /// <summary>
    /// Flake type - LineType or PointType
    /// </summary>
    public FlakeType Type
    {
      get { return type; }
      set { type=value; bChanged=true; }
    }


    /// <summary>
    /// Fractal depth (from 0 to approx 10 for LineType and 7 for PointType)
    /// </summary>
    public int Depth
    {
      get { return iMaxDepth; }
      set { iMaxDepth=value; bChanged=true; }
    }


    /// <summary>
    /// Angel of new branch (in degrees)
    /// </summary>
    public int BranchAngle
    {
      get { return iBranchAngle; }
      set { iBranchAngle=value; bChanged=true; }
    }


    /// <summary>
    /// Position of branching point (less than 1)
    /// </summary>
    public float Branching
    {
      get { return fBranching; }
      set { fBranching=value; bChanged=true; }
    }


    /// <summary>
    /// Length of new branch (less than 1)
    /// </summary>
    public float Shrinking
    {
      get { return fShrinking; }
      set { fShrinking=value; bChanged=true; }
    }


    /// <summary>
    /// Length of first branch
    /// </summary>
    public int Size
    {
      get { return iSize; }
      set { iSize=value; bChanged=true; }
    }


    /// <summary>
    /// Get or set flake antialiasing
    /// </summary>
    public bool Antialiasing
    {
      get { return bAntialias; }
      set { bAntialias=value; bChanged=true; }
    }

    
    /// <summary>
    /// Get or set flake color
    /// </summary>
    public Color Color
    {
      get { return color; }
      set { color=value; bChanged=true; }
    }

    #endregion
    #region Methods

    /// <summary>
    /// Fotate point
    /// </summary>
    /// <param name="point">Point to rotate</param>
    /// <param name="center">Center of rotation</param>
    /// <param name="ang">Angel (in degrees)</param>
    /// <returns>Roteted point</returns>
    private PointF Rotate(PointF point,PointF center,float ang) 
    {
      ang=ang/180.0f*(float)Math.PI;
      return new PointF(
        ((point.X-center.X)*(float)Math.Cos(ang)-
        (point.Y-center.Y)*(float)Math.Sin(ang))+center.X,
        ((point.X-center.X)*(float)Math.Sin(ang)+
        (point.Y-center.Y)*(float)Math.Cos(ang))+center.Y);
    }


    /// <summary>
    /// Draw line (and save minimal/maximal position)
    /// </summary>
    /// <param name="output">Graphics</param>
    /// <param name="pn">Pen</param>
    /// <param name="start">Start point</param>
    /// <param name="end">End point</param>
    private void DrawLine(Graphics output,Pen pn,PointF start,PointF end)
    {
      if (output==null)
      {
        if (start.X<minx) minx=start.X;
        if (start.Y<miny) miny=start.Y;
        if (start.X>maxx) maxx=start.X;
        if (start.Y>maxy) maxy=start.Y;

        if (end.X<minx) minx=end.X;
        if (end.Y<miny) miny=end.Y;
        if (end.X>maxx) maxx=end.X;
        if (end.Y>maxy) maxy=end.Y;
      }
      else output.DrawLine(pn,start,end);
    }


    /// <summary>
    /// Draw branch
    /// </summary>
    /// <param name="output">Output graphics</param>
    /// <param name="start">Starting point</param>
    /// <param name="end">Ending point</param>
    /// <param name="width">Width of pen</param>
    /// <param name="depth">Branch depth</param>
    private void DrawBranch(Graphics output,PointF start,PointF end,float width,int depth)
    {
      Pen pn=new Pen(color,width);
      if (type==FlakeType.LineType) DrawLine(output,pn,start,end);
      pn.Dispose();

      PointF cnt=new PointF(start.X+(end.X-start.X)*fBranching,start.Y+(end.Y-start.Y)*fBranching);
      PointF nend=new PointF(cnt.X+(end.X-start.X)*fShrinking,cnt.Y+(end.Y-start.Y)*fShrinking);

      pn=new Pen(color,1);
      if (depth==iMaxDepth&&type==FlakeType.PointType)
      {
        DrawLine(output,pn,cnt,Rotate(nend,cnt,iBranchAngle));
        DrawLine(output,pn,cnt,Rotate(nend,cnt,-iBranchAngle));
      }
      if (depth!=iMaxDepth)
      {
        DrawBranch(output,cnt,Rotate(nend,cnt,iBranchAngle),width*0.6f,depth+1);
        DrawBranch(output,cnt,Rotate(nend,cnt,-iBranchAngle),width*0.6f,depth+1);
        if (type==FlakeType.PointType) 
        {
          DrawBranch(output,start,cnt,width*0.6f,depth+1);
          DrawBranch(output,cnt,end,width*0.6f,depth+1);
        }
      }
      pn.Dispose();
    }


    /// <summary>
    /// Restore bitmap
    /// </summary>
    /// <param name="center">Flake position</param>
    private void Restore(PointF center)
    {
      minx=maxx=center.X;
      maxy=miny=center.Y;
      bChanged=false;

      // calculate size
      PointF cnt=new PointF(center.X,center.Y);
      PointF start=new PointF(center.X,center.Y-iSize);
      for(int i=0; i<6; i++)
        DrawBranch(null,cnt,Rotate(start,cnt,i*60),2.0f,0);

      int iminx=(int)minx-2,imaxx=(int)maxx+2,
        iminy=(int)miny-2,imaxy=(int)maxy+2;
      bmpBack=new Bitmap(imaxx-iminx,imaxy-iminy);
      Graphics gr=Graphics.FromImage(bmpBack);
      if (bAntialias)
        gr.SmoothingMode=SmoothingMode.AntiAlias;
      else
        gr.SmoothingMode=SmoothingMode.None;
      cnt=new PointF(center.X-iminx,center.Y-iminy);
      start=new PointF(center.X-iminx,center.Y-iSize-iminy);
      for(int i=0; i<6; i++)
        DrawBranch(gr,cnt,Rotate(start,cnt,i*60),2.0f,0);
      gr.Dispose();    
    }


    /// <summary>
    /// Draw snow flake
    /// </summary>
    /// <param name="output">Output graphics</param>
    /// <param name="center">Center of flake</param>
    public void Draw(Graphics output,PointF center)
    {
      if (output != null)
      {
          if (bChanged||bmpBack==null) Restore(center);

          output.DrawImage(bmpBack,center.X-bmpBack.Width/2,
            center.Y-bmpBack.Height/2,bmpBack.Width,bmpBack.Height);
      }
    }


    /// <summary>
    /// Draw melting snow flake
    /// </summary>
    /// <param name="output">Output graphics</param>
    /// <param name="center">Center of flake</param>
    /// <param name="iAlpha">Alpha</param>
    public void Draw(Graphics output,PointF center,int iAlpha)
    {
      if (output != null)
      {
        if (bChanged||bmpBack==null) Restore(center);
      
          Bitmap nbmp=new Bitmap(bmpBack);
          for(int x=0; x<nbmp.Width; x++)
          {
            for(int y=0; y<nbmp.Height; y++)
            {
              Color clr=nbmp.GetPixel(x,y);
              nbmp.SetPixel(x,y,
                Color.FromArgb((int)((float)clr.A*((double)iAlpha/256.0)),clr.R,clr.G,clr.B));
            }
          }
          output.DrawImage(nbmp,center.X-bmpBack.Width/2,
            center.Y-bmpBack.Height/2,bmpBack.Width,bmpBack.Height);
          nbmp.Dispose();
      }
    }

    #endregion
}


  /// <summary>
  /// Object for drawing snow flake with random parameters
  /// </summary>
  public class RandomSnowFlake : SnowFlake
  {
    #region Members

    private Random rnd;

    /// <summary>
    /// Generate flake
    /// </summary>
    /// <param name="seed">Number for random generator</param>
    public RandomSnowFlake(int seed)
    {
      rnd=new Random(seed);
      Type=rnd.Next(2)==0?
        SnowFlake.FlakeType.LineType:SnowFlake.FlakeType.PointType;
      BranchAngle=rnd.Next(15,165);
      Branching=0.2f+(float)rnd.NextDouble()*0.6f;
      Depth=rnd.Next(4,(Type==SnowFlake.FlakeType.LineType)?8:6);
      Shrinking=0.3f+(float)rnd.NextDouble()*0.4f;

      if (Shrinking*Branching>0.36)
        if (Type==SnowFlake.FlakeType.PointType) Shrinking/=2; else Branching/=2;
      if (Shrinking*Branching<0.1)
        if (Type==SnowFlake.FlakeType.PointType) Branching*=2; else Shrinking*=2;
    }


    /// <summary>
    /// Generate flake
    /// </summary>
    /// <param name="size">Size of first branch</param>
    /// <param name="seed">Number for random generator</param>
    public RandomSnowFlake(int size,int seed) : this(seed)
    {
      Size=size;
      if (Type==SnowFlake.FlakeType.LineType)
        Depth=(int)(Math.Pow(size,0.2))+rnd.Next(4+(int)((double)size/50.0));
      else
        Depth=(int)(Math.Pow(size,0.17))+rnd.Next(3+(int)((double)size/300.0));
    }

    #endregion
  }
}