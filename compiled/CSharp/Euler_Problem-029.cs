/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABADt1NFOwjAUBuBXGd24WTM9HWzAQhp8AN8At5sl9bJXvTI8u6erEEKGOsVo6v8nhNK1Z+cbFJf801AsmehOYwnccMMNN9xxBG644YYb7jgCN9xwww13"+
                                    "HIEbbrjhhjuOwA033HDDHUfghhtuuOGOI3DDDTfccMcRuOGGG2644wjcyPXoRDw9Hh4OPs8zIYfkMs8VWdEcpJB5VUke96LMlSzJut9u+SaZrtj+QBcfZWqXoUexFJfN"+
                                    "7u4MyarKjvNjhbfjW/1vJCQbbWd00lJ1z/ezVF+We5d07RnrYpa67vN1RiqUZBin12Qb2q/JWH6polFF2nYZD/yb6Puwgq/tS0qM5rXKOq14t7JLspoqsvyh5mHNc2ZJ"+
                                    "Jq/IyIZPydzP2Hqo68sNZV2XkVrx8k2+8hukIjP3I9mshlLF0MJbexuyC77/gsyGjGlefOf+/HHJ4RhmTodr560Pg50+gdxx1nXttKcU0nZtOmsKdfZtTK/zreOis6C0"+
                                    "2Wnm6tovEW+2/S9ky3/OYZAkr+fUiHQoOQAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<248&&y<59)?g[y*248+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<248&&y<59)g[y*248+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(1L,0L,357913941L);
        gw(10L,0L,9802L);
        gw(2L,0L,201L);
        sa(gr(2L,0L));
        gw(8L,0L,52L);
    _1:
        sa(sr());
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(8L,0L));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(gr(8L,0L)-1L);
        if(gr(8L,0L)!=2L)goto _31;else goto _2;
    _2:
        sp();
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _3;else goto _4;
    _3:
        gw(8L,0L,52L);
        goto _1;
    _4:
        gw(8L,0L,100L);
        sp();
        sa(100L);
        sa(gr(8L,0L));
        sa(100L);
    _5:
        sa(gr(2L,0L));
        gw(gr(2L,0L),1L,0L);
    _6:
        sa(sp()-1L);
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _8;else goto _7;
    _7:
        sa(sr());
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _6;
    _8:
        gw(gr(2L,0L),1L,1L);
        sp();
        gw(4L,0L,sp());
    _9:
        gw(5L,0L,0L);
        gw(6L,0L,gr(2L,0L));
    _10:
        sa((gr(gr(6L,0L),1L)*gr(4L,0L))+gr(5L,0L));
        gw(gr(6L,0L),1L,tm((gr(gr(6L,0L),1L)*gr(4L,0L))+gr(5L,0L),10L));
        sa(gr(6L,0L)-1L);
        if(gr(6L,0L)!=1L)goto _30;else goto _11;
    _11:
        sp();
        sp();
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _9;else goto _12;
    _12:
        gw(7L,0L,1L);
        sp();
        sa(tm(gr(gr(7L,0L),1L),gr(1L,0L)));
    _13:
        sa(gr(7L,0L)+1L);
        gw(7L,0L,gr(7L,0L)+1L);
        sa(sp()-gr(2L,0L));
        sa(sp()-1L);
        if(sp()!=0)goto _29;else goto _14;
    _14:
        sa(gr(2L,0L));
        gw(9L,0L,52L);
    _15:
        gw(3L,0L,sp());
        sa(sr());
        sa(gr(gr(3L,0L),gr(9L,0L)));
        if((gr(gr(3L,0L),gr(9L,0L)))!=0)goto _16;else goto _28;
    _16:
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _22;else goto _17;
    _17:
        sa(gr(3L,0L));
        sa(gr(9L,0L)-1L);
        if(gr(9L,0L)!=2L)goto _21;else goto _18;
    _18:
        sp();
        sa(sp()-1L);
        if(sr()!=1L)goto _20;else goto _19;
    _19:
        return;
    _20:
        gw(9L,0L,52L);
        goto _15;
    _21:
        gw(9L,0L,sp());
        goto _15;
    _22:
        gw(10L,0L,gr(10L,0L)-1L);
        sp();
    _23:
        sa(gr(8L,0L)-1L);
        if(gr(8L,0L)!=2L)goto _27;else goto _24;
    _24:
        sp();
        sa(sp()-1L);
        if(sr()!=1L)goto _26;else goto _25;
    _25:
        sp();
        System.Console.Out.Write((long)(gr(10L,0L)));
        return;
    _26:
        gw(8L,0L,100L);
        sa(sr());
        sa(gr(8L,0L));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _5;
    _27:
        gw(8L,0L,sp());
        sa(sr());
        sa(gr(8L,0L));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _5;
    _28:
        sp();
        gw(gr(3L,0L),gr(9L,0L),sp());
        sp();
        goto _23;
    _29:
        sa(sp()*9L);
        sa(sp()+gr(gr(7L,0L),1L));
        sa(tm(sp(),gr(1L,0L)));
        goto _13;
    _30:
        gw(6L,0L,sp());
        sa(td(sp(),10L));
        gw(5L,0L,sp());
        goto _10;
    _31:
        gw(8L,0L,sp());
        goto _1;
}}