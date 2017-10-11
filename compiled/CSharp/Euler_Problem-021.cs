/* transpiled with BefunCompile v1.2.0 (c) 2017 */
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
static void Main(string[]args)
{
        long t0,t1;
        gw(1,0,400);
        gw(0,0,10000);
        sa(gr(0,0)-1);
        sa(gr(0,0)-1);
        gw(2,0,gr(0,0)-1);
    _1:
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),2));

        sa(sr());

        if(sp()!=0)goto _2;else goto _16;
    _2:
        sa(sr());
        t0=gr(2,0);
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(tm(sp(),v0));}

        t1=sp();

        if((t1)!=0)goto _15;else goto _3;
    _3:
        sa(sr());
        gw(3,0,sp());
        sa(sp()+sp());

        sa(gr(3,0)-1);
        sa(gr(3,0)-1);
    _4:
        if(sp()!=0)goto _2;else goto _5;
    _5:
        sp();
        gw(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1,sp());
    _6:
        sa(sr());

        if(sp()!=0)goto _14;else goto _7;
    _7:
        gw(0,1,0);
        gw(2,0,gr(0,0)-1);
        gw(9,0,0);
        gw(4,0,gr(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1));
        gw(5,0,gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+1));
        sp();
        sp();
    _8:
        if(gr(2,0)!=gr(5,0))goto _9;else goto _12;
    _9:
        sa(gr(2,0));
        gw(2,0,gr(2,0)-1);

        if(sp()!=0)goto _10;else goto _11;
    _10:
        gw(4,0,gr(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1));
        gw(5,0,gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+1));
        goto _8;
    _11:
        System.Console.Out.Write(gr(9,0)+" ");
        return;
    _12:
        if(gr(2,0)<=gr(4,0))goto _9;else goto _13;
    _13:
        System.Console.Out.Write(gr(2,0)+" ");
        System.Console.Out.Write(" - ");
        System.Console.Out.Write(gr(4,0)+" ");
        System.Console.Out.Write('\n');
        gw(9,0,gr(9,0)+gr(2,0)+gr(4,0));
        goto _9;
    _14:
        sa(sp()-1L);

        sa(sr());
        sa(sr());
        gw(2,0,sp());
        goto _1;
    _15:
        sa(sp()-1L);

        sa(sr());
        goto _4;
    _16:
        gw(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1,1);
        goto _6;
}
}
