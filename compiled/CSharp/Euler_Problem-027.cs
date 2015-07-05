/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "Ah+LCAAAAAAABACT7+ZgAAEWhrc3HLsvO4gwPNg/ybdMn3Pr5JTbtzaw6N+zrdLIDTzdsEZC7O1J+fchYbp5u7vWeJTv57eacOaM9tJ+c/2badaPC7+9evb499nb/jdP"+
                                    "n78+e3bOlt11xXt/Trjqy8bQH8rIQBPwwSP1A/+Xn7trospKJW7tOXl6HaezJb/z5bZEo5k2+qc/GfEsXNv+duLbyHutZStuK3NXzPpnIb2O726MbncpTy7P58OfbUJr"+
                                    "/1nlO/uwasfpXDLIW60Y+/1lcOlnAfHXt1uPlpXu2x0dHrsq9ffr5FWRi9+c/v9HdE7H04CtjyVeHXWV2nX03RZv1szK83xfu2z5r4t66tQ9ztv01XXb349vLFoiw68a"+
                                    "nqlbFjTf6renlcrrRKmk4jWn7eXqz+u96E5PXTNbxG/TvBV2MW0Wq1Z7VrHNaVvIf1enN3bmpBSxpJmblqzaVTV31/J/fv6hOuGZvtevFf7NLr+6/K/v1aUrNP/80jFN"+
                                    "/33/iv/+r5mXmWtvRXLNStv/ftf7J09LZH7LB++14mefJl79+ejCzujw+q+LfLZaRcYzHtq6S3BDNSMDABHvrYXvAQAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<600&&y<162)?g[y*600+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<600&&y<162)g[y*600+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(1L,0L,600L);
        gw(2L,0L,150L);
        gw(9L,0L,90000L);
        gw(3L,0L,2L);
        gw(4L,0L,1000L);
        gw(3L,1L,0L);
    _1:
        gw(tm(gr(3L,0L),gr(1L,0L)),(td(gr(3L,0L),gr(1L,0L)))+3L,88L);
        sa(gr(3L,0L)+gr(3L,0L));
        sa((gr(3L,0L)+gr(3L,0L))<gr(9L,0L)?1:0);
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
        if(gr(9L,0L)>gr(3L,0L))goto _1;else goto _7;
    _7:
        gw(0L,3L,32L);
        gw(1L,3L,32L);
        gw(5L,0L,1L-gr(4L,0L));
        gw(6L,0L,2L);
    _8:
        gw(7L,0L,0L);
        sa((gr(5L,0L)*gr(7L,0L))+gr(6L,0L));
        sa(((gr(5L,0L)*gr(7L,0L))+gr(6L,0L))>1L?1:0);
    _9:
        if(sp()!=0)goto _10;else goto _21;
    _10:
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+3L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-32L);
        if(sp()!=0)goto _20;else goto _11;
    _11:
        sa(gr(7L,0L));
        if(gr(7L,0L)>gr(3L,1L))goto _19;else goto _12;
    _12:
        sp();
    _13:
        sa(gr(5L,0L)+2L);
        gw(5L,0L,gr(5L,0L)+2L);
        sa((sp()>gr(4L,0L))?1:0);
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _8;else goto _14;
    _14:
        gw(5L,0L,1L-gr(4L,0L));
    _15:
        sa(gr(6L,0L)+1L);
        gw(6L,0L,gr(6L,0L)+1L);
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+3L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-32L);
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _15;else goto _17;
    _17:
        if(gr(6L,0L)<=gr(4L,0L))goto _8;else goto _18;
    _18:
        System.Console.Out.Write((long)(gr(1L,1L)*gr(2L,1L)));
        return;
    _19:
        gw(3L,1L,sp());
        gw(1L,1L,gr(5L,0L));
        gw(2L,1L,gr(6L,0L));
        goto _13;
    _20:
        sa(gr(7L,0L)+1L);
        gw(7L,0L,gr(7L,0L)+1L);
        sa(sr());
        sa(sp()*sp());
        sa(sp()+(gr(5L,0L)*gr(7L,0L))+gr(6L,0L));
        sa(sr()>1L?1:0);
        goto _9;
    _21:
        sp();
        goto _11;
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
        sa(sr()<gr(9L,0L)?1:0);
        goto _2;
}}