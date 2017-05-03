/* transpiled with BefunCompile v1.1.0 (c) 2015 */
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
static void Main(string[]args)
{
        long t0,t1;
        gw(0,0,118);
        gw(1,0,20);
        gw(2,0,50);
        gw(3,0,1000);
        gw(4,0,13);
        gw(5,0,0);
        gw(6,0,0);
        gw(7,0,0);
        gw(8,0,0);
    _1:
        gw(6,0,gr(5,0));
        t0=gr(tm(gr(6,0),gr(2,0)),(td(gr(6,0),gr(2,0)))+9)-48;
    _2:
        t1=gr(6,0)+1;
        gw(6,0,gr(6,0)+1);
        t1-=gr(5,0);
        t1-=gr(4,0);

        if((t1)!=0)goto _3;else goto _4;
    _3:
        t0*=gr(tm(gr(6,0),gr(2,0)),(td(gr(6,0),gr(2,0)))+9)-48;
        goto _2;
    _4:
        if(t0>gr(8,0))goto _10;else goto _5;
    _5:
        t0=gr(5,0)+1;
        gw(5,0,gr(5,0)+1);
        t0-=gr(3,0);

        if((t0)!=0)goto _1;else goto _6;
    _6:
        gw(7,0,9);
    _7:
        System.Console.Out.Write(gr(gr(7,0),0));

        if(gr(7,0)-8!=gr(4,0))goto _9;else goto _8;
    _8:
        System.Console.Out.Write('=');
        System.Console.Out.Write(gr(8,0));
        return;
    _9:
        gw(7,0,gr(7,0)+1);
        goto _7;
    _10:
        gw(8,0,t0);
        gw(6,0,0);
    _11:
        gw(gr(6,0)+9,0,gr(tm(gr(6,0)+gr(5,0),gr(2,0)),(td(gr(6,0)+gr(5,0),gr(2,0)))+9)-48);
        t0=gr(6,0)+1;
        gw(6,0,gr(6,0)+1);
        t0-=gr(4,0);
        if((t0)!=0)goto _11;else goto _5;
}
}
