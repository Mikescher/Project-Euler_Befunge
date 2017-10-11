/* transpiled with BefunCompile v1.2.0 (c) 2017 */
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
static void Main(string[]args)
{
        long t0,t1;
        gw(2,1,1);
        gw(2,0,1);
        gw(3,0,1);
        gw(9,0,48);
        sa(0);
        sa(1);
        sa(1);
        sa(10);
    _1:
        sa(sr());
        sa(48);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(0);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+1L);
        if(sr()!=79)goto _1;else goto _3;
    _3:
        sa(49);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(0);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    _4:
        gw(4,0,79);
        gw(5,0,0);
    _5:
        t0=((gr(gr(4,0),0)-48)*gr(2,0))+gr(5,0);
        gw(gr(4,0),0,(tm(((gr(gr(4,0),0)-48)*gr(2,0))+gr(5,0),10))+48);
        t0/=10;
        gw(5,0,t0);
        t0=gr(4,0)-1;
        gw(4,0,gr(4,0)-1);
        t0-=8;
        if((t0)!=0)goto _5;else goto _7;
    _7:
        t0=gr(3,0)-1;
        gw(3,0,gr(3,0)-1);

        if((t0)!=0)goto _4;else goto _8;
    _8:
        sa(9);
        sa(gr(9,0)-48);
    _9:
        if(sp()!=0)goto _10;else goto _18;
    _10:
        t0=80;
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}

        t1=sp();

        if(t1!=gr(2,1))goto _11;else goto _16;
    _11:
        t1=t1>gr(2,1)?1:0;
        t1=(t1!=0)?0:1;

        if((t1)!=0)goto _14;else goto _12;
    _12:
        sp();
        sa(0);
    _13:
        sp();
        sp();
        System.Console.Out.Write("{0} ", (long)(sp()));
        return;
    _14:
        sa(sp()+1L);

        sa(sr());
        sa(gr(2,1));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        gw(2,0,sp());
    _15:
        gw(3,0,sp());
        gw(9,0,48);
        sa(10);
        goto _1;
    _16:
        t0=10;
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}

        sa(sr());

        if(sp()!=0)goto _17;else goto _13;
    _17:
        gw(2,2,sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+gr(2,2));

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+1L);

        sa(sr());
        sa(sr());
        gw(2,1,sp());
        gw(2,0,1);
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _15;
    _18:
        sa(sp()+1L);

        sa(sr());
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-48L);
        goto _9;
}
}
