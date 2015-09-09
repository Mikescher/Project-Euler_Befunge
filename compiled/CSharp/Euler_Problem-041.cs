/* compiled with BefunCompile v1.0.8 (c) 2015 */
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
        gw(1,2,7);
        gw(0,1,0);
        gw(0,0,49);
        sp();
        sa(1);
        sa(1-gr(1,2));
    _1:
        if(sp()!=0)goto _2;else goto _3;
    _2:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(sr()+49);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(0);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+1L);
        sa(sr()-gr(1,2));
        goto _1;
    _3:
        gw(3,2,1);
        sp();
    _4:
        if(gr(3,2)>gr(gr(3,2),1))goto _6;else goto _5;
    _5:
        gw(gr(3,2),1,0);
        gw(3,2,gr(3,2)+1);
        goto _4;
    _6:
        if(tm(gr(3,2),2)!=0)goto _17;else goto _7;
    _7:
        gw(4,2,0);
    _8:
        sa(gr(gr(4,2),0));
        gw(gr(4,2),0,gr(gr(3,2),0));
        gw(gr(3,2),0,sp());
        gw(gr(3,2),1,gr(gr(3,2),1)+1);
        gw(3,2,0);
        gw(6,2,gr(1,2));
        sa(0);
    _9:
        sa(gr(6,2)-1);
        gw(6,2,gr(6,2)-1);
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-48L);
        sa(sp()+sp());
        if((gr(6,2))!=0)goto _16;else goto _10;
    _10:
        gw(0,2,3);
        sa(sr());
        sa(sr());
        sa(sr()<=2?1:0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sp(),2));
        sa(sp()+sp());
        if(sp()!=0)goto _13;else goto _11;
    _11:
        gw(3,2,gr(3,2)+1);
        sp();
        sp();
        goto _4;
    _13:
        if(sr()<=((gr(0,2)-2)*(gr(0,2)-2)))goto _15;else goto _14;
    _14:
        sa(sr());
        sa(gr(0,2));
        gw(0,2,gr(0,2)+1);
        {long v0=sp();sa(tm(sp(),v0));}
        if(sp()!=0)goto _13;else goto _11;
    _15:
        sp();
        System.Console.Out.Write((long)(sp()));
        return;
    _16:
        sa(sp()*10L);
        goto _9;
    _17:
        gw(4,2,gr(gr(3,2),1));
        goto _8;
}}