/* transpiled with BefunCompile v1.1.0 (c) 2015 */
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
static void Main(string[]args)
{
        long t0,t1;
        sa(99);
    _1:
        sa(sr());
        gw(0,3,sp());
        gw(1,3,0);
        gw(2,3,199);
    _2:
        t0=((gr((tm(gr(2,3),100))+1,td(gr(2,3),100))-48)*gr(0,3))+gr(1,3);
        gw((tm(gr(2,3),100))+1,td(gr(2,3),100),(tm(((gr((tm(gr(2,3),100))+1,td(gr(2,3),100))-48)*gr(0,3))+gr(1,3),10))+48);
        t0/=10;
        gw(1,3,t0);
        t0=gr(2,3)-1;
        gw(2,3,gr(2,3)-1);
        t0=(t0!=0)?0:1;
        if((t0)!=0)goto _4;else goto _2;
    _4:
        sa(sp()-1L);

        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _5;else goto _1;
    _5:
        gw(3,3,199);
        sp();
        t0=gr((tm(gr(3,3),100))+1,td(gr(3,3),100))-48;
    _6:
        t1=gr(3,3);
        gw(3,3,gr(3,3)-1);
        t1=(t1!=0)?0:1;

        if((t1)!=0)goto _7;else goto _8;
    _7:
        System.Console.Out.Write(t0);
        return;
    _8:
        t0+=gr((tm(gr(3,3),100))+1,td(gr(3,3),100))-48;
        goto _6;
}
}
