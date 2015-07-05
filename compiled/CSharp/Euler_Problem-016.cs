/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABADtj70OwjAMhF/FBLo0CnVKc6CoqlhZmJhhzOqpE7w7ThH/CCFYuSGRfbY+X8/fq//vfipPP6gjwyZmMQt74Vp4JtwIB6GeqKpotV5tXu6qLWjKhTkY"+
                                    "AZeCOkLgo2kNUdurCecT8LjX3uAZyTtA7ga4I2gfqTh9VdIjnc3N/YmbNRm/C9Y+t6YZ2CDF0Xi7I+8axV74PNdn4A7uGXLWMnOR01i9pbAhRJswL2unpR4IT+oVaRh5"+
                                    "we4uWSQEW2UYrtG375LQEQVMzVNIAwAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<60&&y<14)?g[y*60+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<60&&y<14)g[y*60+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(0L,0L,48L);
        gw(0L,1L,48L);
        gw(0L,2L,48L);
        gw(0L,3L,48L);
        gw(0L,4L,48L);
        gw(0L,5L,48L);
        gw(1L,6L,60L);
        gw(2L,6L,6L);
        gw(0L,6L,360L);
        gw(4L,6L,1000L);
    _1:
        sa(gr(4L,6L));
        if((gr(4L,6L))==0)goto _2;else goto _6;
    _2:
        gw(6L,6L,gr(0L,6L)-1L);
        sp();
        sa(gr(tm(gr(6L,6L),gr(1L,6L)),td(gr(6L,6L),gr(1L,6L)))-48L);
    _3:
        if((gr(6L,6L))!=0)goto _5;else goto _4;
    _4:
        System.Console.Out.Write((long)(sp()));
        return;
    _5:
        gw(6L,6L,gr(6L,6L)-1L);
        sa(sp()+(gr(tm(gr(6L,6L),gr(1L,6L)),td(gr(6L,6L),gr(1L,6L)))-48L));
        goto _3;
    _6:
        sa(sp()-1L);
        gw(4L,6L,sp());
        gw(6L,6L,gr(0L,6L)-1L);
        gw(7L,6L,0L);
    _7:
        if((gr(6L,6L))==0)goto _1;else goto _8;
    _8:
        sa(((gr(tm(gr(6L,6L),gr(1L,6L)),td(gr(6L,6L),gr(1L,6L)))-48L)*2L)+gr(7L,6L));
        gw(tm(gr(6L,6L),gr(1L,6L)),td(gr(6L,6L),gr(1L,6L)),(tm(((gr(tm(gr(6L,6L),gr(1L,6L)),td(gr(6L,6L),gr(1L,6L)))-48L)*2L)+gr(7L,6L),10L))+48L);
        sa(td(sp(),10L));
        gw(7L,6L,sp());
        gw(6L,6L,gr(6L,6L)-1L);
        goto _7;
}}