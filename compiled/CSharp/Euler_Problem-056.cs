/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABACtkbEKwyAQhl9FNC6RNKdBSI8gnQrtE2QQU+jg6uQU8uzV0rRTBou3nAf63fdjnOeZsCpFKqJyVUTVKbMf6JNGQpaY4Y/2rHEqRUVBbxudbCJ9HxvU"+
                                    "WvC12Ep2CBbplfK4zyt2kpBiqxVDnzhWaDJdTl42TDXFkI9VI8exVQEUBAnBwACBbncqsh6+bbWwqfVegm8VeJHj9/GIp2RIH5Czud3pp8tTQxtgEB4G5ELrtPjI3KU7"+
                                    "i2MPLw0jjqk0/pHyBanoFos5AwAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<75&&y<11)?g[y*75+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<75&&y<11)g[y*75+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(63L,2L,0L);
        sa(99L);
        sa(99L);
        sa(99L);
    _1:
        sa(197L);
    _2:
        sa(sr());
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((tm(sr(),70L))+5L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),70L));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        if(sp()!=0)goto _17;else goto _3;
    _3:
        gw(64L,2L,1L);
        gw(2L,0L,0L);
        sp();
        gw(1L,0L,sp());
    _4:
        gw(3L,0L,0L);
        sa(199L);
        sa(199L);
        sa((gr(64L,2L)*gr(1L,0L))+gr(2L,0L));
        gw(2L,0L,td((gr(64L,2L)*gr(1L,0L))+gr(2L,0L),10L));
    _5:
        sa(tm(sp(),10L));
        sa(sr()+gr(3L,0L));
        gw(3L,0L,sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((tm(sr(),70L))+5L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),70L));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        if(sp()!=0)goto _16;else goto _6;
    _6:
        sp();
        if(gr(3L,0L)>gr(2L,1L))goto _15;else goto _7;
    _7:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _4;else goto _8;
    _8:
        sp();
    _9:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _11;else goto _10;
    _10:
        sp();
        System.Console.Out.Write((long)(gr(2L,1L)));
        return;
    _11:
        if(tm(sr(),10L)!=0)goto _13;else goto _12;
    _12:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _11;else goto _10;
    _13:
        if(sr()>45L)goto _14;else goto _9;
    _14:
        gw(63L,2L,0L);
        sa(sr());
        sa(99L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _1;
    _15:
        gw(2L,1L,gr(3L,0L));
        goto _7;
    _16:
        sa(sp()-1L);
        sa(sr());
        sa(sr());
        sa((tm(sr(),70L))+5L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),70L));
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()*gr(1L,0L));
        sa(sp()+gr(2L,0L));
        sa(td(sr(),10L));
        gw(2L,0L,sp());
        goto _5;
    _17:
        sa(sp()-1L);
        goto _2;
}}