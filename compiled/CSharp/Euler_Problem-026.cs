/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
static void Main(string[] args)
{
        gw(0L,0L,100L);
        gw(6L,0L,1000L);
        gw(8L,0L,0L);
        gw(9L,0L,0L);
    _1:
        sa(gr(6L,0L)-1L);
        gw(6L,0L,gr(6L,0L)-1L);
        if(sp()!=0)goto _3;else goto _2;
    _2:
        System.Console.Out.Write((long)(gr(8L,0L)));
        return;
    _3:
        sa(gr(6L,0L));
        gw(3L,0L,gr(6L,0L));
        sa(sr());
        gw(1L,0L,sp());
    _4:
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sp(),gr(0L,0L)));
        sa((td(gr(1L,0L),gr(0L,0L)))+1L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(gr(1L,0L)-1L);
        sa(gr(1L,0L)-1L);
        gw(1L,0L,gr(1L,0L)-1L);
        if(sp()!=0)goto _4;else goto _6;
    _6:
        gw(4L,0L,1L);
        gw(5L,0L,0L);
        gw(4L,0L,tm(gr(4L,0L)*10L,gr(3L,0L)));
        gw(5L,0L,gr(5L,0L)+1L);
        sp();
    _7:
        if((gr(tm(gr(4L,0L),gr(0L,0L)),(td(gr(4L,0L),gr(0L,0L)))+1L))==0)goto _11;else goto _8;
    _8:
        sa(gr(5L,0L)-gr(tm(gr(4L,0L),gr(0L,0L)),(td(gr(4L,0L),gr(0L,0L)))+1L));
        if((gr(5L,0L)-gr(tm(gr(4L,0L),gr(0L,0L)),(td(gr(4L,0L),gr(0L,0L)))+1L))>gr(9L,0L))goto _9;else goto _10;
    _9:
        gw(9L,0L,sp());
        gw(8L,0L,gr(3L,0L));
        goto _1;
    _10:
        sp();
        goto _1;
    _11:
        gw(tm(gr(4L,0L),gr(0L,0L)),(td(gr(4L,0L),gr(0L,0L)))+1L,gr(5L,0L));
        gw(4L,0L,tm(gr(4L,0L)*10L,gr(3L,0L)));
        gw(5L,0L,gr(5L,0L)+1L);
        goto _7;
}}