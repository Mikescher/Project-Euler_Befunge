/* transpiled with BefunCompile v1.3.0 (c) 2017 */
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
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0;
        gw(0,0,48);
        gw(0,1,48);
        gw(0,2,48);
        gw(0,3,48);
        gw(0,4,48);
        gw(0,5,48);
        gw(1,6,60);
        gw(2,6,6);
        gw(0,6,360);
        gw(4,6,1000);
    _1:
        t0=gr(4,6);

        if((gr(4,6))!=0)goto _6;else goto _2;
    _2:
        gw(6,6,gr(0,6)-1);
        t0=gr(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6)))-48;
    _3:
        if((gr(6,6))!=0)goto _4;else goto _5;
    _4:
        gw(6,6,gr(6,6)-1);
        t0+=gr(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6)))-48;
        goto _3;
    _5:
        System.Console.Out.Write(t0+" ");
        return;
    _6:
        t0--;
        gw(4,6,t0);
        gw(6,6,gr(0,6)-1);
        gw(7,6,0);
    _7:
        if((gr(6,6))!=0)goto _8;else goto _1;
    _8:
        t0=(((gr(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6)))-48)*2)+gr(7,6))/10;
        gw(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6)),((((gr(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6)))-48)*2)+gr(7,6))%10)+48);
        gw(7,6,t0);
        gw(6,6,gr(6,6)-1);
        goto _7;
}
}
