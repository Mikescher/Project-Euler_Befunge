/* transpiled with BefunCompile v1.2.0 (c) 2017 */
public static class Program
{
private static readonly string _g = "AR+LCAAAAAAABADtVLsOgzAM/JU0gaWIchYEQVRF/ZAKOlTymikT/fe6MICqqFs7VJyU2HL8uMvgqL4Ps2PHjr/HD1aJ8vqugaAfuju2COjk9AhvCyeqmGATCqoYYDT5"+
                                    "Yhj2nJrRgr2rEbwjuXCV5Jzwqqmip0ZGWok3CmxtcazlVWIWTIXEmzkxX0xFBR+mtJIOfLos/hRAzpXEICG55RRFIqMWkWM0N0bvSk7IUCkdwziYgHbu2ypvVLb5lGH1"+
                                    "19os1eYjnvF4IR1ABgAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<100&&y<16)?g[y*100+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<100&&y<16)g[y*100+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0;
        gw(0,0,100);
        gw(6,0,1000);
        gw(8,0,0);
        gw(9,0,0);
    _1:
        t0=gr(6,0)-1;
        gw(6,0,gr(6,0)-1);

        if((t0)!=0)goto _3;else goto _2;
    _2:
        System.Console.Out.Write(gr(8,0)+" ");
        return;
    _3:
        sa(gr(6,0));
        gw(3,0,gr(6,0));
        sa(sr());
        gw(1,0,sp());
    _4:
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sp(),gr(0,0)));

        sa((td(gr(1,0),gr(0,0)))+1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(gr(1,0)-1);
        t0=gr(1,0)-1;
        gw(1,0,gr(1,0)-1);
        if((t0)!=0)goto _4;else goto _6;
    _6:
        gw(4,0,1);
        gw(5,0,0);
        gw(4,0,tm(gr(4,0)*10,gr(3,0)));
        gw(5,0,gr(5,0)+1);
        sp();
    _7:
        if((gr(tm(gr(4,0),gr(0,0)),(td(gr(4,0),gr(0,0)))+1))==0)goto _10;else goto _8;
    _8:
        t0=gr(5,0)-gr(tm(gr(4,0),gr(0,0)),(td(gr(4,0),gr(0,0)))+1);

        if((gr(5,0)-gr(tm(gr(4,0),gr(0,0)),(td(gr(4,0),gr(0,0)))+1))>gr(9,0))goto _9;else goto _1;
    _9:
        gw(9,0,t0);
        gw(8,0,gr(3,0));
        goto _1;
    _10:
        gw(tm(gr(4,0),gr(0,0)),(td(gr(4,0),gr(0,0)))+1,gr(5,0));
        gw(4,0,tm(gr(4,0)*10,gr(3,0)));
        gw(5,0,gr(5,0)+1);
        goto _7;
}
}
