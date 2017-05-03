/* transpiled with BefunCompile v1.1.0 (c) 2015 */
public static class Program
{
private static readonly string _g = "AR+LCAAAAAAABADtkc8KgzAMxl9FCl4Mzq9qVxCRPYmnQa49efLhF5ljRdmYjv055Lsk/dL0l7ZD8jths/a0KFrRila0ohWtaEUr+iNou6flz9Q5d/RZlgHBlMYiJGWF"+
                                    "0A3fQG+yp//hGgFOxqvBNpfFFMGpqQ1d08ISG5i8mSt24TswUTIkQ7s4fGU80MioA9mCYSUjm86JHB7ZMlBUSMk5mbuQ0LR9O+aZZOZscoZnQAzZxLduf+/2bYCXK1ck"+
                                    "i+rFCZ+pq8CHU2x4eR4Sxmpr/z4t0gVqKcfndA0AAA==";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<123&&y<28)?g[y*123+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<123&&y<28)g[y*123+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0,t1;
        gw(0,0,1050);
        gw(1,0,50);
        gw(3,0,2);
    _1:
        gw(4,0,gr(0,0));
        gw(5,0,0);
    _2:
        gw(4,0,gr(4,0)-1);
        t0=gr((tm(gr(4,0),gr(1,0)))+52,(td(gr(4,0),gr(1,0)))+1)-48;
        t1=(gr((tm(gr(4,0),gr(1,0)))+52,(td(gr(4,0),gr(1,0)))+1)-48)+(gr((tm(gr(4,0),gr(1,0)))+1,(td(gr(4,0),gr(1,0)))+1)-48)+gr(5,0);
        gw(5,0,td((gr((tm(gr(4,0),gr(1,0)))+52,(td(gr(4,0),gr(1,0)))+1)-48)+(gr((tm(gr(4,0),gr(1,0)))+1,(td(gr(4,0),gr(1,0)))+1)-48)+gr(5,0),10));
        t1%=10;
        t1+=48;
        gw((tm(gr(4,0),gr(1,0)))+52,(td(gr(4,0),gr(1,0)))+1,t1);
        t0+=48;
        gw((tm(gr(4,0),gr(1,0)))+1,(td(gr(4,0),gr(1,0)))+1,t0);
        if((gr(4,0))!=0)goto _2;else goto _4;
    _4:
        gw(3,0,gr(3,0)+1);
        gw(7,0,0);
    _5:
        if(gr((tm(gr(7,0),gr(1,0)))+52,(td(gr(7,0),gr(1,0)))+1)!=48)goto _7;else goto _6;
    _6:
        gw(7,0,gr(7,0)+1);
        goto _5;
    _7:
        if(gr(0,0)-gr(7,0)!=1000)goto _1;else goto _8;
    _8:
        System.Console.Out.Write(gr(3,0));
        return;
}
}
