/* compiled with BefunCompile v1.0.4 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABACdUDGOAyEM/AqBrVgRMbtc7oKQdQ+xNlesREuFUvD4mCVpI+WmsEdG4xlcPZY1fF2+f67qY5De911bi/q5VtWC5VoAl/4hfgWoNKxHTU/SN9LgxHBc"+
                                    "j2lBmJEREi3IEXOj1plninDRbLeJLB89NhGuKApBirAckC2Q/07t6Ty9CTVhk9acvmuVfeTESOI7cnX89nTvUI93wsw9CsZwk4M5+cDSj2Y7CxlrBs7Fs3ix016LHxmn"+
                                    "DJSZlBHDbYgfFCr43OgBAAA=";
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
static void Main(string[] args)
{
        goto _4;
    _0:
        if(sp()!=0)goto _6; else goto _18;
    _1:
        if(sp()!=0)goto _7; else goto _8;
    _2:
        if(sp()!=0)goto _9; else goto _21;
    _3:
        if(sp()!=0)goto _16; else goto _19;
    _4:
        gw(1,1,999999);
        gw(2,1,9);
        goto _20;
    _5:
        sp();
        return;
    _6:
        sa(0);
        sa(gr(2,1));
        sa((gr(2,1))-(1));
        sa((gr(2,1))-(1));
        goto _1;
    _7:
        sa(sr());
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _1;
    _8:
        sp();
        goto _9;
    _9:
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _2;
    _10:
        gw(3,1,1);
        gw(4,1,1);
        sp();
        goto _22;
    _11:
        gw(4,1,(gr(4,1))+(1));
        goto _22;
    _12:
        sa(gr(4,1));
        goto _13;
    _13:
        sa(1);
        sa((gr(1,0))-(120));
        goto _3;
    _14:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(120);
        {long v0=sp();sa(sp()-v0);}
        goto _3;
    _15:
        sp();
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(48);
        {long v0=sp();sa(sp()-v0);}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(120);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(0);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        gw(1,1,(gr(1,1))-((gr(3,1))*((gr(4,1))-(1))));
        gw(2,1,(gr(2,1))-(1));
        System.Console.Out.Write((long)(sp()));
        goto _20;
    _16:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _19;
    _17:
        gw(3,1,sp());
        gw(4,1,1);
        goto _22;
    _18:
        sa(1);
        goto _13;
    _19:
        sa(1);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        if(sp()!=0)goto _14; else goto _15;
    _20:
        sa(gr(2,1));
        if(((gr(2,1))+(1))!=0)goto _0;else goto _5;
    _21:
        sp();
        sa(sr());
        if(sp()!=0)goto _17; else goto _10;
    _22:
        sa(((((gr(3,1))*(gr(4,1)))>(gr(1,1))?1:0)!=0)?0:1);
        if(sp()!=0)goto _11; else goto _12;
}}