/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABAC9jrFOxDAQRH9lsUODZdh1YomsrBV/ACWFlaNzu5WrfPzt5XQ6BFKUAjHVeLTzPB0+TQDg/0YAG+0f1KmSUmIOZK8aWioHWvibMyuOit/atRk2UFlS"+
                                    "1ZROfY9HdyvXwx/nhu2xug934/Owx5Ob4U5dUGUWdugqKgV27y6uwtgsiev68GVDS9zl3cVaxw6KGRUnIxXF6siVJYgnGHwBTtTiWp+P8RKRCkzYrnMSYHvK2ALnHB4t"+
                                    "6TKYwx7ejvFkSbjGVxvHkRpOl6kvIYPPan9MoUj2Q/ZlOYbbiDJio8gjKvjlNG/p8f5FZx340XggAwAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<80&&y<10)?g[y*80+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<80&&y<10)g[y*80+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(2L,1L,1L);
        gw(2L,0L,1L);
        gw(3L,0L,1L);
        gw(9L,0L,48L);
        sa(0L);
        sa(1L);
        sa(1L);
        sa(10L);
    _1:
        sa(sr());
        sa(48L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(0L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+1L);
        if(sr()!=79L)goto _1;else goto _3;
    _3:
        sa(49L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(0L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    _4:
        gw(4L,0L,79L);
        gw(5L,0L,0L);
    _5:
        sa(((gr(gr(4L,0L),0L)-48L)*gr(2L,0L))+gr(5L,0L));
        gw(gr(4L,0L),0L,(tm(((gr(gr(4L,0L),0L)-48L)*gr(2L,0L))+gr(5L,0L),10L))+48L);
        sa(td(sp(),10L));
        gw(5L,0L,sp());
        sa(gr(4L,0L)-1L);
        gw(4L,0L,gr(4L,0L)-1L);
        sa(sp()-8L);
        if(sp()!=0)goto _5;else goto _7;
    _7:
        sa(gr(3L,0L)-1L);
        gw(3L,0L,gr(3L,0L)-1L);
        if(sp()!=0)goto _4;else goto _8;
    _8:
        sa(9L);
        sa(gr(9L,0L)-48L);
    _9:
        if(sp()!=0)goto _10;else goto _18;
    _10:
        sa(80L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}
        if(sr()!=gr(2L,1L))goto _11;else goto _16;
    _11:
        sa((sp()>gr(2L,1L))?1:0);
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _14;else goto _12;
    _12:
        sp();
        sa(0L);
    _13:
        sp();
        sp();
        System.Console.Out.Write((long)(sp()));
        return;
    _14:
        sa(sp()+1L);
        sa(sr());
        sa(gr(2L,1L));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        gw(2L,0L,sp());
    _15:
        gw(3L,0L,sp());
        gw(9L,0L,48L);
        sa(10L);
        goto _1;
    _16:
        sp();
        sa(10L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        if(sp()!=0)goto _17;else goto _13;
    _17:
        gw(2L,2L,sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+gr(2L,2L));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+1L);
        sa(sr());
        sa(sr());
        gw(2L,1L,sp());
        gw(2L,0L,1L);
        sa(1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _15;
    _18:
        sa(sp()+1L);
        sa(sr());
        sa(0L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-48L);
        goto _9;
}}