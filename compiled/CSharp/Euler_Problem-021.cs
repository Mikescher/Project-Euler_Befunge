/* compiled with BefunCompile v1.0.4 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABADt2r1qwzAQwPFXcf2xWP44OdIQEUQfJDQdClo1acrD54JLoLSQ0jY0tP/fcqeTrEFGN6lUuCcNAAAAAAAAAAAAAAAAAAB/wLX3cuU1xsvKcs52t3qf"+
                                    "99/F+qV2fbCSve97kSySoh1DWDTdL3PUJO275ukQNpLNZp3VYVuub44fcQwfFLOxcxKbZOnWwBW5hdK2b8bZinDSvydqf7LjuTltJUftTVZSt4bZmuQku7XmLjUvudIV"+
                                    "XtLYlINmOvX8sKZTXY1VPQyD1ibvzUBX+4ZjlmW0QZvRZ7/YvU/1zxqTxOkuSbbcta95nDi8e3ACPGJLlpAzAAA=";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<400&&y<33)?g[y*400+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<400&&y<33)g[y*400+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        goto _2;
    _0:
        if(sp()!=0)goto _11; else goto _12;
    _1:
        if(((gr(2,0))-(gr(5,0)))!=0)goto _13;else goto _14;
    _2:
        gw(1,0,400);
        gw(0,0,10000);
        sa((gr(0,0))-(1));
        sa((gr(0,0))-(1));
        gw(2,0,(gr(0,0))-(1));
        goto _3;
    _3:
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        goto _11;
    _4:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _0;
    _5:
        gw(0,1,0);
        gw(2,0,(gr(0,0))-(1));
        gw(9,0,0);
        gw(4,0,gr(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+(1)));
        gw(5,0,gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(1)));
        sp();
        sp();
        goto _1;
    _6:
        System.Console.Out.Write((long)(gr(2,0)));
        sa(32);
        sa(45);
        System.Console.Out.Write((char)(32));
        System.Console.Out.Write((char)(sp()));
        System.Console.Out.Write((char)(sp()));
        System.Console.Out.Write((long)(gr(4,0)));
        System.Console.Out.Write((char)(10));
        gw(9,0,(gr(9,0))+((gr(2,0))+(gr(4,0))));
        goto _13;
    _7:
        System.Console.Out.Write((long)(gr(9,0)));
        return;
    _8:
        gw(4,0,gr(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+(1)));
        gw(5,0,gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(1)));
        goto _1;
    _9:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(sr());
        gw(2,0,sp());
        goto _3;
    _10:
        sa(sr());
        gw(3,0,sp());
        sa(sp()+sp());
        sa((gr(3,0))-(1));
        sa((gr(3,0))-(1));
        goto _0;
    _11:
        sa(sr());
        sa(gr(2,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        if(sp()!=0)goto _4; else goto _10;
    _12:
        sp();
        gw(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+(1),sp());
        sa(sr());
        if(sp()!=0)goto _9; else goto _5;
    _13:
        sa(gr(2,0));
        gw(2,0,(gr(2,0))-(1));
        if(sp()!=0)goto _8; else goto _7;
    _14:
        sa((((gr(2,0))>(gr(4,0))?1:0)!=0)?0:1);
        if(sp()!=0)goto _13; else goto _6;
}}