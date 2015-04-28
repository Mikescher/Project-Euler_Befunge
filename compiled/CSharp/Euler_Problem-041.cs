/* compiled with BefunCompile v1.0.4 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABACNksFqwzAMhl9FzZpLTYYktxmIYPYYOwSTm646+eSHn9zQkZaQTmAhWd8fS3bKz93gnZV/cue3xGrpC4DYAJPgTCbSURfKgaAOyiSBDGeYdvrzZRzp"+
                                    "vFM76CKykh4d2wjuKxTj65QaTcG3yrYupEtdM2w+52io7G6iB5cfPLYjraQrK2pszqNsf5wPEcjFa7qZxjuI+DxdGWVwdrwEuN0mNB79jjbI9+eaJPZ+OuyGMLLWvTFf"+
                                    "n+3DRZIishUP0O9gkMsCp1fxXZdOM/cQam+MgUQZZfcV8sLilaNfJG/ip2/8AoE9XKOoAgAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<40&&y<17)?g[y*40+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<40&&y<17)g[y*40+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        goto _0;
    _0:
        gw(1,2,7);
        gw(0,1,0);
        gw(0,0,49);
        sp();
        sa(1);
        sa((1)-(gr(1,2)));
    _1:
        if(sp()!=0)goto _2; else goto _3;
    _2:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(sr());
        sa(49);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(0);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(1);
        sa(sp()+sp());
        sa(sr());
        sa(gr(1,2));
        {long v0=sp();sa(sp()-v0);}
        goto _1;
    _3:
        gw(3,2,1);
        sp();
    _4:
        sa((gr(3,2))>(gr(gr(3,2),1))?1:0);
        if(sp()!=0)goto _5; else goto _18;
    _5:
        sa(tm(gr(3,2),2));
        if(sp()!=0)goto _17; else goto _6;
    _6:
        gw(4,2,0);
    _7:
        sa(gr(gr(4,2),0));
        gw(gr(4,2),0,gr(gr(3,2),0));
        gw(gr(3,2),0,sp());
        gw(gr(3,2),1,(gr(gr(3,2),1))+(1));
        gw(3,2,0);
        gw(6,2,gr(1,2));
        sa(0);
    _8:
        sa((gr(6,2))-(1));
        gw(6,2,(gr(6,2))-(1));
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(48);
        {long v0=sp();sa(sp()-v0);}
        sa(sp()+sp());
        sa(gr(6,2));
        if(sp()!=0)goto _16; else goto _9;
    _9:
        gw(0,2,3);
        sa(sr());
        sa(sr());
        sa(sr());
        sa(2);
        {long v0=sp();sa((sp()>v0)?1:0);}
        sa((sp()!=0)?0:1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sp()+sp());
        if(sp()!=0)goto _10; else goto _15;
    _10:
        sa(sr());
        sa(((gr(0,2))-(2))*((gr(0,2))-(2)));
        {long v0=sp();sa((sp()>v0)?1:0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _14; else goto _11;
    _11:
        sa(sr());
        sa(gr(0,2));
        gw(0,2,(gr(0,2))+(1));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        if(sp()!=0)goto _10; else goto _12;
    _12:
        gw(3,2,(gr(3,2))+(1));
        sp();
    _13:
        sp();
        goto _4;
    _14:
        sp();
        System.Console.Out.Write((long)(sp()));
        return;
    _15:
        gw(3,2,(gr(3,2))+(1));
        sp();
        goto _13;
    _16:
        sa(10);
        sa(sp()*sp());
        goto _8;
    _17:
        gw(4,2,gr(gr(3,2),1));
        goto _7;
    _18:
        gw(gr(3,2),1,0);
        gw(3,2,(gr(3,2))+(1));
        goto _4;
}}