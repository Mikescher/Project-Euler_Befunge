/* compiled with BefunCompile v1.0.2 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABADtkM0KwjAQhF+l4i1LZLZV/EGCTxJ722tOOfXh3WCNSBtQ8LhzyWSHfJkkd38V1mQ0oxnNaEYzWpsWvmXlVhDaCSDsGSLFFC/0dCkHBhIzUtCWsj/3"+
                                    "jnTu3VQODWU7buO9EliTd5UEJhZwAryuuNYoalTGpOlHsOjGc5NlFKubNl03Uu8OJypPALe/56W1G287ubjj0C7zgx7G7Dw7OggAAA==";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=o.Skip(1).ToArray();for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<78&&y<27)?g[y*78+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<78&&y<27)g[y*78+x]=v;}
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
        goto _4;
    _0:
        if(sp()!=0)goto _6; else goto _8;
    _1:
        if(sp()!=0)goto _3; else goto _7;
    _2:
        if(sp()!=0)goto _9; else goto _10;
    _3:
        if(((gr(0,0))*((22)-(gr(1,0))))!=0)goto _5;else goto _11;
    _4:
        gw(0,0,1);
        gw(1,0,1);
        goto _3;
    _5:
        sa((gr(0,0))>(21)?1:0);
        goto _0;
    _6:
        gw(0,0,(gr(0,0))-(1));
        gw(1,0,(gr(1,0))+(1));
        sa(((((gr(1,0))+(gr(0,0)))>(42)?1:0)!=0)?0:1);
        goto _1;
    _7:
        System.Console.Out.Write((long)(gr(21,21)));
        return;
    _8:
        sa(((gr(0,0))-(1))*((gr(1,0))-(1)));
        goto _2;
    _9:
        gw(gr(0,0),gr(1,0),(gr((gr(0,0))-(1),gr(1,0)))+(gr(gr(0,0),(gr(1,0))-(1))));
        goto _6;
    _10:
        gw(gr(0,0),gr(1,0),1);
        goto _6;
    _11:
        gw(0,0,(gr(0,0))+(gr(1,0)));
        gw(1,0,1);
        goto _3;
}}