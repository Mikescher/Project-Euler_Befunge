/* compiled with BefunCompile v1.0.7 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABAC9VMtqw0AM/JUh7SnGRVp5X6GYfkhJevPVp3x/R17ogxjaErvCOCvh7OxoRguM0Y4QmUUm7QN/VeZRZbLjKbDUTQc59DF2x1ftPgsdv1iyWf194p+Y"+
                                    "9to/XC9cnD62Yn7FbeS4UsR5rfjLeL7J13BrRBpuqmtfbncSD80YMkq4e/MRj385rRZYRMlQ+boJxQ59E20RuwnbFqGjfJ63NfqTvI0P50s/fhOdEjd5m9w0y9xy0enp"+
                                    "JQhkcL5knVa1vkvsNbkb3wpRBHODicFutd4nSoEE5IxsEFI2pPwfuLV6e9nqwAMkaEIW1Ptt9lMM6k9IiAnFMAiKOLTZ/rgFOTgQrWVcZGdd2YG6I26kowg9eLdDxGCo"+
                                    "ihhQM6JCd7MZW6rqZKlvcxdvksyhpu7F13Efm5FdXgjagkKCrJB1LIiCkL3bFGLz8MFJ7meyK9XbzjkyWYgnpOpXGc1mujGuI1LNslDjCNdljorjVvMm+EmWOy1s6vB3"+
                                    "lpN0goAHAAA=";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<120&&y<16)?g[y*120+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<120&&y<16)g[y*120+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        long t0,t1;
        gw(0,0,15);
        gw(2,0,gr(0,0)-1);
        gw(1,0,0);
    _1:
        gw(gr(1,0),gr(2,0)+1,((gr(gr(1,0)*3,gr(2,0)+1)-48)*10)+(gr((gr(1,0)*3)+1,gr(2,0)+1)-48));
        t0=gr(1,0)+1;
        gw(1,0,gr(1,0)+1);
        t0=t0-gr(2,0);
        t0=t0-1;
        if((t0)!=0)goto _1;else goto _3;
    _3:
        t0=gr(2,0);
        gw(2,0,gr(2,0)-1);
        gw(1,0,0);
        if((t0)!=0)goto _1;else goto _4;
    _4:
        t0=gr(0,0)-2;
        gw(1,0,gr(0,0)-2);
        gw(2,0,t0);
    _5:
        sa(gr(gr(1,0),gr(2,0)+1));
        sa(gr(gr(1,0),gr(2,0)+2));
        t0=gr(gr(1,0),gr(2,0)+2)-gr(gr(1,0)+1,gr(2,0)+2);
        if((gr(gr(1,0),gr(2,0)+2)-gr(gr(1,0)+1,gr(2,0)+2))>0)goto _6;else goto _9;
    _6:
        sa(sp()+sp());
        t0=sp();
        gw(gr(1,0),gr(2,0)+1,t0);
        t0=gr(1,0);
        gw(1,0,gr(1,0)-1);
        if((t0)!=0)goto _5;else goto _7;
    _7:
        t0=gr(2,0);
        t1=gr(2,0)-1;
        gw(2,0,gr(2,0)-1);
        gw(1,0,t1);
        if((t0)!=0)goto _5;else goto _8;
    _8:
        System.Console.Out.Write(gr(0,1));
        return;
    _9:
        sa(sp()-t0);
        goto _6;
}}