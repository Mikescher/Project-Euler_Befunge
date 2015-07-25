/* compiled with BefunCompile v1.0.7 (c) 2015 */
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
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        long t0;
        gw(1,0,2000);
        gw(2,0,500);
        gw(0,0,1000000);
        gw(3,0,2);
        gw(0,3,32);
        gw(1,3,32);
    _1:
        gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88);
        sa(gr(3,0)+gr(3,0));
        sa((gr(3,0)+gr(3,0))<gr(0,0)?1:0);
    _2:
        if(sp()!=0)goto _27;else goto _3;
    _3:
        sp();
    _4:
        sa(gr(3,0)+1);
        gw(3,0,gr(3,0)+1);
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));
        sa(sp()+3L);
        {long v0=sp();t0=gr(sp(),v0);}
        t0=t0-32;
        if((t0)!=0)goto _6;else goto _4;
    _6:
        if(gr(0,0)>gr(3,0))goto _1;else goto _7;
    _7:
        gw(9,0,0);
        sa(0);
        sa(2);
        sa(3);
        sa(5);
        sa(7);
    _8:
        gw(7,0,sp());
        sa(9);
        sa(9+(gr(7,0)*10));
        sa((9+(gr(7,0)*10))<gr(0,0)?1:0);
    _9:
        if(sp()!=0)goto _10;else goto _26;
    _10:
        sa(sr());
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));
        sa(sp()+3L);
        {long v0=sp();t0=gr(sp(),v0);}
        t0=t0-88;
        if((t0)!=0)goto _26;else goto _11;
    _11:
        sa(sr());
        if(sr()<10)goto _12;else goto _19;
    _12:
        sp();
        sa((sp()!=0)?0:1);
        sa(sr());
    _13:
        sp();
        sp();
    _14:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    _15:
        if(sr()!=1)goto _18;else goto _16;
    _16:
        sp();
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _17;else goto _8;
    _17:
        System.Console.Out.Write(" =");
        System.Console.Out.Write(gr(9,0));
        sp();
        return;
    _18:
        sa(sp()-1L);
        sa(sr()+gr(7,0)*10);
        sa(sr()<gr(0,0)?1:0);
        goto _9;
    _19:
        sa(td(sr(),10));
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa((sp()!=0)?0:1);
    _20:
        if(sp()!=0)goto _22;else goto _21;
    _21:
        sa(td(sp(),10));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*10L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _20;
    _22:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    _23:
        sa(sr());
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));
        sa(sp()+3L);
        {long v0=sp();t0=gr(sp(),v0);}
        t0=t0-88;
        if((t0)!=0)goto _13;else goto _24;
    _24:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        gw(5,0,sp());
        {long v0=sp();sa(tm(sp(),v0));}
        sa(td(gr(5,0),10));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        if(sp()!=0)goto _23;else goto _25;
    _25:
        sp();
        sp();
        System.Console.Out.Write('\n');
        sa(sr());
        sa(sr());
        System.Console.Out.Write((long)(sp()));
        sa(sp()+gr(9,0));
        gw(9,0,sp());
        goto _14;
    _26:
        sp();
        goto _15;
    _27:
        sa(sr());
        sa(32);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));
        sa(sp()+3L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+gr(3,0));
        sa(sr()<gr(0,0)?1:0);
        goto _2;
}}