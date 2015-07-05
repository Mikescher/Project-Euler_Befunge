/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABADtkM0KwjAQhF+l4i1LZLZV/EGCTxJ722tOOfXh3WCNSBtQ8LhzyWSHfJkkd38V1mQ0oxnNaEYzWpsWvmXlVhDaCSDsGSLFFC/0dCkHBhIzUtCWsj/3"+
                                    "jnTu3VQODWU7buO9EliTd5UEJhZwAryuuNYoalTGpOlHsOjGc5NlFKubNl03Uu8OJypPALe/56W1G287ubjj0C7zgx7G7Dw7OggAAA==";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<78&&y<27)?g[y*78+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<78&&y<27)g[y*78+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(0L,0L,1L);
        gw(1L,0L,1L);
    _1:
        if((gr(0L,0L)*(22L-gr(1L,0L)))!=0)goto _3;else goto _2;
    _2:
        gw(0L,0L,gr(0L,0L)+gr(1L,0L));
        gw(1L,0L,1L);
        goto _1;
    _3:
        if(gr(0L,0L)>21L)goto _4;else goto _6;
    _4:
        gw(0L,0L,gr(0L,0L)-1L);
        gw(1L,0L,gr(1L,0L)+1L);
        if((gr(1L,0L)+gr(0L,0L))<=42L)goto _1;else goto _5;
    _5:
        System.Console.Out.Write((long)(gr(21L,21L)));
        return;
    _6:
        if(((gr(0L,0L)-1L)*(gr(1L,0L)-1L))!=0)goto _8;else goto _7;
    _7:
        gw(gr(0L,0L),gr(1L,0L),1L);
        goto _4;
    _8:
        gw(gr(0L,0L),gr(1L,0L),gr(gr(0L,0L)-1L,gr(1L,0L))+gr(gr(0L,0L),gr(1L,0L)-1L));
        goto _4;
}}