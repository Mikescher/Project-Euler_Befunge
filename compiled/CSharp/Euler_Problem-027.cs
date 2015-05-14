/* compiled with BefunCompile v1.0.5 (c) 2015 */
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
        gw(1,0,600);
        gw(2,0,150);
        gw(9,0,90000);
        gw(3,0,2);
        gw(4,0,1000);
        gw(3,1,0);
    _1:
        gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88);
        sa(gr(3,0)+gr(3,0));
        sa((gr(9,0))>(gr(3,0)+gr(3,0))?1:0);
    _2:
        if(sp()!=0)goto _22;else goto _3;
    _3:
        sp();
    _4:
        sa(gr(3,0)+1);
        gw(3,0,gr(3,0)+1);
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(3);
        sa(sp()+sp());
        {long v0=sp();sa(gr(sp(),v0));}
        sa(32);
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _6;else goto _4;
    _6:
        sa((gr(9,0))>(gr(3,0))?1:0);
        if(sp()!=0)goto _1;else goto _7;
    _7:
        gw(0,3,32);
        gw(1,3,32);
        gw(5,0,(0-gr(4,0))+1);
        gw(6,0,2);
    _8:
        gw(7,0,0);
        sa(0+(gr(5,0)*gr(7,0))+gr(6,0));
        sa((0+(gr(5,0)*gr(7,0))+gr(6,0))>(1)?1:0);
    _9:
        if(sp()!=0)goto _10;else goto _21;
    _10:
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(3);
        sa(sp()+sp());
        {long v0=sp();sa(gr(sp(),v0));}
        sa(32);
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _20;else goto _11;
    _11:
        sa(gr(7,0));
        sa((gr(7,0))>(gr(3,1))?1:0);
        if(sp()!=0)goto _19;else goto _12;
    _12:
        sp();
    _13:
        sa(gr(5,0)+2);
        gw(5,0,gr(5,0)+2);
        sa(gr(4,0));
        {long v0=sp();sa((sp()>v0)?1:0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _8;else goto _14;
    _14:
        gw(5,0,(0-gr(4,0))+1);
    _15:
        sa(gr(6,0)+1);
        gw(6,0,gr(6,0)+1);
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(3);
        sa(sp()+sp());
        {long v0=sp();sa(gr(sp(),v0));}
        sa(32);
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _15;else goto _17;
    _17:
        sa((((gr(6,0))>(gr(4,0))?1:0)!=0)?0:1);
        if(sp()!=0)goto _8;else goto _18;
    _18:
        System.Console.Out.Write((long)(gr(1,1)*gr(2,1)));
        return;
    _19:
        gw(3,1,sp());
        gw(1,1,gr(5,0));
        gw(2,1,gr(6,0));
        goto _13;
    _20:
        sa(gr(7,0)+1);
        gw(7,0,gr(7,0)+1);
        sa(sr());
        sa(sp()*sp());
        sa((gr(5,0)*gr(7,0))+gr(6,0));
        sa(sp()+sp());
        sa(sr());
        sa(1);
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _9;
    _21:
        sp();
        goto _11;
    _22:
        sa(sr());
        sa(32);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(3);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(gr(3,0));
        sa(sp()+sp());
        sa(sr());
        sa(gr(9,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _2;
}}