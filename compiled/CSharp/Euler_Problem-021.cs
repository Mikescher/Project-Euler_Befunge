/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABADt2slqwzAQgOFXcb1cIi8jxzpEBNEHCUkPBV110skPnwmmgdCWlDaB0PzfRaPRgpDxnJQLPJIKAAAAAAAAAAAAAAAAAIB/4OqDuZA/gvPcfIq2d3qg"+
                                    "9+RC+V5OK28lObdaiSSRGGzn/ajhbhz8HDSMu6baH/xaklkv49qt8/XtcQOz/zKdjB2i2ChjszT8IreX6/qin6zIxT0H++3a/X2O9NSC1ifbnYrTRlLQymQlNkszWBMn"+
                                    "SdOSm845J6nQGU5iV+WDRjr09rKEfVl0Rdm2reZ650xLTfuDOcnYWa+l6Kcrtp9D/bLGRJl0lygbatrvvPZc3iM4ApHVms+QMwAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<400&&y<33)?g[y*400+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<400&&y<33)g[y*400+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(1L,0L,400L);
        gw(0L,0L,10000L);
        sa(gr(0L,0L)-1L);
        sa(gr(0L,0L)-1L);
        gw(2L,0L,gr(0L,0L)-1L);
    _1:
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),2L));
        sa(sr());
        if(sp()!=0)goto _2;else goto _16;
    _2:
        sa(sr());
        sa(gr(2L,0L));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(tm(sp(),v0));}
        if(sp()!=0)goto _15;else goto _3;
    _3:
        sa(sr());
        gw(3L,0L,sp());
        sa(sp()+sp());
        sa(gr(3L,0L)-1L);
        sa(gr(3L,0L)-1L);
    _4:
        if(sp()!=0)goto _2;else goto _5;
    _5:
        sp();
        gw(tm(gr(2L,0L),gr(1L,0L)),(td(gr(2L,0L),gr(1L,0L)))+1L,sp());
    _6:
        sa(sr());
        if(sp()!=0)goto _14;else goto _7;
    _7:
        gw(0L,1L,0L);
        gw(2L,0L,gr(0L,0L)-1L);
        gw(9L,0L,0L);
        gw(4L,0L,gr(tm(gr(2L,0L),gr(1L,0L)),(td(gr(2L,0L),gr(1L,0L)))+1L));
        gw(5L,0L,gr(tm(gr(4L,0L),gr(1L,0L)),(td(gr(4L,0L),gr(1L,0L)))+1L));
        sp();
        sp();
    _8:
        if(gr(2L,0L)!=gr(5L,0L))goto _9;else goto _12;
    _9:
        sa(gr(2L,0L));
        gw(2L,0L,gr(2L,0L)-1L);
        if(sp()!=0)goto _10;else goto _11;
    _10:
        gw(4L,0L,gr(tm(gr(2L,0L),gr(1L,0L)),(td(gr(2L,0L),gr(1L,0L)))+1L));
        gw(5L,0L,gr(tm(gr(4L,0L),gr(1L,0L)),(td(gr(4L,0L),gr(1L,0L)))+1L));
        goto _8;
    _11:
        System.Console.Out.Write((long)(gr(9L,0L)));
        return;
    _12:
        if(gr(2L,0L)<=gr(4L,0L))goto _9;else goto _13;
    _13:
        System.Console.Out.Write((long)(gr(2L,0L)));
        sa(32L);
        sa(45L);
        System.Console.Out.Write(' ');
        System.Console.Out.Write((char)(sp()));
        System.Console.Out.Write((char)(sp()));
        System.Console.Out.Write((long)(gr(4L,0L)));
        gw(9L,0L,gr(9L,0L)+gr(2L,0L)+gr(4L,0L));
        System.Console.Out.Write('\n');
        goto _9;
    _14:
        sa(sp()-1L);
        sa(sr());
        sa(sr());
        gw(2L,0L,sp());
        goto _1;
    _15:
        sa(sp()-1L);
        sa(sr());
        goto _4;
    _16:
        gw(tm(gr(2L,0L),gr(1L,0L)),(td(gr(2L,0L),gr(1L,0L)))+1L,1L);
        goto _6;
}}