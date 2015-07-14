/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABADdVMGO4yAM/RW3yV5AbDGQNkEIjfYDttfOKEr3xpUTp+6/r03SadrRaKRqTmspNQXbvPfspLy+vgJb82DwpJ1+nU7fWe/t7e1b8f1+NvETOx6P1X8X"+
                                    "vqv9R/UKDN5nJ4cxdZKXyEtDSwjP1Ityn8ZBdtmjGjdFw6rMM/VmjIu1Z+8HiXyBzn76Iq0mnkujxPbvts9oPaWibR8AzbfzZty+wNYLL4TBbC1mjTb3Pcjoe6nHvuKI"+
                                    "iOnnS2XazyQvtFbGpJ0x2XZiWl+/WNbGUzVN14c2nKdm4xXmeyDTorsPDUzCJ8Ngs0FFK5HAmFCoRNKWKSWNnj2EtQqh0F4trUcte2rmqClCdDZjpX6+3QaQorcko9GQ"+
                                    "xp00Ow9Wp1W5eKNO7WTn2NWIWCP+LNGxbaEt5j3x6lsq6B1mLywmxTq1uHcCM/86YmMykmikk+Yj6QfVq5pKomo7rWSj9tXu3bG93tOAbaBrQNReNnQwkcZepV6+iwqh"+
                                    "LSyEsbtkjKzyuvtJuPajha+NOE7R8zhqHkdM1iQh0SbpCzW+s6vmXjajQp+cuY5e5LwD5w1JLTH8cFgmuOOPhAayxR37QCMaZ0waHY0YiMj3jlAuGzUkZ6nhB3Kcld2c"+
                                    "5GUKpH8nKkZX38kbxrIiGUU0wGVFBWZckg3slXV5kCbRX3YlYjnEz2pBeKA4MzlcNXh8UxvWWqU5ar/wXej6EJeYyrFcgDjCTHK4J0kceScUFOEyBkcjhAuRtU0ris0Q"+
                                    "gTgCkVwo7meK+0QjKgTSwRTpGKT97PtS92m+KvoAU/fhk/Ixo0b8A6X0qdzQBwAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<80&&y<25)?g[y*80+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<80&&y<25)g[y*80+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(2L,1L,67108864L);
        gw(3L,1L,3L);
        gw(1L,3L,0L);
        gw(24L,8L,0L);
        sa(15L);
    _1:
        sa(sr()+8L);
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(8L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()-1L);
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _3;else goto _1;
    _3:
        sp();
    _4:
        sa(gr(3L,1L));
        gw(1L,0L,0L);
        sa(sr());
        gw(2L,0L,sp());
    _5:
        sa(sr());
        gw(3L,0L,sp());
        sa(sr());
        sa(gr(2L,0L));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(td(sp(),v0));}
        sa(sp()+sp());
        sa(td(sp(),2L));
        if(sr()!=gr(3L,0L))goto _54;else goto _6;
    _6:
        sp();
        sa(gr(3L,0L));
        gw(4L,1L,gr(3L,0L));
        sa(sr());
        sa(sp()*sp());
        sa(sp()-gr(3L,1L));
        if(sp()!=0)goto _7;else goto _53;
    _7:
        gw(24L,5L,0L);
        gw(24L,4L,0L);
        gw(24L,1L,0L);
        gw(24L,0L,0L);
        sa(15L);
    _8:
        sa(sr()+8L);
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(5L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()+8L);
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(4L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()+8L);
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()+8L);
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(0L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()-1L);
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _10;else goto _8;
    _10:
        gw(24L,1L,1L);
        gw(24L,4L,1L);
        gw(1L,2L,0L);
        gw(2L,2L,1L);
        gw(3L,2L,td(gr(4L,1L)+gr(1L,2L),gr(2L,2L)));
        sp();
    _11:
        sa(15L);
        sa(15L);
        sa(gr(24L,0L)+(gr(24L,1L)*gr(3L,2L))+gr(1L,3L));
        gw(1L,3L,td(gr(24L,0L)+(gr(24L,1L)*gr(3L,2L))+gr(1L,3L),gr(2L,1L)));
    _12:
        sa(tm(sp(),gr(2L,1L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);
        sa(2L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()-1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        if(sp()!=0)goto _52;else goto _13;
    _13:
        sp();
        sa(15L);
        sa(15L);
        sa(gr(24L,4L)+(gr(24L,5L)*gr(3L,2L))+gr(1L,3L));
        gw(1L,3L,td(gr(24L,4L)+(gr(24L,5L)*gr(3L,2L))+gr(1L,3L),gr(2L,1L)));
    _14:
        sa(tm(sp(),gr(2L,1L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);
        sa(6L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()-1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        if(sp()!=0)goto _15;else goto _16;
    _15:
        sa(sr());
        sa(sr());
        sa(sr()+9L);
        sa(4L);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);
        sa(5L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()*gr(3L,2L));
        sa(sp()+sp());
        sa(sp()+gr(1L,3L));
        sa(td(sr(),gr(2L,1L)));
        gw(1L,3L,sp());
        goto _14;
    _16:
        gw(1L,4L,1L);
        gw(24L,9L,0L);
        sp();
        sa(14L);
    _17:
        sa(sr()+9L);
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(9L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()-1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        if(sp()!=0)goto _17;else goto _19;
    _19:
        gw(2L,4L,15L);
        gw(3L,4L,gr(2L,4L)+9L);
        sp();
    _20:
        sa(15L);
        sa((gr(24L,6L)*gr(gr(2L,4L)+9L,6L)*gr(3L,1L))+gr(1L,4L)+gr(gr(3L,4L),9L));
        gw(1L,4L,td((gr(24L,6L)*gr(gr(2L,4L)+9L,6L)*gr(3L,1L))+gr(1L,4L)+gr(gr(3L,4L),9L),gr(2L,1L)));
    _21:
        sa(tm(sp(),gr(2L,1L)));
        gw(gr(3L,4L),9L,sp());
        sa(sp()-1L);
        if(gr(3L,4L)-9L==0)goto _22;else goto _51;
    _22:
        sp();
        sa(gr(2L,4L)-1L);
        if((gr(2L,4L))==0)goto _24;else goto _23;
    _23:
        gw(2L,4L,sp());
        gw(3L,4L,gr(2L,4L)+9L);
        goto _20;
    _24:
        gw(1L,4L,0L);
        gw(24L,7L,0L);
        sp();
        sa(14L);
    _25:
        sa(sr()+9L);
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(7L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()-1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        if(sp()!=0)goto _25;else goto _27;
    _27:
        gw(2L,4L,15L);
        gw(3L,4L,gr(2L,4L)+9L);
        sp();
    _28:
        sa(15L);
        sa((gr(24L,2L)*gr(gr(2L,4L)+9L,2L))+gr(1L,4L)+gr(gr(3L,4L),7L));
        gw(1L,4L,td((gr(24L,2L)*gr(gr(2L,4L)+9L,2L))+gr(1L,4L)+gr(gr(3L,4L),7L),gr(2L,1L)));
    _29:
        sa(tm(sp(),gr(2L,1L)));
        gw(gr(3L,4L),7L,sp());
        sa(sp()-1L);
        if(gr(3L,4L)-9L==0)goto _30;else goto _50;
    _30:
        sp();
        sa(gr(2L,4L)-1L);
        if((gr(2L,4L))==0)goto _31;else goto _49;
    _31:
        sp();
        sa(15L);
        sa(gr(24L,7L)-gr(24L,9L));
    _32:
        if(sp()!=0)goto _45;else goto _33;
    _33:
        sa(sr()-1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        if(sp()!=0)goto _44;else goto _34;
    _34:
        sp();
        sa(0L);
        sa(gr(9L,2L)-gr(9L,8L));
        sa(gr(9L,2L)-gr(9L,8L));
    _35:
        if(sp()!=0)goto _40;else goto _36;
    _36:
        sp();
        sa(sp()+1L);
        if(sr()-17L==0)goto _37;else goto _39;
    _37:
        sp();
        sa(gr(3L,1L)+1L);
        gw(3L,1L,gr(3L,1L)+1L);
        sa(sp()-1000L);
        if(sp()!=0)goto _4;else goto _38;
    _38:
        System.Console.Out.Write((long)(gr(1L,1L)));
        return;
    _39:
        sa(sr());
        sa(sr()+9L);
        sa(2L);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);
        sa(8L);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _35;
    _40:
        sa((sp()>0L)?1:0);
        if(sp()!=0)goto _41;else goto _37;
    _41:
        gw(1L,1L,gr(3L,1L));
        gw(24L,8L,gr(24L,2L));
        sp();
        sa(14L);
    _42:
        sa(sr());
        sa(sr()+9L);
        sa(2L);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);
        sa(8L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()-1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _37;else goto _42;
    _44:
        sa(sr());
        sa(sr()+9L);
        sa(7L);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);
        sa(9L);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();sa(sp()-v0);}
        goto _32;
    _45:
        gw(1L,2L,(gr(3L,2L)*gr(2L,2L))-gr(1L,2L));
        gw(2L,2L,td(gr(3L,1L)-(gr(1L,2L)*gr(1L,2L)),gr(2L,2L)));
        sp();
        sa(15L);
    _46:
        sa(sr());
        sa(sr()+9L);
        sa(1L);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);
        sa(0L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(sr()+9L);
        sa(2L);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);
        sa(1L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(sr()+9L);
        sa(5L);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);
        sa(4L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(sr()+9L);
        sa(6L);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);
        sa(5L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()-1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _48;else goto _46;
    _48:
        gw(3L,2L,td(gr(4L,1L)+gr(1L,2L),gr(2L,2L)));
        sp();
        goto _11;
    _49:
        gw(2L,4L,sp());
        gw(3L,4L,gr(2L,4L)+9L);
        goto _28;
    _50:
        sa(sr());
        sa((sr()+gr(2L,4L))-6L);
        gw(3L,4L,sp());
        sa(sp()+9L);
        sa(2L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()*gr(gr(2L,4L)+9L,2L));
        sa(sp()+gr(1L,4L));
        sa(sp()+gr(gr(3L,4L),7L));
        sa(td(sr(),gr(2L,1L)));
        gw(1L,4L,sp());
        goto _29;
    _51:
        sa(sr());
        sa((sr()+gr(2L,4L))-6L);
        gw(3L,4L,sp());
        sa(sp()+9L);
        sa(6L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()*gr(gr(2L,4L)+9L,6L)*gr(3L,1L));
        sa(sp()+gr(1L,4L));
        sa(sp()+gr(gr(3L,4L),9L));
        sa(td(sr(),gr(2L,1L)));
        gw(1L,4L,sp());
        goto _21;
    _52:
        sa(sr());
        sa(sr());
        sa(sr()+9L);
        sa(0L);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);
        sa(1L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()*gr(3L,2L));
        sa(sp()+sp());
        sa(sp()+gr(1L,3L));
        sa(td(sr(),gr(2L,1L)));
        gw(1L,3L,sp());
        goto _12;
    _53:
        gw(3L,1L,gr(3L,1L)+1L);
        sa(gr(3L,1L));
        gw(1L,0L,0L);
        sa(sr());
        gw(2L,0L,sp());
        goto _5;
    _54:
        if(sr()!=gr(1L,0L))goto _55;else goto _6;
    _55:
        gw(1L,0L,gr(3L,0L));
        goto _5;
}}