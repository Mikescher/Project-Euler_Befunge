/* compiled with BefunCompile v1.0.3 (c) 2015 */
public static class Program 
{
private static readonly string _g = "Ah+LCAAAAAAABACT7+ZgAAEWhre3DuZddhBguBBfKPt9ksnZXWpdSVNFxd/JVG+YxLVCZ6HSGq6aV8c36/Gqdjg4tK54ZHvy2jrjbPXlJ9csP79v1tlN4eby92L3/pyx"+
                                    "909Jbelk3/afr1+v/h659QTY+Ia5bgyjYBSMgiEPDtRrMzPM2zNj/9n5Z48/3sVz16b3+NfIF8cUS9JDX3zSWe98dWrodf6NtRFnVm/eEHmrNdXC/o45O4PZr7+Hyp68"+
                                    "/ZpVcrNtFa+QNYNMwBn9T1pbVtrk988umRU6We9sspVaKUducaW8xavrRwu2zrmysui/2T7f1D9fvk2wZ2LoOH3h2fnNf548+XL02a1Vs0M2m005W2h19eyGj/O0Plx9"+
                                    "N3vFecYHBd/u5O//3F+0bT8bw4fj24yq71z9Mc9O419QcI39qWVLU/gY+pd5uN/ZX9bv+tngZvbNSrHXv0rs5s/RcbaObHtXbsbF0KC70U7q62vXF9MMV4sv9JUsq7nP"+
                                    "UT7b6F3Y7duudrJrr5XOTZp1ekuWxJlTancTt8q1nd2w42X9ljXx5l9tSo5/3q1+ZtYvs7rrjuKzI6Yf/ts9f89SdoayzqPTy3aEaOZbPWqb86t77fsImx731YurjP88"+
                                    "3BQh8jCx6HvLDlnFbuYDkzdpdR+qLmKosJnPeCvsc9KC9fwMAD1IlPqhBQAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<2000&&y<514)?g[y*2000+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<2000&&y<514)g[y*2000+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static readonly System.Random r = new System.Random();
private static bool rd(){ return r.Next(2)!=0; }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        goto _13;
    _0:
        if(sp()!=0)goto _15; else goto _16;
    _1:
        if(sp()!=0)goto _18; else goto _17;
    _2:
        if(sp()!=0)goto _14; else goto _19;
    _3:
        if(sp()!=0)goto _37; else goto _20;
    _4:
        if(sp()!=0)goto _25; else goto _21;
    _5:
        if(sp()!=0)goto _21; else goto _26;
    _6:
        if(sp()!=0)goto _23; else goto _24;
    _7:
        if(sp()!=0)goto _27; else goto _31;
    _8:
        if(sp()!=0)goto _30; else goto _29;
    _9:
        if(sp()!=0)goto _32; else goto _36;
    _10:
        if(sp()!=0)goto _28; else goto _34;
    _11:
        if(sp()!=0)goto _33; else goto _35;
    _12:
        if(sp()!=0)goto _32; else goto _36;
    _13:
        gw(1,0,2000);
        gw(2,0,500);
        gw(0,0,1000000);
        gw(3,0,2);
        gw(0,3,32);
        gw(1,3,32);
        goto _14;
    _14:
        gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+(3),88);
        sa((gr(3,0))+(gr(3,0)));
        sa((gr(0,0))>((gr(3,0))+(gr(3,0)))?1:0);
        goto _0;
    _15:
        sa(sr());
        sa(32);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(3);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(gr(3,0));
        sa(sp()+sp());
        sa(sr());
        sa(gr(0,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _0;
    _16:
        sp();
        goto _17;
    _17:
        sa((gr(3,0))+(1));
        gw(3,0,(gr(3,0))+(1));
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(3);
        sa(sp()+sp());
        {long v0=sp();sa(gr(sp(),v0));}
        sa(32);
        {long v0=sp();sa(sp()-v0);}
        goto _1;
    _18:
        sa((gr(0,0))>(gr(3,0))?1:0);
        goto _2;
    _19:
        gw(9,0,0);
        sa(0);
        sa(2);
        sa(3);
        sa(5);
        sa(7);
        sa(0);
        goto _3;
    _20:
        gw(7,0,sp());
        sa(9);
        sa((9)+((gr(7,0))*(10)));
        sa((gr(0,0))>((9)+((gr(7,0))*(10)))?1:0);
        goto _4;
    _21:
        sp();
        goto _22;
    _22:
        sa(sr());
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        goto _6;
    _23:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa((gr(7,0))*(10));
        sa(sp()+sp());
        sa(sr());
        sa(gr(0,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _4;
    _24:
        sp();
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _3;
    _25:
        sa(sr());
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(3);
        sa(sp()+sp());
        {long v0=sp();sa(gr(sp(),v0));}
        sa(88);
        {long v0=sp();sa(sp()-v0);}
        goto _5;
    _26:
        sa(sr());
        sa(sr());
        sa(10);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _7;
    _27:
        sp();
        sa((sp()!=0)?0:1);
        sa(sr());
        goto _28;
    _28:
        sp();
        sp();
        sa(0);
        goto _8;
    _29:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _22;
    _30:
        sa(sr());
        sa(sr());
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((char)(10));
        sa(gr(9,0));
        sa(sp()+sp());
        gw(9,0,sp());
        goto _29;
    _31:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _9;
    _32:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _33;
    _33:
        sa(sr());
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(3);
        sa(sp()+sp());
        {long v0=sp();sa(gr(sp(),v0));}
        sa(88);
        {long v0=sp();sa(sp()-v0);}
        goto _10;
    _34:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        gw(5,0,sp());
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(td(gr(5,0),10));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _11;
    _35:
        sp();
        sp();
        sa(1);
        goto _8;
    _36:
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _12;
    _37:
        sp();
        sa(61);
        System.Console.Out.Write((char)(32));
        System.Console.Out.Write((char)(sp()));
        System.Console.Out.Write((long)(gr(9,0)));
        return;
}}