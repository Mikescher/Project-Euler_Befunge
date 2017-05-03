/* transpiled with BefunCompile v1.1.0 (c) 2015 */
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
static void Main(string[]args)
{
        long t0;
        gw(0,2,9);
        gw(1,2,0);
        gw(9,1,0);
        sa(8);
    _1:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        if(sp()!=0)goto _1;else goto _3;
    _3:
        sp();
    _4:
        if(gr(0,2)>9)goto _25;else goto _5;
    _5:
        sa(gr(gr(0,2),0)-48);

        if((gr(gr(0,2),0)-48)>9)goto _24;else goto _6;
    _6:
        sa(sp()+1L);

        sa(sr());
        gw(2,2,sp());
        sa(sp()-10L);


        if(sp()!=0)goto _19;else goto _7;
    _7:
        if(gr(gr(0,2),0)<=57)goto _18;else goto _8;
    _8:
        gw(0,2,gr(0,2)+1);
    _9:
        if(0<=gr(0,2))goto _14;else goto _10;
    _10:
        gw(0,2,0);
        gw(3,2,0);
        gw(3,2,(gr(0,0)-48)+(gr(3,2)*10));
        sa(1);
    _11:
        sa(sr());
        sa(0);
        {long v0=sp();t0=gr(sp(),v0);}
        t0-=48;
        t0+=gr(3,2)*10;
        gw(3,2,t0);
        sa(sr()+1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-9L);
        if(sp()!=0)goto _11;else goto _13;
    _13:
        sp();
        t0=gr(3,2);
        System.Console.Out.Write(gr(3,2));
        System.Console.Out.Write('\n');
        t0+=gr(1,2);
        gw(1,2,t0);
        goto _4;
    _14:
        if((((gr(0,2)-9!=0)?0:1)+((gr(0,2)-8!=0)?0:1)+((gr(0,2)-7!=0)?0L:1L)+(((gr(0,2)-6)+(tm(((((gr(7,0)-48)*10)+(gr(8,0)-48))*10)+(gr(9,0)-48),17))!=0)?0:1)+(((gr(0,2)-5)+(tm(((((gr(6,0)-48)*10)+(gr(7,0)-48))*10)+(gr(8,0)-48),13))!=0)?0:1)+(((gr(0,2)-4)+(tm(((((gr(5,0)-48)*10)+(gr(6,0)-48))*10)+(gr(7,0)-48),11))!=0)?0:1)+(((gr(0,2)-3)+(tm(((((gr(4,0)-48)*10)+(gr(5,0)-48))*10)+(gr(6,0)-48),7))!=0)?0:1)+(((gr(0,2)-2)+(tm(((((gr(3,0)-48)*10)+(gr(4,0)-48))*10)+(gr(5,0)-48),5))!=0)?0:1)+(((gr(0,2)-1)+(tm(((((gr(2,0)-48)*10)+(gr(3,0)-48))*10)+(gr(4,0)-48),3))!=0)?0:1)+((gr(0,2)+(tm(((((gr(1,0)-48)*10)+(gr(2,0)-48))*10)+(gr(3,0)-48),2))!=0)?0L:1L))!=0)goto _4;else goto _15;
    _15:
        if(gr(gr(0,2),0)<=57)goto _17;else goto _16;
    _16:
        gw(0,2,gr(0,2)+1);
        goto _4;
    _17:
        gw(gr(gr(0,2),0)-48,1,0);
        gw(gr(0,2),0,88);
        gw(0,2,gr(0,2)+1);
        goto _4;
    _18:
        gw(gr(gr(0,2),0)-48,1,0);
        gw(gr(0,2),0,88);
        goto _8;
    _19:
        if((gr(gr(2,2),1))!=0)goto _20;else goto _21;
    _20:
        t0=gr(2,2);
        gw(2,2,gr(2,2)+1);
        t0-=9;

        if((t0)!=0)goto _19;else goto _7;
    _21:
        if(gr(gr(0,2),0)<=57)goto _23;else goto _22;
    _22:
        gw(gr(2,2),1,1);
        gw(gr(0,2),0,gr(2,2)+48);
        gw(0,2,gr(0,2)-1);
        goto _9;
    _23:
        gw(gr(gr(0,2),0)-48,1,0);
        goto _22;
    _24:
        gw(2,2,0);
        sp();
        goto _19;
    _25:
        t0=gr(1,2);
        System.Console.Out.Write('\n');
        System.Console.Out.Write("= ");
        System.Console.Out.Write(t0);
        return;
}
}
