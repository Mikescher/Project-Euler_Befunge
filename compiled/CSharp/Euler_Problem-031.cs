/* compiled with BefunCompile v1.0.4 (c) 2015 */
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
        goto _1;
    _0:
        if(((gr(2,1))-(9))!=0)goto _7;else goto _9;
    _1:
        gw(1,0,0);
        gw(2,0,0);
        gw(3,0,0);
        gw(4,0,0);
        gw(5,0,0);
        gw(6,0,0);
        gw(7,0,0);
        gw(8,0,0);
        gw(9,0,0);
        gw(1,1,200);
        gw(2,1,9);
        gw(3,1,0);
        gw(gr(2,1),0,(gr(gr(2,1),0))+(1));
        goto _0;
    _2:
        gw(gr(2,1),0,(gr(gr(2,1),0))+(1));
        sp();
        goto _0;
    _3:
        gw(3,1,(gr(3,1))+(1));
        goto _11;
    _4:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        gw(2,1,sp());
        goto _11;
    _5:
        sp();
        System.Console.Out.Write((long)(gr(3,1)));
        return;
    _6:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        gw(2,1,sp());
        gw(gr(2,1),0,(gr(gr(2,1),0))+(1));
        goto _0;
    _7:
        sa(0);
        sa((gr(2,1))+(1));
        gw(2,1,(gr(2,1))+(1));
        sa(0);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _0;
    _8:
        sa(gr(1,1));
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _11; else goto _3;
    _9:
        sa((((((((((gr(1,0))*(500))+((gr(2,0))*(200)))+((100)*(gr(3,0))))+((gr(4,0))*(50)))+((gr(5,0))*(20)))+((gr(6,0))*(10)))+((gr(7,0))*(5)))+((gr(8,0))*(2)))+(gr(9,0)));
        if(((gr(1,1))>((((((((((gr(1,0))*(500))+((gr(2,0))*(200)))+((100)*(gr(3,0))))+((gr(4,0))*(50)))+((gr(5,0))*(20)))+((gr(6,0))*(10)))+((gr(7,0))*(5)))+((gr(8,0))*(2)))+(gr(9,0)))?1:0)!=0)goto _2;else goto _8;
    _10:
        sa(sr());
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _6; else goto _5;
    _11:
        sa(gr(2,1));
        if((gr(gr(2,1),0))!=0)goto _10;else goto _4;
}}