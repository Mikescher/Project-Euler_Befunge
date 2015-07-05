/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(0L,2L,9L);
        gw(1L,2L,0L);
        gw(9L,1L,0L);
        sa(8L);
    _1:
        sa(sr());
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()-1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        if(sp()!=0)goto _1;else goto _3;
    _3:
        sp();
    _4:
        if(gr(0L,2L)>9L)goto _25;else goto _5;
    _5:
        sa(gr(gr(0L,2L),0L)-48L);
        if((gr(gr(0L,2L),0L)-48L)>9L)goto _24;else goto _6;
    _6:
        sa(sp()+1L);
        sa(sr());
        gw(2L,2L,sp());
        sa(sp()-10L);
        if(sp()!=0)goto _19;else goto _7;
    _7:
        if(gr(gr(0L,2L),0L)<=57L)goto _18;else goto _8;
    _8:
        gw(0L,2L,gr(0L,2L)+1L);
    _9:
        if(0L<=gr(0L,2L))goto _14;else goto _10;
    _10:
        gw(0L,2L,0L);
        gw(3L,2L,0L);
        gw(3L,2L,(gr(0L,0L)-48L)+(gr(3L,2L)*10L));
        sa(1L);
    _11:
        sa(sr());
        sa(0L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-48L);
        sa(sp()+(gr(3L,2L)*10L));
        gw(3L,2L,sp());
        sa(sr()+1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-9L);
        if(sp()!=0)goto _11;else goto _13;
    _13:
        sp();
        sa(gr(3L,2L));
        System.Console.Out.Write((long)(gr(3L,2L)));
        System.Console.Out.Write('\n');
        sa(sp()+gr(1L,2L));
        gw(1L,2L,sp());
        goto _4;
    _14:
        if((((gr(0L,2L)-9L!=0)?0:1)+((gr(0L,2L)-8L!=0)?0:1)+((gr(0L,2L)-7L!=0)?0:1)+(((gr(0L,2L)-6L)+(tm(((((gr(7L,0L)-48L)*10L)+(gr(8L,0L)-48L))*10L)+(gr(9L,0L)-48L),17L))!=0)?0:1)+(((gr(0L,2L)-5L)+(tm(((((gr(6L,0L)-48L)*10L)+(gr(7L,0L)-48L))*10L)+(gr(8L,0L)-48L),13L))!=0)?0:1)+(((gr(0L,2L)-4L)+(tm(((((gr(5L,0L)-48L)*10L)+(gr(6L,0L)-48L))*10L)+(gr(7L,0L)-48L),11L))!=0)?0:1)+(((gr(0L,2L)-3L)+(tm(((((gr(4L,0L)-48L)*10L)+(gr(5L,0L)-48L))*10L)+(gr(6L,0L)-48L),7L))!=0)?0:1)+(((gr(0L,2L)-2L)+(tm(((((gr(3L,0L)-48L)*10L)+(gr(4L,0L)-48L))*10L)+(gr(5L,0L)-48L),5L))!=0)?0:1)+(((gr(0L,2L)-1L)+(tm(((((gr(2L,0L)-48L)*10L)+(gr(3L,0L)-48L))*10L)+(gr(4L,0L)-48L),3L))!=0)?0:1)+((gr(0L,2L)+(tm(((((gr(1L,0L)-48L)*10L)+(gr(2L,0L)-48L))*10L)+(gr(3L,0L)-48L),2L))!=0)?0:1))!=0)goto _4;else goto _15;
    _15:
        if(gr(gr(0L,2L),0L)<=57L)goto _17;else goto _16;
    _16:
        gw(0L,2L,gr(0L,2L)+1L);
        goto _4;
    _17:
        gw(gr(gr(0L,2L),0L)-48L,1L,0L);
        gw(gr(0L,2L),0L,88L);
        gw(0L,2L,gr(0L,2L)+1L);
        goto _4;
    _18:
        gw(gr(gr(0L,2L),0L)-48L,1L,0L);
        gw(gr(0L,2L),0L,88L);
        goto _8;
    _19:
        if((gr(gr(2L,2L),1L))!=0)goto _20;else goto _21;
    _20:
        sa(gr(2L,2L));
        gw(2L,2L,gr(2L,2L)+1L);
        sa(sp()-9L);
        if(sp()!=0)goto _19;else goto _7;
    _21:
        if(gr(gr(0L,2L),0L)<=57L)goto _23;else goto _22;
    _22:
        gw(gr(2L,2L),1L,1L);
        gw(gr(0L,2L),0L,gr(2L,2L)+48L);
        gw(0L,2L,gr(0L,2L)-1L);
        goto _9;
    _23:
        gw(gr(gr(0L,2L),0L)-48L,1L,0L);
        goto _22;
    _24:
        gw(2L,2L,0L);
        sp();
        goto _19;
    _25:
        sa(gr(1L,2L));
        System.Console.Out.Write('\n');
        sa(32L);
        System.Console.Out.Write('=');
        System.Console.Out.Write((char)(sp()));
        System.Console.Out.Write((long)(sp()));
        return;
}}