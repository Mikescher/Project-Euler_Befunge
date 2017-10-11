/* transpiled with BefunCompile v1.2.0 (c) 2017 */
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
static void Main(string[]args)
{
        long t0;
        gw(63,2,0);
        sa(99);
        sa(99);
        sa(99);
    _1:
        sa(197);
    _2:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((tm(sr(),70))+5);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),70));

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());

        if(sp()!=0)goto _18;else goto _3;
    _3:
        gw(64,2,1);
        gw(2,0,0);
        sp();
        gw(1,0,sp());
    _4:
        gw(3,0,0);
        sa(199);
        sa(199);
        sa((gr(64,2)*gr(1,0))+gr(2,0));
        gw(2,0,td((gr(64,2)*gr(1,0))+gr(2,0),10));
    _5:
        sa(tm(sp(),10));

        t0=sr()+gr(3,0);
        gw(3,0,t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((tm(sr(),70))+5);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),70));

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());

        if(sp()!=0)goto _17;else goto _6;
    _6:
        sp();

        if(gr(3,0)>gr(2,1))goto _16;else goto _7;
    _7:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _4;else goto _8;
    _8:
        sp();
    _9:
        sa(sp()-1L);

        sa(sr());
    _10:
        if(sp()!=0)goto _12;else goto _11;
    _11:
        System.Console.Out.Write(gr(2,1)+" ");
        sp();
        return;
    _12:
        if(tm(sr(),10)!=0)goto _14;else goto _13;
    _13:
        sa(sp()-1L);

        sa(sr());
        goto _10;
    _14:
        if(sr()>45)goto _15;else goto _9;
    _15:
        gw(63,2,0);
        sa(sr());
        sa(99);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _1;
    _16:
        gw(2,1,gr(3,0));
        goto _7;
    _17:
        sa(sp()-1L);

        sa(sr());
        sa(sr());
        sa((tm(sr(),70))+5);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),70));

        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()*gr(1,0));

        sa(sp()+gr(2,0));

        t0=td(sr(),10);
        gw(2,0,t0);
        goto _5;
    _18:
        sa(sp()-1L);
        goto _2;
}
}
