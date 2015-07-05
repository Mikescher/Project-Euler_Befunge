/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABAC9jz0KAjEQha+SnZhmh5hMhogECbZeYrcR0qZK6dkddxVEEGOzrxjmD977mt9AbQMPynCFTDYNus3Jc/XEFW4XwMA1By5yNoRr4wp4sJ7LSFwwxYjm"+
                                    "cFRNdWla6k5/rOdJD5VDslQ4VCaHMVYnZjIimWcznvpMVuUFgAUm84uA3whQKRkTWXnpjf9N5/2D4NfXX/HVHUV2dgFeAgAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<101&&y<6)?g[y*101+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<101&&y<6)g[y*101+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        sa(99L);
    _1:
        sa(sr());
        gw(0L,3L,sp());
        gw(1L,3L,0L);
        gw(2L,3L,199L);
    _2:
        sa(((gr((tm(gr(2L,3L),100L))+1L,td(gr(2L,3L),100L))-48L)*gr(0L,3L))+gr(1L,3L));
        gw((tm(gr(2L,3L),100L))+1L,td(gr(2L,3L),100L),(tm(((gr((tm(gr(2L,3L),100L))+1L,td(gr(2L,3L),100L))-48L)*gr(0L,3L))+gr(1L,3L),10L))+48L);
        sa(td(sp(),10L));
        gw(1L,3L,sp());
        sa(gr(2L,3L)-1L);
        gw(2L,3L,gr(2L,3L)-1L);
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _4;else goto _2;
    _4:
        sa(sp()-1L);
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _5;else goto _1;
    _5:
        gw(3L,3L,199L);
        sp();
        sa(gr((tm(gr(3L,3L),100L))+1L,td(gr(3L,3L),100L))-48L);
    _6:
        sa(gr(3L,3L));
        gw(3L,3L,gr(3L,3L)-1L);
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _7;else goto _8;
    _7:
        System.Console.Out.Write((long)(sp()));
        return;
    _8:
        sa(sp()+(gr((tm(gr(3L,3L),100L))+1L,td(gr(3L,3L),100L))-48L));
        goto _6;
}}