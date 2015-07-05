/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "Ah+LCAAAAAAABACT7+ZgAAEWhrfXHLOvOEg0PNxvdObW6ba3dTfvKrRsqvj47uLhTbqvjAK0ZLveZdbvEd4b4bo6IKr1uSKPj5HnDOeKYp/JT4327ty9127P/ylx9fss"+
                                    "7yw9alJfXvxjRpzaA3tzZoZBBh54LjleUpNx8OjifXw/jG//UeR3Npf/veL1nlOfC0VL5QLDX6+wfGr469Z25VMGZZ/3SS/698E0P3jLUk2zwO2vNWrNt2VWx1je3pp4"+
                                    "s1x1/9nu/Gx///2ODx6y/H9TN0X/++bVQq+FJur5bX09XfXX3UjpY2Vm7nFXbvTExicFJ10oruC7fSVrdlT7fv2C3M8mR3d6J3dp7F69Pjv9+Gnx/V5lWSftfMXPx9u+"+
                                    "rmvYv3G/+PO7X/jvF+35f1Y2i/f/Mv3FHVz7ExKZGADdxMcoswEAAA==";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<1000&&y<156)?g[y*1000+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<1000&&y<156)g[y*1000+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(1L,0L,1000L);
        gw(2L,0L,150L);
        gw(0L,0L,150000L);
        gw(3L,0L,2L);
        gw(0L,1L,32L);
        gw(1L,1L,32L);
        gw(5L,0L,(gr(1L,0L)*10L)+1L);
    _1:
        gw(tm(gr(3L,0L),gr(1L,0L)),(td(gr(3L,0L),gr(1L,0L)))+1L,88L);
        sa(gr(3L,0L)+gr(3L,0L));
        sa((gr(3L,0L)+gr(3L,0L))<gr(0L,0L)?1:0);
    _2:
        if(sp()!=0)goto _12;else goto _3;
    _3:
        sp();
    _4:
        sa(gr(3L,0L)+1L);
        gw(3L,0L,gr(3L,0L)+1L);
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+1L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-32L);
        if(sp()!=0)goto _6;else goto _4;
    _6:
        if(gr(0L,0L)>gr(3L,0L))goto _1;else goto _7;
    _7:
        gw(3L,0L,0L);
        gw(4L,0L,0L);
    _8:
        sa(gr(3L,0L)+1L);
        gw(3L,0L,gr(3L,0L)+1L);
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+1L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-88L);
        if(sp()!=0)goto _8;else goto _10;
    _10:
        sa(gr(5L,0L));
        sa(gr(4L,0L)+1L);
        gw(4L,0L,gr(4L,0L)+1L);
        gw(tm(gr(3L,0L),gr(1L,0L)),(td(gr(3L,0L),gr(1L,0L)))+1L,48L);
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _8;else goto _11;
    _11:
        System.Console.Out.Write((long)(gr(3L,0L)));
        return;
    _12:
        sa(sr());
        sa(32L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+1L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+gr(3L,0L));
        sa(sr()<gr(0L,0L)?1:0);
        goto _2;
}}