/* compiled with BefunCompile v1.0.7 (c) 2015 */
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
        long t0;
        gw(1,0,600);
        gw(2,0,150);
        gw(9,0,90000);
        gw(3,0,2);
        gw(4,0,1000);
        gw(3,1,0);
    _1:
        gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88);
        sa(gr(3,0)+gr(3,0));
        sa((gr(3,0)+gr(3,0))<gr(9,0)?1:0);
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
        t0=t0-32;
        if((t0)!=0)goto _6;else goto _4;
    _6:
        if(gr(9,0)>gr(3,0))goto _1;else goto _7;
    _7:
        gw(0,3,32);
        gw(1,3,32);
        gw(5,0,1-gr(4,0));
        gw(6,0,2);
    _8:
        gw(7,0,0);
        sa((gr(5,0)*gr(7,0))+gr(6,0));
        sa(((gr(5,0)*gr(7,0))+gr(6,0))>1?1:0);
    _9:
        if(sp()!=0)goto _10;else goto _20;
    _10:
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));
        sa(sp()+3L);
        {long v0=sp();t0=gr(sp(),v0);}
        t0=t0-32;
        if((t0)!=0)goto _19;else goto _11;
    _11:
        t0=gr(7,0);
        if(gr(7,0)>gr(3,1))goto _18;else goto _12;
    _12:
        t0=gr(5,0)+2;
        gw(5,0,gr(5,0)+2);
        t0=t0>gr(4,0)?1:0;
        t0=(t0!=0)?0:1;
        if((t0)!=0)goto _8;else goto _13;
    _13:
        gw(5,0,1-gr(4,0));
    _14:
        sa(gr(6,0)+1);
        gw(6,0,gr(6,0)+1);
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));
        sa(sp()+3L);
        {long v0=sp();t0=gr(sp(),v0);}
        t0=t0-32;
        t0=(t0!=0)?0:1;
        if((t0)!=0)goto _14;else goto _16;
    _16:
        if(gr(6,0)<=gr(4,0))goto _8;else goto _17;
    _17:
        System.Console.Out.Write(gr(1,1)*gr(2,1));
        return;
    _18:
        gw(3,1,t0);
        gw(1,1,gr(5,0));
        gw(2,1,gr(6,0));
        goto _12;
    _19:
        sa(gr(7,0)+1);
        gw(7,0,gr(7,0)+1);
        sa(sr());
        sa(sp()*sp());
        sa(sp()+(gr(5,0)*gr(7,0))+gr(6,0));
        sa(sr()>1?1:0);
        goto _9;
    _20:
        sp();
        goto _11;
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
        sa(sr()<gr(9,0)?1:0);
        goto _2;
}}