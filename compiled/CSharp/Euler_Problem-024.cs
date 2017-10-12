/* transpiled with BefunCompile v1.2.0 (c) 2017 */
public static class Program
{
private static readonly string _g = "AR+LCAAAAAAABACdUDGOAyEM/AoHW7FBYna5XIKQdQ9B3BUr0VJZKXj8mZAUKXMuzGA8nsHsse3h8/x1uaq3g/RxHNpa8PtcxQ3btQEu/YP8NMA0pWdODzAm0sSU4TLf"+
                                    "qw1hRUVItKFGrJ36QD5ThIum/DDZPM4ldiHuaApBkqAaUC1Qfz/6Q3l59bFAFZFs54tluRSpdadvWlUfc8pIojt9jfge7p5hijfJsDenVZk05/L9nbDmYQWzscjCnHxg"+
                                    "G0uzA4WKvQIqlSxa2WmvRY+MUwbKLDJOWJP8B/NXo/XoAQAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<61&&y<8)?g[y*61+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<61&&y<8)g[y*61+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0;
        gw(1,1,999999);
        gw(2,1,9);
    _1:
        t0=gr(2,1);

        if((gr(2,1)+1)!=0)goto _3;else goto _2;
    _2:
        return;
    _3:
        if((t0)!=0)goto _11;else goto _4;
    _4:
        sa(1);
    _5:
        sa(1);
        sa(gr(1,0)-120);
    _6:
        if(sp()!=0)goto _10;else goto _7;
    _7:
        sa(sp()+1L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());

        if(sp()!=0)goto _9;else goto _8;
    _8:
        sp();
        sa(sp()-1L);

        sa(sr());
        sa(0);
        {long v0=sp();t0=gr(sp(),v0);}
        t0-=48;
        sa(120);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(0);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        t0+=48;
        System.Console.Out.Write((char)(t0));
        gw(1,1,gr(1,1)-(gr(3,1)*(gr(4,1)-1)));
        gw(2,1,gr(2,1)-1);
        goto _1;
    _9:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-120L);
        goto _6;
    _10:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _7;
    _11:
        sa(0);
        sa(gr(2,1));
        sa(gr(2,1)-1);
        sa(gr(2,1)-1);
    _12:
        if(sp()!=0)goto _22;else goto _13;
    _13:
        sp();
        sa(sp()*1L);
    _14:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());

        if(sp()!=0)goto _21;else goto _15;
    _15:
        sp();
        sa(sr());

        if(sp()!=0)goto _16;else goto _20;
    _16:
        gw(3,1,sp());
        gw(4,1,1);
    _17:
        if((gr(3,1)*gr(4,1))<=gr(1,1))goto _19;else goto _18;
    _18:
        sa(gr(4,1));
        goto _5;
    _19:
        gw(4,1,gr(4,1)+1);
        goto _17;
    _20:
        gw(3,1,1);
        gw(4,1,1);
        sp();
        goto _17;
    _21:
        sa(sp()*sp());
        goto _14;
    _22:
        sa(sr()-1);
        sa(sr());
        goto _12;
}
}
