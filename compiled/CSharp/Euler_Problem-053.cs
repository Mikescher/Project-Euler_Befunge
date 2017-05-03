/* transpiled with BefunCompile v1.1.0 (c) 2015 */
public static class Program
{
private static readonly string _g = "AR+LCAAAAAAABACtUE0PwiAM/St0nRcIWhgHtxDiL2EeTLhy4qT/3fqBmy7zYHxJQ9PXPl5bBCIKBv4A8QV/0gump2x6k8ny21EuyxZHqVcdJbuBxPm+5qoUSLCxiTrV"+
                                    "J3JHKX1gbmhOjQYso1EDK9qdo3yr86yVQZ9XdwrD9FVuLpdDE+OMRd8K9JbS9vDp7+XJyhkTQ3sXNPrJwnK7h0R1J3RcaZkwFoQa/o2pZseIkMkN2vBVfJ4uRHxmpQyA"+
                                    "llxzXE5kWxapIa6IhbYwMAIAAA==";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<80&&y<7)?g[y*80+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<80&&y<7)g[y*80+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0;
        gw(9,0,1);
        gw(9,1,1);
        gw(2,0,0);
        gw(3,0,1);
    _1:
        sa(gr(3,0));

        if(gr(3,0)-100==0)goto _2;else goto _3;
    _2:
        System.Console.Out.Write(gr(2,0));
        sp();
        return;
    _3:
        sa(sp()+1L);

        sa(sr());
        gw(3,0,sp());
        sa(td(sp(),2));

        gw(4,0,sp());
        sa(gr(3,0)-(gr(4,0)*2));
    _4:
        if(sp()!=0)goto _15;else goto _5;
    _5:
        sa(gr(gr(4,0)+8,(tm(gr(3,0),2)!=0)?0:1)*2);
        gw(gr(4,0)+9,tm(gr(3,0),2),gr(gr(4,0)+8,(tm(gr(3,0),2)!=0)?0:1)*2);
    _6:
        sa((sp()>1000000)?1:0);

        t0=((gr(gr(4,0)+9,(tm(gr(3,0),2)!=0)?0:1))!=0)?0:1;

        if((((gr(gr(4,0)+8,(tm(gr(3,0),2)!=0)?0:1))!=0)?1:0)!=0)goto _7;else goto _13;
    _7:
        t0=(t0!=0)?0:1;

        if((t0)!=0)goto _8;else goto _13;
    _8:
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _9;else goto _11;
    _9:
        t0=gr(4,0)-1;
        gw(4,0,gr(4,0)-1);
        t0=(t0!=0)?0:1;

        if((t0)!=0)goto _1;else goto _10;
    _10:
        sa(sp()-(gr(3,0)-(gr(4,0)*2)));
        goto _4;
    _11:
        gw(2,0,gr(2,0)+((gr(3,0)-(gr(4,0)*2)!=0)?1:0)+1L);
        gw(gr(4,0)+9,tm(gr(3,0),2),0);
    _12:
        sp();
        goto _9;
    _13:
        gw(2,0,gr(2,0)+((gr(3,0)-(gr(4,0)*2)!=0)?1:0)+1L);
        gw(gr(4,0)+9,tm(gr(3,0),2),0);
        sp();
        goto _12;
    _15:
        sa(gr(gr(4,0)+9,(tm(gr(3,0),2)!=0)?0:1)+gr(gr(4,0)+8,(tm(gr(3,0),2)!=0)?0:1));
        gw(gr(4,0)+9,tm(gr(3,0),2),gr(gr(4,0)+9,(tm(gr(3,0),2)!=0)?0:1)+gr(gr(4,0)+8,(tm(gr(3,0),2)!=0)?0:1));
        goto _6;
}
}
