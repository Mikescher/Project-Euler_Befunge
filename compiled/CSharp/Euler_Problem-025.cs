/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
static void Main(string[] args)
{
        gw(0L,0L,1050L);
        gw(1L,0L,50L);
        gw(3L,0L,2L);
    _1:
        gw(4L,0L,gr(0L,0L));
        gw(5L,0L,0L);
    _2:
        gw(4L,0L,gr(4L,0L)-1L);
        sa(gr((tm(gr(4L,0L),gr(1L,0L)))+52L,(td(gr(4L,0L),gr(1L,0L)))+1L)-48L);
        sa((gr((tm(gr(4L,0L),gr(1L,0L)))+52L,(td(gr(4L,0L),gr(1L,0L)))+1L)-48L)+(gr((tm(gr(4L,0L),gr(1L,0L)))+1L,(td(gr(4L,0L),gr(1L,0L)))+1L)-48L)+gr(5L,0L));
        gw(5L,0L,td((gr((tm(gr(4L,0L),gr(1L,0L)))+52L,(td(gr(4L,0L),gr(1L,0L)))+1L)-48L)+(gr((tm(gr(4L,0L),gr(1L,0L)))+1L,(td(gr(4L,0L),gr(1L,0L)))+1L)-48L)+gr(5L,0L),10L));
        sa(tm(sp(),10L));
        sa(sp()+48L);
        gw((tm(gr(4L,0L),gr(1L,0L)))+52L,(td(gr(4L,0L),gr(1L,0L)))+1L,sp());
        sa(sp()+48L);
        gw((tm(gr(4L,0L),gr(1L,0L)))+1L,(td(gr(4L,0L),gr(1L,0L)))+1L,sp());
        if((gr(4L,0L))!=0)goto _2;else goto _4;
    _4:
        gw(3L,0L,gr(3L,0L)+1L);
        gw(7L,0L,0L);
    _5:
        if(gr((tm(gr(7L,0L),gr(1L,0L)))+52L,(td(gr(7L,0L),gr(1L,0L)))+1L)!=48L)goto _7;else goto _6;
    _6:
        gw(7L,0L,gr(7L,0L)+1L);
        goto _5;
    _7:
        if(gr(0L,0L)-gr(7L,0L)!=1000L)goto _1;else goto _8;
    _8:
        System.Console.Out.Write((long)(gr(3L,0L)));
        return;
}}