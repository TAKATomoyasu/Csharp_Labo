using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Tri {
    void Start () {
        //  四角形の生成
        PlaneFigure b = new Box (2.0, 4.0);
        //  三角形の生成
        PlaneFigure t = new Triangle (4.0, 1.5);
        Console.WriteLine ("幅{0}、高さ{1}の四角形の面積は{2}", b.Width, b.Height, b.Area);
        Console.WriteLine ("幅{0}、高さ{1}の三角形の面積は{2}", t.Width, t.Height, t.Area);
    }
}

abstract class PlaneFigure {
    protected double area = 0;
    protected double width = 0;
    protected double height = 0;

    public PlaneFigure () {

    }
    public PlaneFigure (double width, double height) {
        this.width = width;
        this.height = height;
    }
    public double Width {
        get { return width; }
        set { width = value; }
    }
    public double Height {
        get { return height; }
        set { height = value; }
    }
    public abstract double Area {
        get;
    }
}

//  四角形クラス
class Box : PlaneFigure {
    public Box (double a, double b) : base (a, b) { }
    //  面積の取得
    public override double Area {
        get { return width * height; }
    }
}

//  三角形クラス
class Triangle : PlaneFigure {
    public Triangle (double a, double b) : base (a, b) { }
    //  面積の取得
    public override double Area {
        get { return width * height / 2.0; }
    }
}