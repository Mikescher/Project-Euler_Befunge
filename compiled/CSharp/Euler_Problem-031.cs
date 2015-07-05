/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABAClUUFqxDAQ+4pJ9zQmRRpvdjfBmD6khB4Kc52TT3l8nW4CbSGFbnWwPTPIkuX6tCP8HY+x/o2CHYQrPMHP8AF+gV/hN/gID6F771RCIH1UOhI9oNaH"+
                                    "VU/5W1kdTp0ijYo2KqaDSLzCBok3mEocYXHXK0qDMa6br8XYb5OlsHGaWRFttM9DbGuqZSLt9W3x4yTmMF+iyHkwDFE67QznKIZcN7cztWc+vOD+lG2+e81Lb2S4d5df"+
                                    "iD2nvBimFkF2pjWL9FWrnBLt+eXYPvv2M2H+0f4AZyRUOpQCAAA=";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<60&&y<11)?g[y*60+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<60&&y<11)g[y*60+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(1L,0L,0L);
        gw(2L,0L,0L);
        gw(3L,0L,0L);
        gw(4L,0L,0L);
        gw(5L,0L,0L);
        gw(6L,0L,0L);
        gw(7L,0L,0L);
        gw(8L,0L,0L);
        gw(9L,0L,0L);
        gw(1L,1L,200L);
        gw(2L,1L,9L);
        gw(3L,1L,0L);
        gw(gr(2L,1L),0L,gr(gr(2L,1L),0L)+1L);
    _1:
        if(gr(2L,1L)!=9L)goto _11;else goto _2;
    _2:
        sa((gr(1L,0L)*500L)+(gr(2L,0L)*200L)+(100L*gr(3L,0L))+(gr(4L,0L)*50L)+(gr(5L,0L)*20L)+(gr(6L,0L)*10L)+(gr(7L,0L)*5L)+(gr(8L,0L)*2L)+gr(9L,0L));
        if(((gr(1L,0L)*500L)+(gr(2L,0L)*200L)+(100L*gr(3L,0L))+(gr(4L,0L)*50L)+(gr(5L,0L)*20L)+(gr(6L,0L)*10L)+(gr(7L,0L)*5L)+(gr(8L,0L)*2L)+gr(9L,0L))<gr(1L,1L))goto _10;else goto _3;
    _3:
        sa(sp()-gr(1L,1L));
        if(sp()!=0)goto _4;else goto _9;
    _4:
        sa(gr(2L,1L));
        if((gr(gr(2L,1L),0L))!=0)goto _6;else goto _5;
    _5:
        sa(sp()-1L);
        gw(2L,1L,sp());
        goto _4;
    _6:
        if(sr()!=1L)goto _8;else goto _7;
    _7:
        sp();
        System.Console.Out.Write((long)(gr(3L,1L)));
        return;
    _8:
        sa(sp()-1L);
        gw(2L,1L,sp());
        gw(gr(2L,1L),0L,gr(gr(2L,1L),0L)+1L);
        goto _1;
    _9:
        gw(3L,1L,gr(3L,1L)+1L);
        goto _4;
    _10:
        gw(gr(2L,1L),0L,gr(gr(2L,1L),0L)+1L);
        sp();
        goto _1;
    _11:
        sa(0L);
        sa(gr(2L,1L)+1L);
        gw(2L,1L,gr(2L,1L)+1L);
        sa(0L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _1;
}}