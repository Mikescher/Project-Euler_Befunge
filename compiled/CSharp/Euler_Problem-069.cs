/* transpiled with BefunCompile v1.1.0 (c) 2015 */
public static class Program
{
private static readonly string _g = "AR+LCAAAAAAABADlUE1rwzAM/SvCTS8OaaTmc8aEXnbvcYfgho0gGB0VZfOp/e9TtpX2kELve2CBZOk9PUX8ASjyHLbHw/v49gnPX/vxCNmUv+7HD6if4EEs/hni7BU6"+
                                    "qZAprVDm/+ewWTE2fr4/EKP/ZS4mYleglMjZ5ehxZ87njbG2RtEcO0fcINuYdNSgmK1xhFK4NYotUdY6HkPFWOzCIjNgOKWckfqlBqdlL6i7Y/EnCiElH7F2PomCrW2t"+
                                    "dW56rRAJoVMK/4hHlRuUnrH00PEAcOrMi1FLuh4vew05paL5ZDN1arEfrh6Tq/nbflb17BQARO93RzjIrcNeJ5y2hvubXoi+AR19dk8gAwAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<80&&y<10)?g[y*80+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<80&&y<10)g[y*80+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0;
        gw(7,0,1);
        gw(1,0,80);
        gw(2,0,3);
        gw(4,0,240);
        gw(3,0,2);
    _1:
        gw(0,1,32);
        gw(1,1,32);
        gw(8,0,1073741824);
        gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+1,88);
        sa(gr(3,0)+gr(3,0));
        sa((gr(3,0)+gr(3,0))<gr(4,0)?1:0);
    _2:
        if(sp()!=0)goto _15;else goto _3;
    _3:
        sp();
    _4:
        sa(gr(3,0)+1);
        gw(3,0,gr(3,0)+1);
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));

        sa(sp()+1L);

        {long v0=sp();t0=gr(sp(),v0);}
        t0-=32;
        if((t0)!=0)goto _6;else goto _4;
    _6:
        if(gr(4,0)>gr(3,0))goto _1;else goto _7;
    _7:
        gw(3,0,0);
        gw(5,0,0);
    _8:
        if(gr(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+1)!=32)goto _14;else goto _9;
    _9:
        t0=gr(3,0)+1;
        gw(3,0,gr(3,0)+1);
        t0-=gr(4,0);

        if((t0)!=0)goto _8;else goto _10;
    _10:
        gw(6,0,1000000);
        sa(0);
        sa(gr(0,1)*gr(7,0));
        sa((gr(0,1)*gr(7,0))>gr(6,0)?1:0);
    _11:
        if(sp()!=0)goto _13;else goto _12;
    _12:
        gw(7,0,sp());
        sa(sp()+1L);

        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()*gr(7,0));

        sa(sr()>gr(6,0)?1:0);
        goto _11;
    _13:
        System.Console.Out.Write(gr(7,0));
        sp();
        sp();
        return;
    _14:
        gw(gr(5,0),1,gr(3,0));
        gw(5,0,gr(5,0)+1);
        goto _9;
    _15:
        sa(sr());
        sa(32);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));

        sa(sp()+1L);

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+gr(3,0));

        sa(sr()<gr(4,0)?1:0);
        goto _2;
}
}
