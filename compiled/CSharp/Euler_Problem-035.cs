/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "Ah+LCAAAAAAABACT7+ZgAAEWhre3D+ZddhBguBBfOPeJkPnZXcfWbtISE38nU71hEtcKnYVKa7iKXh3fvM7LlU+TsVPqyvclFY+/VojOV9sslb/Z/XTqt3ffTi9/zR+/"+
                                    "efv9vHX5m48W/Pv37Fdx2FVJsPkbrrMwjIJRMAqGPKjYaAQkE0p8/xnWh55/vpGndu6+848zXzxX/LI89MVnnf6Fr06vus+38faG4mz5sIdJU+R5Gd7ckBPbpp6ff23y"+
                                    "ar2Q2Ak3GBNcfOtmhi/0flppnn05MVK01ir/0vIOxZK3V50fpOyeybc5VTD46b/imumnfhy9O4OfkcFk9YWn6zf/+fHjydn+naXxIaf1przVkU2yztmznKtmb73gV0uG"+
                                    "nucH/n6rLjJj+LP52uy3h7Oz3bv1WuxCNmrsDvDVP3TZ/J/mf26GBJ/9657NP3P1bGM3A8P+pZL3vKV/3XmU1307dd+MNeYb1zjHbyuN1Xl8MWV35qOXORLJtfY8nw8f"+
                                    "rYzm7y3SNLtnenmzyZzlro/nLdtp8UmZ+UD3NRmhzzeMy6+3W+md0ltSc791c2Tg9cjdPu633zJ8uJ8R9LBObtfkx1cDdq93kp+Vc8tns/rtJ4wN6Zfe8LDPXie9Uobh"+
                                    "X9v7FSrdxQ77+RkAAhzLy4wFAAA=";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<2000&&y<516)?g[y*2000+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<2000&&y<516)g[y*2000+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(1L,0L,2000L);
        gw(2L,0L,500L);
        gw(0L,0L,1000000L);
        gw(3L,0L,2L);
        gw(0L,3L,32L);
        gw(1L,3L,32L);
    _1:
        gw(tm(gr(3L,0L),gr(1L,0L)),(td(gr(3L,0L),gr(1L,0L)))+3L,88L);
        sa(gr(3L,0L)+gr(3L,0L));
        sa((gr(3L,0L)+gr(3L,0L))<gr(0L,0L)?1:0);
    _2:
        if(sp()!=0)goto _22;else goto _3;
    _3:
        sp();
    _4:
        sa(gr(3L,0L)+1L);
        gw(3L,0L,gr(3L,0L)+1L);
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+3L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-32L);
        if(sp()!=0)goto _6;else goto _4;
    _6:
        if(gr(0L,0L)>gr(3L,0L))goto _1;else goto _7;
    _7:
        gw(9L,0L,0L);
        gw(3L,0L,2L);
    _8:
        sa(gr(3L,0L));
        if(gr(tm(gr(3L,0L),gr(1L,0L)),(td(gr(3L,0L),gr(1L,0L)))+3L)!=88L)goto _21;else goto _9;
    _9:
        gw(5L,0L,1L);
        sa(sr());
        sa(1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10L));
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _10;else goto _17;
    _10:
        sp();
        gw(6L,0L,sp());
        sa(sr());
        gw(7L,0L,sp());
    _11:
        sa(sr());
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+3L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-32L);
        if(sp()!=0)goto _12;else goto _14;
    _12:
        sa(td(sr(),10L));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sp(),10L));
        sa(sp()*gr(6L,0L));
        sa(sp()+sp());
        sa(gr(5L,0L)-1L);
        gw(5L,0L,gr(5L,0L)-1L);
        if(sp()!=0)goto _11;else goto _13;
    _13:
        sa(10L);
        System.Console.Out.Write((long)(gr(7L,0L)));
        gw(9L,0L,gr(9L,0L)+1L);
        System.Console.Out.Write((char)(sp()));
    _14:
        sp();
    _15:
        sa(gr(3L,0L)+1L);
        gw(3L,0L,gr(3L,0L)+1L);
        sa(sp()-gr(0L,0L));
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _16;else goto _8;
    _16:
        sa(gr(9L,0L));
        sa(61L);
        System.Console.Out.Write(' ');
        System.Console.Out.Write((char)(sp()));
        System.Console.Out.Write((long)(sp()));
        return;
    _17:
        if(tm(sr(),2L)==0)goto _18;else goto _19;
    _18:
        sp();
        sp();
        goto _14;
    _19:
        if(tm(sr(),5L)==0)goto _18;else goto _20;
    _20:
        gw(5L,0L,gr(5L,0L)+1L);
        sa(td(sp(),10L));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*10L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        if(sp()!=0)goto _17;else goto _10;
    _21:
        sp();
        goto _15;
    _22:
        sa(sr());
        sa(32L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+3L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+gr(3L,0L));
        sa(sr()<gr(0L,0L)?1:0);
        goto _2;
}}