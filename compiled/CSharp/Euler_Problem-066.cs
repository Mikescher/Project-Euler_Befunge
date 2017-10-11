/* transpiled with BefunCompile v1.2.0 (c) 2017 */
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
static void Main(string[]args)
{
        long t0,t1;
        gw(2,1,67108864);
        gw(3,1,3);
        gw(1,3,0);
        gw(24,8,0);
        sa(15);
    _1:
        sa(sr()+8);
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(8);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()-1L);

        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _3;else goto _1;
    _3:
        sp();
    _4:
        sa(gr(3,1));
        gw(1,0,0);
        sa(sr());
        gw(2,0,sp());
    _5:
        sa(sr());
        gw(3,0,sp());
        sa(sr());
        t0=gr(2,0);
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(td(sp(),v0));}

        t1=sp();
        sa(sp()+t1);

        sa(td(sp(),2));


        if(sr()!=gr(3,0))goto _54;else goto _6;
    _6:
        sp();
        sa(gr(3,0));
        gw(4,1,gr(3,0));
        sa(sr());
        sa(sp()*sp());

        t0=sp();
        t0-=gr(3,1);

        if((t0)!=0)goto _7;else goto _53;
    _7:
        gw(24,5,0);
        gw(24,4,0);
        gw(24,1,0);
        gw(24,0,0);
        sa(15);
    _8:
        sa(sr()+8);
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(5);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()+8);
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(4);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()+8);
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()+8);
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(0);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()-1L);

        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _10;else goto _8;
    _10:
        gw(24,1,1);
        gw(24,4,1);
        gw(1,2,0);
        gw(2,2,1);
        gw(3,2,td(gr(4,1)+gr(1,2),gr(2,2)));
        sp();
    _11:
        sa(15);
        sa(15);
        sa(gr(24,0)+(gr(24,1)*gr(3,2))+gr(1,3));
        gw(1,3,td(gr(24,0)+(gr(24,1)*gr(3,2))+gr(1,3),gr(2,1)));
    _12:
        sa(tm(sp(),gr(2,1)));

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);

        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}

        if(sp()!=0)goto _52;else goto _13;
    _13:
        sp();
        sa(15);
        sa(15);
        sa(gr(24,4)+(gr(24,5)*gr(3,2))+gr(1,3));
        gw(1,3,td(gr(24,4)+(gr(24,5)*gr(3,2))+gr(1,3),gr(2,1)));
    _14:
        sa(tm(sp(),gr(2,1)));

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);

        sa(6);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}

        if(sp()!=0)goto _15;else goto _16;
    _15:
        sa(sr());
        sa(sr());
        sa(sr()+9);
        sa(4);
        {long v0=sp();t0=gr(sp(),v0);}
        sa(sp()+9L);

        sa(5);
        {long v0=sp();t1=gr(sp(),v0);}
        t1*=gr(3,2);
        sa(t0+t1);
        sa(sp()+gr(1,3));

        t0=td(sr(),gr(2,1));
        gw(1,3,t0);
        goto _14;
    _16:
        gw(1,4,1);
        gw(24,9,0);
        sp();
        sa(14);
    _17:
        sa(sr()+9);
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(9);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        if(sp()!=0)goto _17;else goto _19;
    _19:
        gw(2,4,15);
        gw(3,4,gr(2,4)+9);
        sp();
    _20:
        sa(15);
        sa((gr(24,6)*gr(gr(2,4)+9,6)*gr(3,1))+gr(1,4)+gr(gr(3,4),9));
        gw(1,4,td((gr(24,6)*gr(gr(2,4)+9,6)*gr(3,1))+gr(1,4)+gr(gr(3,4),9),gr(2,1)));
    _21:
        sa(tm(sp(),gr(2,1)));

        gw(gr(3,4),9,sp());
        sa(sp()-1L);


        if(gr(3,4)-9==0)goto _22;else goto _51;
    _22:
        sp();
        t0=gr(2,4)-1;

        if((gr(2,4))==0)goto _23;else goto _50;
    _23:
        gw(1,4,0);
        gw(24,7,0);
        sa(14);
    _24:
        sa(sr()+9);
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(7);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        if(sp()!=0)goto _24;else goto _26;
    _26:
        gw(2,4,15);
        gw(3,4,gr(2,4)+9);
        sp();
    _27:
        sa(15);
        sa((gr(24,2)*gr(gr(2,4)+9,2))+gr(1,4)+gr(gr(3,4),7));
        gw(1,4,td((gr(24,2)*gr(gr(2,4)+9,2))+gr(1,4)+gr(gr(3,4),7),gr(2,1)));
    _28:
        sa(tm(sp(),gr(2,1)));

        gw(gr(3,4),7,sp());
        sa(sp()-1L);


        if(gr(3,4)-9==0)goto _29;else goto _49;
    _29:
        sp();
        t0=gr(2,4)-1;

        if((gr(2,4))==0)goto _30;else goto _48;
    _30:
        sa(15);
        sa(gr(24,7)-gr(24,9));
    _31:
        if(sp()!=0)goto _44;else goto _32;
    _32:
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}

        if(sp()!=0)goto _43;else goto _33;
    _33:
        sp();
        sa(0);
        sa(gr(9,2)-gr(9,8));
        sa(gr(9,2)-gr(9,8));
    _34:
        if(sp()!=0)goto _39;else goto _35;
    _35:
        sp();
        sa(sp()+1L);


        if(sr()-17==0)goto _36;else goto _38;
    _36:
        sp();
        t0=gr(3,1)+1;
        gw(3,1,gr(3,1)+1);
        t0-=1000;

        if((t0)!=0)goto _4;else goto _37;
    _37:
        System.Console.Out.Write(gr(1,1)+" ");
        return;
    _38:
        sa(sr());
        sa(sr()+9);
        sa(2);
        {long v0=sp();t0=gr(sp(),v0);}
        sa(sp()+9L);

        sa(8);
        {long v0=sp();t1=gr(sp(),v0);}
        sa(t0-t1);
        sa(sr());
        goto _34;
    _39:
        sa((sp()>0)?1:0);


        if(sp()!=0)goto _40;else goto _36;
    _40:
        gw(1,1,gr(3,1));
        gw(24,8,gr(24,2));
        sp();
        sa(14);
    _41:
        sa(sr());
        sa(sr()+9);
        sa(2);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);

        sa(8);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _36;else goto _41;
    _43:
        sa(sr());
        sa(sr()+9);
        sa(7);
        {long v0=sp();t0=gr(sp(),v0);}
        sa(sp()+9L);

        sa(9);
        {long v0=sp();t1=gr(sp(),v0);}
        sa(t0-t1);
        goto _31;
    _44:
        gw(1,2,(gr(3,2)*gr(2,2))-gr(1,2));
        gw(2,2,td(gr(3,1)-(gr(1,2)*gr(1,2)),gr(2,2)));
        sp();
        sa(15);
    _45:
        sa(sr());
        sa(sr()+9);
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);

        sa(0);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(sr()+9);
        sa(2);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);

        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(sr()+9);
        sa(5);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);

        sa(4);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(sr()+9);
        sa(6);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);

        sa(5);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _47;else goto _45;
    _47:
        gw(3,2,td(gr(4,1)+gr(1,2),gr(2,2)));
        sp();
        goto _11;
    _48:
        gw(2,4,t0);
        gw(3,4,gr(2,4)+9);
        goto _27;
    _49:
        sa(sr());
        t0=(sr()+gr(2,4))-6;
        gw(3,4,t0);
        sa(sp()+9L);

        sa(2);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()*gr(gr(2,4)+9,2));

        sa(sp()+gr(1,4));

        sa(sp()+gr(gr(3,4),7));

        t0=td(sr(),gr(2,1));
        gw(1,4,t0);
        goto _28;
    _50:
        gw(2,4,t0);
        gw(3,4,gr(2,4)+9);
        goto _20;
    _51:
        sa(sr());
        t0=(sr()+gr(2,4))-6;
        gw(3,4,t0);
        sa(sp()+9L);

        sa(6);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()*gr(gr(2,4)+9,6)*gr(3,1));

        sa(sp()+gr(1,4));

        sa(sp()+gr(gr(3,4),9));

        t0=td(sr(),gr(2,1));
        gw(1,4,t0);
        goto _21;
    _52:
        sa(sr());
        sa(sr());
        sa(sr()+9);
        sa(0);
        {long v0=sp();t0=gr(sp(),v0);}
        sa(sp()+9L);

        sa(1);
        {long v0=sp();t1=gr(sp(),v0);}
        t1*=gr(3,2);
        sa(t0+t1);
        sa(sp()+gr(1,3));

        t0=td(sr(),gr(2,1));
        gw(1,3,t0);
        goto _12;
    _53:
        gw(3,1,gr(3,1)+1);
        sa(gr(3,1));
        gw(1,0,0);
        sa(sr());
        gw(2,0,sp());
        goto _5;
    _54:
        if(sr()!=gr(1,0))goto _55;else goto _6;
    _55:
        gw(1,0,gr(3,0));
        goto _5;
}
}
