/* compiled with BefunCompile v1.0.3 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABACtk7FygzAMQH/FQLpEcU8WEDBHff2MDrkkm1dPnvj4ynYAtyVtL60GnZAt6UkW/m0W8bD4f8jxH2I0kkNFTpsBT8r5P2WbTlINYnyEQ5FtWziIaidK"+
                                    "8VIeDuJZvP4y2DtCLjpdtSUMjgcIxo0os8NlHkbcH41BJIu2xFIqJ7xZvgZ9nfh4IHLcnJyEIbLKxqDKX0S6qMtrUZ0vS7qq+lTLKDivtSapHRGowRKNoXWpuG2HrICL"+
                                    "stexg9Toiyv78DetZ8IJISQcA8d3YkTO7y8bV5gafiyfZcznWL6V4ctxDsVHXIBP3UYU1rzBvL0xrg5r5HmbnPlIYlMBsloWrPuoO1kALLPmwZ54rI5q2MO4AU5Bba7B"+
                                    "MkKzY4LhOawyb/T5602cOY6yS8h8d98nE4Ktb3av4QkKbwB4OT5MOqb1BR+3Pcjw5tjvQ2yyu2An8yjb8JTgeZpOJV/YibESM0cj25XjmHHc8KDpIgfEtXasFKSHSN1F"+
                                    "jg5vtY8ZR7tyNLKOHHcfnizJeuVoMo4bHmCbOO7kiBz1zNFkHPXKQfFf+ZaDf6eVgzKOeuagwGE23pblHVzPp+QcBgAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<68&&y<23)?g[y*68+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<68&&y<23)g[y*68+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static readonly System.Random r = new System.Random();
private static bool rd(){ return r.Next(2)!=0; }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        goto _12;
    _0:
        if(sp()!=0)goto _13; else goto _14;
    _1:
        if(sp()!=0)goto _17; else goto _34;
    _2:
        if(sp()!=0)goto _29; else goto _18;
    _3:
        if(sp()!=0)goto _30; else goto _31;
    _4:
        if(sp()!=0)goto _29; else goto _18;
    _5:
        if(sp()!=0)goto _19; else goto _20;
    _6:
        if(sp()!=0)goto _22; else goto _26;
    _7:
        if(sp()!=0)goto _11; else goto _23;
    _8:
        if(sp()!=0)goto _24; else goto _25;
    _9:
        if(sp()!=0)goto _27; else goto _28;
    _10:
        if(sp()!=0)goto _32; else goto _33;
    _11:
        if(((gr(0,2))>(9)?1:0)!=0)goto _15;else goto _16;
    _12:
        gw(0,2,9);
        gw(1,2,0);
        gw(9,1,0);
        sa(8);
        sa(9);
        goto _0;
    _13:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _0;
    _14:
        sp();
        goto _11;
    _15:
        sa(gr(1,2));
        System.Console.Out.Write((char)(10));
        sa(32);
        System.Console.Out.Write((char)(61));
        System.Console.Out.Write((char)(sp()));
        System.Console.Out.Write((long)(sp()));
        return;
    _16:
        sa((gr(gr(0,2),0))-(48));
        sa(((gr(gr(0,2),0))-(48))>(9)?1:0);
        goto _1;
    _17:
        gw(2,2,0);
        sp();
        sa(-10);
        goto _2;
    _18:
        sa((((gr(gr(0,2),0))>(57)?1:0)!=0)?0:1);
        goto _5;
    _19:
        gw((gr(gr(0,2),0))-(48),1,0);
        gw(gr(0,2),0,88);
        goto _20;
    _20:
        gw(0,2,(gr(0,2))+(1));
        goto _21;
    _21:
        sa((((0)>(gr(0,2))?1:0)!=0)?0:1);
        goto _6;
    _22:
        sa((((((gr(0,2))-(9))!=0)?0:1)+(((((gr(0,2))-(8))!=0)?0:1)+((((gr(0,2))-(7))!=0)?0:1)))+((((((gr(0,2))-(6))+(tm((((((gr(7,0))-(48))*(10))+((gr(8,0))-(48)))*(10))+((gr(9,0))-(48)),17)))!=0)?0:1)+((((((gr(0,2))-(5))+(tm((((((gr(6,0))-(48))*(10))+((gr(7,0))-(48)))*(10))+((gr(8,0))-(48)),13)))!=0)?0:1)+((((((gr(0,2))-(4))+(tm((((((gr(5,0))-(48))*(10))+((gr(6,0))-(48)))*(10))+((gr(7,0))-(48)),11)))!=0)?0:1)+((((((gr(0,2))-(3))+(tm((((((gr(4,0))-(48))*(10))+((gr(5,0))-(48)))*(10))+((gr(6,0))-(48)),7)))!=0)?0:1)+((((((gr(0,2))-(2))+(tm((((((gr(3,0))-(48))*(10))+((gr(4,0))-(48)))*(10))+((gr(5,0))-(48)),5)))!=0)?0:1)+((((((gr(0,2))-(1))+(tm((((((gr(2,0))-(48))*(10))+((gr(3,0))-(48)))*(10))+((gr(4,0))-(48)),3)))!=0)?0:1)+(((((gr(0,2))-(0))+(tm((((((gr(1,0))-(48))*(10))+((gr(2,0))-(48)))*(10))+((gr(3,0))-(48)),2)))!=0)?0:1))))))));
        goto _7;
    _23:
        sa((((gr(gr(0,2),0))>(57)?1:0)!=0)?0:1);
        goto _8;
    _24:
        gw((gr(gr(0,2),0))-(48),1,0);
        gw(gr(0,2),0,88);
        gw(0,2,(gr(0,2))+(1));
        goto _11;
    _25:
        gw(0,2,(gr(0,2))+(1));
        goto _11;
    _26:
        gw(0,2,0);
        gw(3,2,0);
        gw(3,2,((gr(0,0))-(48))+((gr(3,2))*(10)));
        sa(1);
        sa(-9);
        goto _9;
    _27:
        sa(sr());
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(48);
        {long v0=sp();sa(sp()-v0);}
        sa((gr(3,2))*(10));
        sa(sp()+sp());
        gw(3,2,sp());
        sa(sr());
        sa(1);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(9);
        {long v0=sp();sa(sp()-v0);}
        goto _9;
    _28:
        sp();
        sa(gr(3,2));
        System.Console.Out.Write((long)(gr(3,2)));
        System.Console.Out.Write((char)(10));
        sa(gr(1,2));
        sa(sp()+sp());
        gw(1,2,sp());
        goto _11;
    _29:
        sa(gr(gr(2,2),1));
        goto _3;
    _30:
        sa(gr(2,2));
        gw(2,2,(gr(2,2))+(1));
        sa(9);
        {long v0=sp();sa(sp()-v0);}
        goto _4;
    _31:
        sa((((gr(gr(0,2),0))>(57)?1:0)!=0)?0:1);
        goto _10;
    _32:
        gw((gr(gr(0,2),0))-(48),1,0);
        goto _33;
    _33:
        gw(gr(2,2),1,1);
        gw(gr(0,2),0,(gr(2,2))+(48));
        gw(0,2,(gr(0,2))-(1));
        goto _21;
    _34:
        sa(1);
        sa(sp()+sp());
        sa(sr());
        gw(2,2,sp());
        sa(10);
        {long v0=sp();sa(sp()-v0);}
        goto _2;
}}