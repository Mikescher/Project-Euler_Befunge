/* transpiled with BefunCompile v1.3.0 (c) 2017 */
public static class Program
{
private static readonly string _g = "AR+LCAAAAAAABAClks1yhCAMx18FcG8MFvxYjeMwfYO97qGj3rhy4rQPvwkq2g720GYGiJL880s0MPZktIpk7Moo8JEsF2HFIAKe4VKDsZGNIR4Y5o0EJbRwWoLX9aCM"+
                                    "07V4iDXOgsaX2ttaO5DaGTWsnscUNXR4+7W8YjFMm6eCpyIKRRyKO93F52K82aEIc6ddu/wCZ19BmZEk51DwBWXhlm0iqkUXJUHxXBCbWFRbJ/MUFCmNxxlhG0ZiM56a"+
                                    "mfA2qoHGJsHQVuEmZWv8SX1TszFCfAjFoE8e7F7Y1ACfcUqYn+93UwsKs3D8HbDNuyevB/pKGxsRQU1bs7E5xfmKJw+2eyJqktf+k61ORFXymjMblYpVYvlLtioRHRPU"+
                                    "f2Q77JOVZflz7WwRCDra+gwaqfUwZgt9N0sSsP8fu84JlsdO3+lgHQ7PAwAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<39&&y<25)?g[y*39+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<39&&y<25)g[y*39+x]=v;}
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
static void Main(string[]args)
{
        long t0,t1;
        gw(9,0,58);
        gw(3,0,0);
    _1:
        t0=gr(gr(3,0)+9,0)-49;
        t1=gr(gr(3,0)+9,0)-49;
        gw(gr(3,0)+9,0,gr(gr(3,0)+9,0)-1);
        gw(7,0,t1);
        t0=t0<0?1:0;

        if((t0)!=0)goto _2;else goto _3;
    _2:
        sa(79);
        sa(gr(3,0)+8);
        gw(3,0,gr(3,0)-1);
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-48L);

        sa(sp()+9L);

        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _1;
    _3:
        if(gr(gr(7,0)+9,1)!=79)goto _1;else goto _4;
    _4:
        sa(gr(3,0));

        if((gr(3,0))!=0)goto _5;else goto _25;
    _5:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _6;else goto _24;
    _6:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _7;else goto _23;
    _7:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _8;else goto _20;
    _8:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _9;else goto _22;
    _9:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _10;else goto _20;
    _10:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _11;else goto _21;
    _11:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _12;else goto _20;
    _12:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _19;else goto _13;
    _13:
        sa((((gr(15,0)+gr(16,0)+gr(17,0))-gr(5,1)!=0)?1:0)+((gr(7,0)-9!=0)?0L:1L));
    _14:
        if(sp()!=0)goto _18;else goto _15;
    _15:
        sp();

        if(9>gr(3,0))goto _16;else goto _17;
    _16:
        gw(gr(7,0)+9,1,88);
        sa(58);
        sa(gr(3,0)+10);
        gw(3,0,gr(3,0)+1);
        sa(0);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _1;
    _17:
        System.Console.Out.Write(gr(9,0)-47+" ");
        System.Console.Out.Write(gr(10,0)-47+" ");
        System.Console.Out.Write(gr(11,0)-47+" ");
        System.Console.Out.Write(gr(12,0)-47+" ");
        System.Console.Out.Write(gr(11,0)-47+" ");
        System.Console.Out.Write(gr(13,0)-47+" ");
        System.Console.Out.Write(gr(14,0)-47+" ");
        System.Console.Out.Write(gr(13,0)-47+" ");
        System.Console.Out.Write(gr(15,0)-47+" ");
        System.Console.Out.Write(gr(16,0)-47+" ");
        System.Console.Out.Write(gr(15,0)-47+" ");
        System.Console.Out.Write(gr(17,0)-47+" ");
        System.Console.Out.Write(gr(18,0)-47+" ");
        System.Console.Out.Write(gr(17,0)-47+" ");
        System.Console.Out.Write(gr(10,0)-47+" ");
        return;
    _18:
        sp();
        goto _1;
    _19:
        sa((((gr(17,0)+gr(18,0)+gr(10,0))-gr(5,1)!=0)?1:0)+((gr(9,0)-48)>gr(7,0)?1L:0L));
        goto _14;
    _20:
        sa((gr(9,0)-48)>gr(7,0)?1:0);
        goto _14;
    _21:
        sa((((gr(13,0)+gr(14,0)+gr(15,0))-gr(5,1)!=0)?1:0)+((gr(7,0)-9!=0)?0L:1L));
        goto _14;
    _22:
        sa((((gr(11,0)+gr(12,0)+gr(13,0))-gr(5,1)!=0)?1:0)+((gr(7,0)-9!=0)?0L:1L));
        goto _14;
    _23:
        gw(5,1,gr(9,0)+gr(10,0)+gr(11,0));
        sa((gr(7,0)-9!=0)?0:1);
        goto _14;
    _24:
        sa((gr(7,0)-9!=0)?0:1);
        goto _14;
    _25:
        sa(gr(7,0)>5?1:0);
        goto _14;
}
}
