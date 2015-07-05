/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABADtl81uG0cQhF+FYOyLGDv9O90txEIeJFBy45UnPX++kS0gAYw49vKYAYYL7nC3pqurasDzy1nklvHwqFzSHh4eTW4PLrfOS8hNkrmYxWy5nRgvp2Pj"+
                                    "SVOuvPNpyRW06/vf+fhlLteznD88cFMvjyzzow/B/Onlj8eW659c3z3l6yqb8s8rp2Fjp6eSq1w/8tlvj5w/nX/mqY+//RP7+T/u8Vfmu+975Guv+KHx1J853/xQ7+XR"+
                                    "Tl9IOr2xxMpc5LZOb2R9qfr5Rzb79Y2+3X2m9xe9Sv37zw+M797z3Xfw//j7KNdVWitd3WVZjI5Zqs6qCFtZUWGe6XslxuM45qxpTxNXq4qU5bbMJ6tdW5TV4NJrorpT"+
                                    "O/w4ZmcvzSXVo2oUEpORk6LlNdnuOmmdbtItCQHHMdUyhGqgULPTvJeTsXxZ4zYyFA6oQbRLwHF9+53fGmv1rBVNZRFpe9JhitTOFeLCdhQGtIz9uOoduF1mNo00zL2B"+
                                    "aPV0X1ZraVhbywpGs69NQsUcx3Tx7JGyWTCJNulthFQhJBj2VslN+rjULAH7OGYhFgsr2Ov2gcmpET53C8d0tnantoJaxqvugIkBrRxrCgVBKo5QM8GRwS5kKrfK0Fni"+
                                    "FrR0D6+kZQcsIpRVeGGJOuxSMiaK4B7CjVC2ZkoyzB10m76mWmG0OtArxsGhqfAKxcteLaOzF/lm0XYck4KoINQroVmok7QbMVSLaLa0emEhjfRUEYLwDpima3nBJmol"+
                                    "c/CNCIIhB8J3FqLZoMOVjWYX3T6OqWuLtjRqhr6FDabEpstjJTGPX8l23UHBQtDkO2DWq93JeV4cuSASgS6kuggE8kkNDxEPRPKCgrhDP/EmHjTjQNuqNVSqe2wvSlK3"+
                                    "FgRPKCSTCSF9HJOs4bgS7yTOKRSYIPoGl75mbW/OSQ1yEGkNwXEcs+FVCDyURADs1pG7lQGSCDrCnpwCMLzPO852uUM/ZeuRPIhN7sQ+xkDEFbatSSf5P4GQk8AlFjBP"+
                                    "HscspRBbQ6XddFX2YUJ9TRoJCras5OA0Ifg4S3HPccy/AFjBplkkDQAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<116&&y<29)?g[y*116+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<116&&y<29)g[y*116+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(0L,0L,118L);
        gw(1L,0L,20L);
        gw(2L,0L,50L);
        gw(3L,0L,1000L);
        gw(4L,0L,13L);
        gw(5L,0L,0L);
        gw(6L,0L,0L);
        gw(7L,0L,0L);
        gw(8L,0L,0L);
    _1:
        gw(6L,0L,gr(5L,0L));
        sa(gr(tm(gr(6L,0L),gr(2L,0L)),(td(gr(6L,0L),gr(2L,0L)))+9L)-48L);
    _2:
        sa(gr(6L,0L)+1L);
        gw(6L,0L,gr(6L,0L)+1L);
        sa(sp()-gr(5L,0L));
        sa(sp()-gr(4L,0L));
        if(sp()!=0)goto _3;else goto _4;
    _3:
        sa(sp()*(gr(tm(gr(6L,0L),gr(2L,0L)),(td(gr(6L,0L),gr(2L,0L)))+9L)-48L));
        goto _2;
    _4:
        if(sr()>gr(8L,0L))goto _11;else goto _5;
    _5:
        sp();
    _6:
        sa(gr(5L,0L)+1L);
        gw(5L,0L,gr(5L,0L)+1L);
        sa(sp()-gr(3L,0L));
        if(sp()!=0)goto _1;else goto _7;
    _7:
        gw(7L,0L,9L);
    _8:
        System.Console.Out.Write((long)(gr(gr(7L,0L),0L)));
        if(gr(7L,0L)-8L!=gr(4L,0L))goto _10;else goto _9;
    _9:
        System.Console.Out.Write('=');
        System.Console.Out.Write((long)(gr(8L,0L)));
        return;
    _10:
        gw(7L,0L,gr(7L,0L)+1L);
        goto _8;
    _11:
        gw(8L,0L,sp());
        gw(6L,0L,0L);
    _12:
        gw(gr(6L,0L)+9L,0L,gr(tm(gr(6L,0L)+gr(5L,0L),gr(2L,0L)),(td(gr(6L,0L)+gr(5L,0L),gr(2L,0L)))+9L)-48L);
        sa(gr(6L,0L)+1L);
        gw(6L,0L,gr(6L,0L)+1L);
        sa(sp()-gr(4L,0L));
        if(sp()!=0)goto _12;else goto _6;
}}