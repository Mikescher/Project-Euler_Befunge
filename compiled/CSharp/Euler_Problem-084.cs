/* compiled with BefunCompile v1.0.8 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABACtVMFy4yAM/RXVuLMzMN4FDGnCUKWf0YOH9uarT5zcf18JO8ROsrs9rA5PSAEhPT+SAeD9Hf6XvX7TeG9ejsSCOd4XO3/T6HAsJWKcu+apCeTU6Rg2"+
                                    "JVE7PTVfX2+NlP4o8+4ejj6ygM5ErmJ0yRmNS4ulTJzj7ZGLPeicK8AcVLTnJKQrrr3uS/sjaLpglR7MtO/rxlIfN25j3TaYw74vRMwLbCgucXXVs9nNjO3tTcYyMQwi"+
                                    "TdpF5X0btSl0rG7xa73aC6DTY6ApzWjUQG5Ckc79AkrRJ3kO9IU4tuhkceriZwz+ILv5OuMDdtClHAlA1Dkp7lP5bXHV7w+2/pj3xEcefe7kyRUpSbssXsJKagYavsy+"+
                                    "ZZpNZJBxz2/a7KgbH2jm3gp7Lez4FUvh5bPlOxC3uarUIpI9vxBmlh4BdHX5NwCxFjMcBpt3/KL3KqM/AOHByYzNj4bizK8vw+YtLc2TIPquRHOYrIKIIRhlR9bIAJZW"+
                                    "BAZGGD7/yFCuuqXO8GDpYWNbUokedIidmewwgvbKQugMTFx3AL4DQqBQe7qAjNLhIwluyp2sVFVsqEl8R0lNzCwVa2H82TM4YHy7a4lLHJ5pkF9WekmMtJR7cetfTqKL"+
                                    "mQQUMV3IRFHxAtdgnW7VC17mTg8E9A9x3Wcp0/Ir/g3VSFYoBAYAAA==";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<77&&y<20)?g[y*77+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<77&&y<20)g[y*77+x]=v;}
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
        long t0,t1,t2;
        gw(4,0,0);
        gw(41,1,0);
        sa(1000000);
        sa(38);
    _1:
        sa(sr()+2);
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        if(sp()!=0)goto _97;else goto _2;
    _2:
        sp();
    _3:
        sa(gr(4,0));
        gw(gr(4,0)+2,1,gr(gr(4,0)+2,1)+1);
        if(rd()){if(rd()){goto _96;}else{goto _95;}}else{if(rd()){goto _94;}else{goto _5;}}
    _5:
        sa(2);
    _6:
        if(rd()){if(rd()){goto _93;}else{goto _92;}}else{if(rd()){goto _91;}else{goto _7;}}
    _7:
        sa(sp()+3L);
    _8:
        sa(sp()+sp());
        sa(tm(sp(),40));
        sa(sr());
        gw(4,0,sp());
        if(rd()){if(rd()){goto _90;}else{goto _89;}}else{if(rd()){goto _88;}else{goto _10;}}
    _10:
        sa(8);
    _11:
        if(rd()){if(rd()){goto _87;}else{goto _86;}}else{if(rd()){goto _85;}else{goto _12;}}
    _12:
        sa(sp()+2L);
    _13:
        sa(sp()*4L);
        if(rd()){if(rd()){goto _84;}else{goto _83;}}else{if(rd()){goto _82;}else{goto _15;}}
    _15:
        sa(sp()+2L);
    _16:
        if(sp()!=0)goto _28;else goto _17;
    _17:
        gw(4,0,10);
        sp();
    _18:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _3;else goto _19;
    _19:
        gw(41,2,39);
        sp();
        sa(38);
    _20:
        sa(sr());
        sa(sr()+2);
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        if(sp()!=0)goto _27;else goto _21;
    _21:
        sp();
        sa(0);
    _22:
        sa(sr());
        if(sp()!=0)goto _25;else goto _23;
    _23:
        sa(sp()+1L);
        if(sr()<40)goto _22;else goto _24;
    _24:
        System.Console.Out.Write(gr(2,2));
        System.Console.Out.Write(gr(3,2));
        System.Console.Out.Write(gr(4,2));
        sp();
        return;
    _25:
        sa(sr());
        sa(sr()+1);
        sa(2);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()+2L);
        sa(1);
        {long v0=sp();t0=gr(sp(),v0);}
        sa(sp()+2L);
        sa(2);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()+2L);
        sa(1);
        {long v0=sp();t1=gr(sp(),v0);}
        t2=t0<t1?1:0;
        if((t2)!=0)goto _26;else goto _23;
    _26:
        sa(sr()+2);
        sa(2);
        {long v0=sp();t0=gr(sp(),v0);}
        gw(5,0,t0);
        sa(sr());
        sa(sr()+1);
        sa(2);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+2L);
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()-1L);
        sa(sr()+2);
        sa(gr(5,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()-1L);
        goto _22;
    _27:
        sa(sp()-1L);
        goto _20;
    _28:
        if(sr()!=30)goto _29;else goto _17;
    _29:
        if(sr()!=2)goto _44;else goto _30;
    _30:
        sp();
        if(rd()){if(rd()){goto _43;}else{goto _42;}}else{if(rd()){goto _41;}else{goto _32;}}
    _32:
        sa(8);
    _33:
        if(rd()){if(rd()){goto _40;}else{goto _39;}}else{if(rd()){goto _38;}else{goto _34;}}
    _34:
        sa(sp()+2L);
    _35:
        sa(sr());
        if(sp()!=0)goto _36;else goto _17;
    _36:
        sa(sp()-1L);
        if(sp()!=0)goto _18;else goto _37;
    _37:
        gw(4,0,0);
        goto _18;
    _38:
        sa(sp()+1L);
        goto _35;
    _39:
        sa(sp()+0L);
        goto _35;
    _40:
        sa(sp()+3L);
        goto _35;
    _41:
        sa(4);
        goto _33;
    _42:
        sa(0);
        goto _33;
    _43:
        sa(12);
        goto _33;
    _44:
        if(sr()!=17)goto _45;else goto _30;
    _45:
        if(sr()!=33)goto _46;else goto _30;
    _46:
        if(sr()!=7)goto _80;else goto _47;
    _47:
        sp();
        if(rd()){if(rd()){goto _79;}else{goto _78;}}else{if(rd()){goto _77;}else{goto _49;}}
    _49:
        sa(8);
    _50:
        if(rd()){if(rd()){goto _76;}else{goto _75;}}else{if(rd()){goto _74;}else{goto _51;}}
    _51:
        sa(sp()+2L);
    _52:
        sa(sr());
        if(sp()!=0)goto _53;else goto _73;
    _53:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _54;else goto _72;
    _54:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _55;else goto _71;
    _55:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _56;else goto _70;
    _56:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _57;else goto _69;
    _57:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _58;else goto _68;
    _58:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _59;else goto _67;
    _59:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _60;else goto _67;
    _60:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _61;else goto _64;
    _61:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _62;else goto _63;
    _62:
        sp();
        goto _18;
    _63:
        gw(4,0,gr(4,0)-3);
        goto _62;
    _64:
        if(gr(4,0)!=22)goto _65;else goto _66;
    _65:
        gw(4,0,12);
        goto _62;
    _66:
        gw(4,0,28);
        goto _62;
    _67:
        gw(4,0,(10*(td((tm(gr(4,0),6))+1,2)))+5);
        goto _62;
    _68:
        gw(4,0,0);
        goto _62;
    _69:
        gw(4,0,5);
        goto _62;
    _70:
        gw(4,0,39);
        goto _62;
    _71:
        gw(4,0,24);
        goto _62;
    _72:
        gw(4,0,11);
        goto _62;
    _73:
        gw(4,0,10);
        goto _62;
    _74:
        sa(sp()+1L);
        goto _52;
    _75:
        sa(sp()+3L);
        goto _52;
    _76:
        sa(sp()+0L);
        goto _52;
    _77:
        sa(4);
        goto _50;
    _78:
        sa(12);
        goto _50;
    _79:
        sa(0);
        goto _50;
    _80:
        if(sr()!=22)goto _81;else goto _47;
    _81:
        if(sr()!=36)goto _62;else goto _47;
    _82:
        sa(sp()+1L);
        goto _16;
    _83:
        sa(sp()+3L);
        goto _16;
    _84:
        sa(sp()+0L);
        goto _16;
    _85:
        sa(sp()+1L);
        goto _13;
    _86:
        sa(sp()+3L);
        goto _13;
    _87:
        sa(sp()+0L);
        goto _13;
    _88:
        sa(4);
        goto _11;
    _89:
        sa(12);
        goto _11;
    _90:
        sa(0);
        goto _11;
    _91:
        sa(sp()+2L);
        goto _8;
    _92:
        sa(sp()+1L);
        goto _8;
    _93:
        sa(sp()+4L);
        goto _8;
    _94:
        sa(1);
        goto _6;
    _95:
        sa(4);
        goto _6;
    _96:
        sa(3);
        goto _6;
    _97:
        sa(sp()-1L);
        goto _1;
}}