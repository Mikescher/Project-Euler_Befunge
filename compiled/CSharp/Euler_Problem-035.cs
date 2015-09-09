/* compiled with BefunCompile v1.0.8 (c) 2015 */
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
        long t0;
        gw(1,0,2000);
        gw(2,0,500);
        gw(0,0,1000000);
        gw(3,0,2);
        gw(0,3,32);
        gw(1,3,32);
    _1:
        gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88);
        sa(gr(3,0)+gr(3,0));
        sa((gr(3,0)+gr(3,0))<gr(0,0)?1:0);
    _2:
        if(sp()!=0)goto _21;else goto _3;
    _3:
        sp();
    _4:
        sa(gr(3,0)+1);
        gw(3,0,gr(3,0)+1);
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));
        sa(sp()+3L);
        {long v0=sp();t0=gr(sp(),v0);}
        t0-=32;
        if((t0)!=0)goto _6;else goto _4;
    _6:
        if(gr(0,0)>gr(3,0))goto _1;else goto _7;
    _7:
        gw(9,0,0);
        gw(3,0,2);
    _8:
        sa(gr(3,0));
        if(gr(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3)!=88)goto _9;else goto _12;
    _9:
        sp();
        t0=gr(3,0)+1;
        gw(3,0,gr(3,0)+1);
        t0-=gr(0,0);
        t0=(t0!=0)?0:1;
        if((t0)!=0)goto _11;else goto _8;
    _11:
        t0=gr(9,0);
        System.Console.Out.Write(" =");
        System.Console.Out.Write(t0);
        return;
    _12:
        gw(5,0,1);
        sa(sr());
        t0=1;
        sa(td(sp(),10));
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _13;else goto _17;
    _13:
        sp();
        gw(6,0,t0);
        sa(sr());
        gw(7,0,sp());
    _14:
        sa(sr());
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));
        sa(sp()+3L);
        {long v0=sp();t0=gr(sp(),v0);}
        t0-=32;
        if((t0)!=0)goto _15;else goto _9;
    _15:
        t0=td(sr(),10);
        sa(tm(sp(),10));
        sa(sp()*gr(6,0));
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+sp());
        t0=gr(5,0)-1;
        gw(5,0,gr(5,0)-1);
        if((t0)!=0)goto _14;else goto _16;
    _16:
        System.Console.Out.Write(gr(7,0));
        System.Console.Out.Write('\n');
        gw(9,0,gr(9,0)+1);
        goto _9;
    _17:
        if(tm(sr(),2)==0)goto _18;else goto _19;
    _18:
        sp();
        goto _9;
    _19:
        if(tm(sr(),5)==0)goto _18;else goto _20;
    _20:
        gw(5,0,gr(5,0)+1);
        sa(td(sp(),10));
        t0*=10;
        sa(sr());
        if(sp()!=0)goto _17;else goto _13;
    _21:
        sa(sr());
        sa(32);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));
        sa(sp()+3L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+gr(3,0));
        sa(sr()<gr(0,0)?1:0);
        goto _2;
}}